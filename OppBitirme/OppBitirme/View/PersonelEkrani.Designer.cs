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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkrani));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtDrAdres = new System.Windows.Forms.TextBox();
            this.txtDrTel = new System.Windows.Forms.TextBox();
            this.txtDrTckn = new System.Windows.Forms.TextBox();
            this.dtpDrDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDrCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbDrBrans = new System.Windows.Forms.ComboBox();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDradi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDrSoyad = new System.Windows.Forms.Label();
            this.lblDrAd = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbPersonelMail = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPersonelMail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tckn";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Brans";
            this.columnHeader4.Width = 82;
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
            this.listView1.Location = new System.Drawing.Point(3, 409);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(632, 256);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtDrAdres
            // 
            this.txtDrAdres.Location = new System.Drawing.Point(303, 221);
            this.txtDrAdres.Name = "txtDrAdres";
            this.txtDrAdres.Size = new System.Drawing.Size(270, 20);
            this.txtDrAdres.TabIndex = 44;
            // 
            // txtDrTel
            // 
            this.txtDrTel.Location = new System.Drawing.Point(303, 190);
            this.txtDrTel.Name = "txtDrTel";
            this.txtDrTel.Size = new System.Drawing.Size(270, 20);
            this.txtDrTel.TabIndex = 43;
            // 
            // txtDrTckn
            // 
            this.txtDrTckn.Location = new System.Drawing.Point(321, 160);
            this.txtDrTckn.Name = "txtDrTckn";
            this.txtDrTckn.Size = new System.Drawing.Size(222, 20);
            this.txtDrTckn.TabIndex = 42;
            // 
            // dtpDrDogumTarihi
            // 
            this.dtpDrDogumTarihi.Location = new System.Drawing.Point(321, 128);
            this.dtpDrDogumTarihi.Name = "dtpDrDogumTarihi";
            this.dtpDrDogumTarihi.Size = new System.Drawing.Size(222, 20);
            this.dtpDrDogumTarihi.TabIndex = 41;
            // 
            // cmbDrCinsiyet
            // 
            this.cmbDrCinsiyet.FormattingEnabled = true;
            this.cmbDrCinsiyet.Location = new System.Drawing.Point(321, 94);
            this.cmbDrCinsiyet.Name = "cmbDrCinsiyet";
            this.cmbDrCinsiyet.Size = new System.Drawing.Size(222, 21);
            this.cmbDrCinsiyet.TabIndex = 40;
            // 
            // cmbDrBrans
            // 
            this.cmbDrBrans.FormattingEnabled = true;
            this.cmbDrBrans.Location = new System.Drawing.Point(321, 60);
            this.cmbDrBrans.Name = "cmbDrBrans";
            this.cmbDrBrans.Size = new System.Drawing.Size(222, 21);
            this.cmbDrBrans.TabIndex = 39;
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(321, 31);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(222, 20);
            this.txtDrSoyad.TabIndex = 29;
            // 
            // txtDradi
            // 
            this.txtDradi.Location = new System.Drawing.Point(321, 1);
            this.txtDradi.Name = "txtDradi";
            this.txtDradi.Size = new System.Drawing.Size(222, 20);
            this.txtDradi.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(183, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "E-Posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(183, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(183, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(183, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "T.C. No :";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(183, 98);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(69, 17);
            this.lblCinsiyet.TabIndex = 76;
            this.lblCinsiyet.Text = "Cinsiyeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Branşı :";
            // 
            // lblDrSoyad
            // 
            this.lblDrSoyad.AutoSize = true;
            this.lblDrSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDrSoyad.Location = new System.Drawing.Point(183, 31);
            this.lblDrSoyad.Name = "lblDrSoyad";
            this.lblDrSoyad.Size = new System.Drawing.Size(57, 17);
            this.lblDrSoyad.TabIndex = 74;
            this.lblDrSoyad.Text = "Soyadı :";
            // 
            // lblDrAd
            // 
            this.lblDrAd.AutoSize = true;
            this.lblDrAd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrAd.Location = new System.Drawing.Point(183, 4);
            this.lblDrAd.Name = "lblDrAd";
            this.lblDrAd.Size = new System.Drawing.Size(41, 17);
            this.lblDrAd.TabIndex = 73;
            this.lblDrAd.Text = " Adı :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(321, 277);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(222, 110);
            this.btnGuncelle.TabIndex = 82;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbPersonelMail
            // 
            this.cmbPersonelMail.FormattingEnabled = true;
            this.cmbPersonelMail.Location = new System.Drawing.Point(453, 250);
            this.cmbPersonelMail.Name = "cmbPersonelMail";
            this.cmbPersonelMail.Size = new System.Drawing.Size(120, 21);
            this.cmbPersonelMail.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "@";
            // 
            // txtPersonelMail
            // 
            this.txtPersonelMail.Location = new System.Drawing.Point(303, 251);
            this.txtPersonelMail.Name = "txtPersonelMail";
            this.txtPersonelMail.Size = new System.Drawing.Size(121, 20);
            this.txtPersonelMail.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PersonelEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbPersonelMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersonelMail);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDrSoyad);
            this.Controls.Add(this.lblDrAd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtDrAdres);
            this.Controls.Add(this.txtDrTel);
            this.Controls.Add(this.txtDrTckn);
            this.Controls.Add(this.dtpDrDogumTarihi);
            this.Controls.Add(this.cmbDrCinsiyet);
            this.Controls.Add(this.cmbDrBrans);
            this.Controls.Add(this.txtDrSoyad);
            this.Controls.Add(this.txtDradi);
            this.Name = "PersonelEkrani";
            this.Size = new System.Drawing.Size(485, 605);
            this.Load += new System.EventHandler(this.PersonelEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtDrAdres;
        private System.Windows.Forms.TextBox txtDrTel;
        private System.Windows.Forms.TextBox txtDrTckn;
        private System.Windows.Forms.DateTimePicker dtpDrDogumTarihi;
        private System.Windows.Forms.ComboBox cmbDrCinsiyet;
        private System.Windows.Forms.ComboBox cmbDrBrans;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDradi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDrSoyad;
        private System.Windows.Forms.Label lblDrAd;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbPersonelMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPersonelMail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}