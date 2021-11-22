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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();

                var command = new SqlCommand("SELECT * FROM emberek;", c);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(
                        reader.GetInt32(0) * 10,
                        reader["nev"],
                        reader.GetDateTime(2).ToString("yyyy-MM-dd"),
                        reader.GetDateTime(3).ToString("MMM dd, HH:mm"),
                        reader.GetTimeSpan(4));
                }
            }
        }
    }
}
