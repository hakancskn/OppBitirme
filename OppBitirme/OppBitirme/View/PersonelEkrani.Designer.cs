namespace OppBitirme.View
{
    partial class PersonelEkrani
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtDrMail = new System.Windows.Forms.TextBox();
            this.txtDrAdres = new System.Windows.Forms.TextBox();
            this.txtDrTel = new System.Windows.Forms.TextBox();
            this.txtDrTckn = new System.Windows.Forms.TextBox();
            this.dtpDrDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDrCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbDrBrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDrSoyad = new System.Windows.Forms.Label();
            this.lblDrAd = new System.Windows.Forms.Label();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDradi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tckn";
            this.columnHeader5.Width = 462;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Brans";
            this.columnHeader4.Width = 213;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(520, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(164, 74);
            this.btnGuncelle.TabIndex = 47;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(905, 217);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtDrMail
            // 
            this.txtDrMail.Location = new System.Drawing.Point(138, 288);
            this.txtDrMail.Name = "txtDrMail";
            this.txtDrMail.Size = new System.Drawing.Size(185, 20);
            this.txtDrMail.TabIndex = 45;
            // 
            // txtDrAdres
            // 
            this.txtDrAdres.Location = new System.Drawing.Point(138, 251);
            this.txtDrAdres.Name = "txtDrAdres";
            this.txtDrAdres.Size = new System.Drawing.Size(185, 20);
            this.txtDrAdres.TabIndex = 44;
            // 
            // txtDrTel
            // 
            this.txtDrTel.Location = new System.Drawing.Point(138, 217);
            this.txtDrTel.Name = "txtDrTel";
            this.txtDrTel.Size = new System.Drawing.Size(185, 20);
            this.txtDrTel.TabIndex = 43;
            // 
            // txtDrTckn
            // 
            this.txtDrTckn.Location = new System.Drawing.Point(138, 187);
            this.txtDrTckn.Name = "txtDrTckn";
            this.txtDrTckn.Size = new System.Drawing.Size(185, 20);
            this.txtDrTckn.TabIndex = 42;
            // 
            // dtpDrDogumTarihi
            // 
            this.dtpDrDogumTarihi.Location = new System.Drawing.Point(138, 151);
            this.dtpDrDogumTarihi.Name = "dtpDrDogumTarihi";
            this.dtpDrDogumTarihi.Size = new System.Drawing.Size(185, 20);
            this.dtpDrDogumTarihi.TabIndex = 41;
            // 
            // cmbDrCinsiyet
            // 
            this.cmbDrCinsiyet.FormattingEnabled = true;
            this.cmbDrCinsiyet.Location = new System.Drawing.Point(138, 117);
            this.cmbDrCinsiyet.Name = "cmbDrCinsiyet";
            this.cmbDrCinsiyet.Size = new System.Drawing.Size(185, 21);
            this.cmbDrCinsiyet.TabIndex = 40;
            // 
            // cmbDrBrans
            // 
            this.cmbDrBrans.FormattingEnabled = true;
            this.cmbDrBrans.Location = new System.Drawing.Point(138, 83);
            this.cmbDrBrans.Name = "cmbDrBrans";
            this.cmbDrBrans.Size = new System.Drawing.Size(185, 21);
            this.cmbDrBrans.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tckn :";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(17, 117);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(75, 16);
            this.lblCinsiyet.TabIndex = 33;
            this.lblCinsiyet.Text = "Cinsiyeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Branşı :";
            // 
            // lblDrSoyad
            // 
            this.lblDrSoyad.AutoSize = true;
            this.lblDrSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrSoyad.Location = new System.Drawing.Point(17, 54);
            this.lblDrSoyad.Name = "lblDrSoyad";
            this.lblDrSoyad.Size = new System.Drawing.Size(65, 16);
            this.lblDrSoyad.TabIndex = 31;
            this.lblDrSoyad.Text = "Soyadı :";
            // 
            // lblDrAd
            // 
            this.lblDrAd.AutoSize = true;
            this.lblDrAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrAd.Location = new System.Drawing.Point(17, 24);
            this.lblDrAd.Name = "lblDrAd";
            this.lblDrAd.Size = new System.Drawing.Size(43, 16);
            this.lblDrAd.TabIndex = 30;
            this.lblDrAd.Text = " Adı :";
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(138, 54);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(185, 20);
            this.txtDrSoyad.TabIndex = 29;
            // 
            // txtDradi
            // 
            this.txtDradi.Location = new System.Drawing.Point(138, 24);
            this.txtDradi.Name = "txtDradi";
            this.txtDradi.Size = new System.Drawing.Size(185, 20);
            this.txtDradi.TabIndex = 28;
            // 
            // PersonelEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtDrMail);
            this.Controls.Add(this.txtDrAdres);
            this.Controls.Add(this.txtDrTel);
            this.Controls.Add(this.txtDrTckn);
            this.Controls.Add(this.dtpDrDogumTarihi);
            this.Controls.Add(this.cmbDrCinsiyet);
            this.Controls.Add(this.cmbDrBrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDrSoyad);
            this.Controls.Add(this.lblDrAd);
            this.Controls.Add(this.txtDrSoyad);
            this.Controls.Add(this.txtDradi);
            this.Name = "PersonelEkrani";
            this.Size = new System.Drawing.Size(893, 577);
            this.Load += new System.EventHandler(this.PersonelEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtDrMail;
        private System.Windows.Forms.TextBox txtDrAdres;
        private System.Windows.Forms.TextBox txtDrTel;
        private System.Windows.Forms.TextBox txtDrTckn;
        private System.Windows.Forms.DateTimePicker dtpDrDogumTarihi;
        private System.Windows.Forms.ComboBox cmbDrCinsiyet;
        private System.Windows.Forms.ComboBox cmbDrBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDrSoyad;
        private System.Windows.Forms.Label lblDrAd;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDradi;
    }
}
