using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211122
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }

        public FrmMain()
        {
            ConnectionString = 
                "Server = (localdb)\\MSSQLLocalDB;" +
                "Database = datumok;";
            InitializeComponent();
            dtpOltasDatum.CustomFormat = "MMMM dd.";
            dtpSzul.MaxDate = DateTime.Now;
            dtpOltasDatum.MinDate = new DateTime(2020, 03, 16);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void FillDgv()
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var command = new SqlCommand("SELECT * FROM emberek;", c);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader.GetInt32(0),
                        reader["nev"],
                        reader.GetDateTime(2).ToString("yyyy-MM-dd"),
                        reader.GetDateTime(3).ToString("MMM dd, HH:mm"),
                        reader.GetTimeSpan(4));
                }
            }
        }

        private void BtnHozzaad_Click(object sender, EventArgs e)
        {
            string nev = tbNev.Text;
            string szul = dtpSzul.Value.ToString("yyyy-MM-dd");
            string oltas = $"{dtpOltasDatum.Value.ToString("yyyy-MM-dd")} {tbOltasOra.Text}:{tbOltasPerc.Text}";
            string elsoOra = $"{tbElsoOraOra.Text}:{tbElsoOraPerc.Text}";

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var command = new SqlCommand(
                    "INSERT INTO emberek VALUES " +
                    $"('{nev}', '{szul}', '{oltas}', '{elsoOra}');", c);

                try
                {
                    string execeptionMessage = "";

                    if (string.IsNullOrWhiteSpace(nev)) execeptionMessage += "üresen maradt a név mező\n";
                    if (!int.TryParse(tbOltasOra.Text, out _)) execeptionMessage += "nem jó az oltás óra\n";
                    if (!int.TryParse(tbOltasPerc.Text, out _)) execeptionMessage += "nem jó az oltás perc\n";
                    //if (!int.TryParse(tbElsoOraOra.Text, out _)) throw new Exception();
                    //if (!int.TryParse(tbElsoOraPerc.Text, out _)) throw new Exception();

                    if (!string.IsNullOrEmpty(execeptionMessage))
                        throw new Exception(execeptionMessage);


                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            FillDgv();
        }
    }
}
