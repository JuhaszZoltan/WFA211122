namespace WFA211122
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpOltasDatum = new System.Windows.Forms.DateTimePicker();
            this.tbElsoOraOra = new System.Windows.Forms.TextBox();
            this.tbElsoOraPerc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOltasOra = new System.Windows.Forms.TextBox();
            this.tbOltasPerc = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1032, 311);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "név";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "szül";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "oltas";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "első óra";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Születési dátum:";
            // 
            // dtpSzul
            // 
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(184, 434);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(200, 26);
            this.dtpSzul.TabIndex = 2;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(184, 376);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(200, 26);
            this.tbNev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Első óra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Oltás:";
            // 
            // dtpOltasDatum
            // 
            this.dtpOltasDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOltasDatum.Location = new System.Drawing.Point(592, 376);
            this.dtpOltasDatum.Name = "dtpOltasDatum";
            this.dtpOltasDatum.Size = new System.Drawing.Size(200, 26);
            this.dtpOltasDatum.TabIndex = 2;
            // 
            // tbElsoOraOra
            // 
            this.tbElsoOraOra.Location = new System.Drawing.Point(592, 434);
            this.tbElsoOraOra.Name = "tbElsoOraOra";
            this.tbElsoOraOra.Size = new System.Drawing.Size(36, 26);
            this.tbElsoOraOra.TabIndex = 3;
            // 
            // tbElsoOraPerc
            // 
            this.tbElsoOraPerc.Location = new System.Drawing.Point(653, 434);
            this.tbElsoOraPerc.Name = "tbElsoOraPerc";
            this.tbElsoOraPerc.Size = new System.Drawing.Size(36, 26);
            this.tbElsoOraPerc.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(861, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = ":";
            // 
            // tbOltasOra
            // 
            this.tbOltasOra.Location = new System.Drawing.Point(819, 376);
            this.tbOltasOra.Name = "tbOltasOra";
            this.tbOltasOra.Size = new System.Drawing.Size(36, 26);
            this.tbOltasOra.TabIndex = 3;
            // 
            // tbOltasPerc
            // 
            this.tbOltasPerc.Location = new System.Drawing.Point(880, 376);
            this.tbOltasPerc.Name = "tbOltasPerc";
            this.tbOltasPerc.Size = new System.Drawing.Size(36, 26);
            this.tbOltasPerc.TabIndex = 3;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(130, 504);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(827, 54);
            this.btnHozzaad.TabIndex = 4;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.BtnHozzaad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 598);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.tbOltasPerc);
            this.Controls.Add(this.tbOltasOra);
            this.Controls.Add(this.tbElsoOraPerc);
            this.Controls.Add(this.tbElsoOraOra);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dtpOltasDatum);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSzul;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOltasDatum;
        private System.Windows.Forms.TextBox tbElsoOraOra;
        private System.Windows.Forms.TextBox tbElsoOraPerc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOltasOra;
        private System.Windows.Forms.TextBox tbOltasPerc;
        private System.Windows.Forms.Button btnHozzaad;
    }
}

