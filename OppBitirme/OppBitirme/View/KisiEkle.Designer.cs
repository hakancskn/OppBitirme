namespace OppBitirme.View
{
    partial class KisiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiEkle));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chlsHemsire = new System.Windows.Forms.CheckedListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbKisiUnvan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKisiMail = new System.Windows.Forms.TextBox();
            this.cmbKisiCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpKisiDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtKisiAdres = new System.Windows.Forms.TextBox();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.txtKisiTelefon = new System.Windows.Forms.TextBox();
            this.txtKisiSoyad = new System.Windows.Forms.TextBox();
            this.txtKisiTckn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBrans = new System.Windows.Forms.Panel();
            this.lblBrans = new System.Windows.Forms.Label();
            this.cmbKisiBrans = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(321, 367);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 39);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chlsHemsire
            // 
            this.chlsHemsire.FormattingEnabled = true;
            this.chlsHemsire.Location = new System.Drawing.Point(487, 25);
            this.chlsHemsire.Name = "chlsHemsire";
            this.chlsHemsire.Size = new System.Drawing.Size(261, 394);
            this.chlsHemsire.TabIndex = 37;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Location = new System.Drawing.Point(137, 367);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(116, 39);
            this.btnTemizle.TabIndex = 20;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 158);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 137;
            this.label9.Text = "Unvanı:";
            // 
            // cmbKisiUnvan
            // 
            this.cmbKisiUnvan.FormattingEnabled = true;
            this.cmbKisiUnvan.Items.AddRange(new object[] {
            "Hasta",
            "Personel",
            "Doktor",
            "Hemşire"});
            this.cmbKisiUnvan.Location = new System.Drawing.Point(268, 255);
            this.cmbKisiUnvan.Name = "cmbKisiUnvan";
            this.cmbKisiUnvan.Size = new System.Drawing.Size(181, 21);
            this.cmbKisiUnvan.TabIndex = 136;
            this.cmbKisiUnvan.SelectedIndexChanged += new System.EventHandler(this.cmbKisiUnvan_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 135;
            this.label13.Text = "Doğum Tarihi :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(165, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 134;
            this.label14.Text = "E-Posta :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(165, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 133;
            this.label15.Text = "Adres :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(165, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 132;
            this.label16.Text = "Telefon :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(165, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 131;
            this.label17.Text = "T.C. No :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(165, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 130;
            this.label18.Text = "Cinsiyeti :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(165, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 129;
            this.label19.Text = "Soyadı :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(165, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 17);
            this.label20.TabIndex = 128;
            this.label20.Text = " Adı :";
            // 
            // txtKisiMail
            // 
            this.txtKisiMail.Location = new System.Drawing.Point(268, 194);
            this.txtKisiMail.Name = "txtKisiMail";
            this.txtKisiMail.Size = new System.Drawing.Size(181, 20);
            this.txtKisiMail.TabIndex = 127;
            // 
            // cmbKisiCinsiyet
            // 
            this.cmbKisiCinsiyet.FormattingEnabled = true;
            this.cmbKisiCinsiyet.Location = new System.Drawing.Point(268, 109);
            this.cmbKisiCinsiyet.Name = "cmbKisiCinsiyet";
            this.cmbKisiCinsiyet.Size = new System.Drawing.Size(181, 21);
            this.cmbKisiCinsiyet.TabIndex = 126;
            // 
            // dtpKisiDogumTarihi
            // 
            this.dtpKisiDogumTarihi.Location = new System.Drawing.Point(268, 136);
            this.dtpKisiDogumTarihi.Name = "dtpKisiDogumTarihi";
            this.dtpKisiDogumTarihi.Size = new System.Drawing.Size(181, 20);
            this.dtpKisiDogumTarihi.TabIndex = 125;
            // 
            // txtKisiAdres
            // 
            this.txtKisiAdres.Location = new System.Drawing.Point(269, 226);
            this.txtKisiAdres.Multiline = true;
            this.txtKisiAdres.Name = "txtKisiAdres";
            this.txtKisiAdres.Size = new System.Drawing.Size(180, 20);
            this.txtKisiAdres.TabIndex = 124;
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(268, 25);
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(181, 20);
            this.txtKisiAd.TabIndex = 120;
            // 
            // txtKisiTelefon
            // 
            this.txtKisiTelefon.Location = new System.Drawing.Point(268, 162);
            this.txtKisiTelefon.Name = "txtKisiTelefon";
            this.txtKisiTelefon.Size = new System.Drawing.Size(181, 20);
            this.txtKisiTelefon.TabIndex = 123;
            // 
            // txtKisiSoyad
            // 
            this.txtKisiSoyad.Location = new System.Drawing.Point(268, 52);
            this.txtKisiSoyad.Name = "txtKisiSoyad";
            this.txtKisiSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtKisiSoyad.TabIndex = 121;
            // 
            // txtKisiTckn
            // 
            this.txtKisiTckn.Location = new System.Drawing.Point(268, 83);
            this.txtKisiTckn.Name = "txtKisiTckn";
            this.txtKisiTckn.Size = new System.Drawing.Size(181, 20);
            this.txtKisiTckn.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 119;
            // 
            // pnlBrans
            // 
            this.pnlBrans.Controls.Add(this.lblBrans);
            this.pnlBrans.Controls.Add(this.cmbKisiBrans);
            this.pnlBrans.Location = new System.Drawing.Point(153, 282);
            this.pnlBrans.Name = "pnlBrans";
            this.pnlBrans.Size = new System.Drawing.Size(311, 65);
            this.pnlBrans.TabIndex = 138;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrans.Location = new System.Drawing.Point(21, 25);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(50, 17);
            this.lblBrans.TabIndex = 37;
            this.lblBrans.Text = "Branşı:";
            this.lblBrans.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmbKisiBrans
            // 
            this.cmbKisiBrans.FormattingEnabled = true;
            this.cmbKisiBrans.Location = new System.Drawing.Point(117, 21);
            this.cmbKisiBrans.Name = "cmbKisiBrans";
            this.cmbKisiBrans.Size = new System.Drawing.Size(183, 21);
            this.cmbKisiBrans.TabIndex = 38;
            // 
            // KisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.pnlBrans);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbKisiUnvan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtKisiMail);
            this.Controls.Add(this.cmbKisiCinsiyet);
            this.Controls.Add(this.dtpKisiDogumTarihi);
            this.Controls.Add(this.txtKisiAdres);
            this.Controls.Add(this.txtKisiAd);
            this.Controls.Add(this.txtKisiTelefon);
            this.Controls.Add(this.txtKisiSoyad);
            this.Controls.Add(this.txtKisiTckn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chlsHemsire);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Name = "KisiEkle";
            this.Size = new System.Drawing.Size(793, 497);
            this.Load += new System.EventHandler(this.KisiEkle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBrans.ResumeLayout(false);
            this.pnlBrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckedListBox chlsHemsire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbKisiUnvan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKisiMail;
        private System.Windows.Forms.ComboBox cmbKisiCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpKisiDogumTarihi;
        private System.Windows.Forms.TextBox txtKisiAdres;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.TextBox txtKisiTelefon;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.TextBox txtKisiTckn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBrans;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cmbKisiBrans;
    }
}