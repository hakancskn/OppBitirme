﻿namespace OppBitirme.View
{
    partial class GuncelleEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuncelleEkran));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtHastaAdres = new System.Windows.Forms.TextBox();
            this.txtHastaTel = new System.Windows.Forms.TextBox();
            this.txtHastaTckn = new System.Windows.Forms.TextBox();
            this.dtpHastaDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbHastaCinsiyeti = new System.Windows.Forms.ComboBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHastaMail = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblBrans = new System.Windows.Forms.Label();
            this.cmbKisiBrans = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHemsire = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chlBosHemsire = new System.Windows.Forms.CheckedListBox();
            this.chlsDktHemsire = new System.Windows.Forms.CheckedListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHemsire.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tckn";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cinsiyet";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 95;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.menu;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 365);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(778, 230);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtHastaAdres
            // 
            this.txtHastaAdres.Location = new System.Drawing.Point(331, 205);
            this.txtHastaAdres.Name = "txtHastaAdres";
            this.txtHastaAdres.Size = new System.Drawing.Size(209, 20);
            this.txtHastaAdres.TabIndex = 34;
            // 
            // txtHastaTel
            // 
            this.txtHastaTel.Location = new System.Drawing.Point(331, 176);
            this.txtHastaTel.Name = "txtHastaTel";
            this.txtHastaTel.Size = new System.Drawing.Size(209, 20);
            this.txtHastaTel.TabIndex = 33;
            // 
            // txtHastaTckn
            // 
            this.txtHastaTckn.Location = new System.Drawing.Point(331, 146);
            this.txtHastaTckn.Name = "txtHastaTckn";
            this.txtHastaTckn.Size = new System.Drawing.Size(209, 20);
            this.txtHastaTckn.TabIndex = 32;
            // 
            // dtpHastaDogumTarihi
            // 
            this.dtpHastaDogumTarihi.Location = new System.Drawing.Point(331, 116);
            this.dtpHastaDogumTarihi.Name = "dtpHastaDogumTarihi";
            this.dtpHastaDogumTarihi.Size = new System.Drawing.Size(209, 20);
            this.dtpHastaDogumTarihi.TabIndex = 31;
            // 
            // cmbHastaCinsiyeti
            // 
            this.cmbHastaCinsiyeti.FormattingEnabled = true;
            this.cmbHastaCinsiyeti.Location = new System.Drawing.Point(331, 86);
            this.cmbHastaCinsiyeti.Name = "cmbHastaCinsiyeti";
            this.cmbHastaCinsiyeti.Size = new System.Drawing.Size(209, 21);
            this.cmbHastaCinsiyeti.TabIndex = 30;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(331, 56);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(209, 20);
            this.txtHastaSoyadi.TabIndex = 29;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(331, 26);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(209, 20);
            this.txtHastaAdi.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(224, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "E-Posta :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(224, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Adres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(224, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Telefon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(224, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 59;
            this.label10.Text = "T.C. No :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(224, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Cinsiyeti :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(224, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 57;
            this.label12.Text = "Soyadı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(224, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = " Adı :";
            // 
            // txtHastaMail
            // 
            this.txtHastaMail.Location = new System.Drawing.Point(331, 233);
            this.txtHastaMail.Name = "txtHastaMail";
            this.txtHastaMail.Size = new System.Drawing.Size(209, 20);
            this.txtHastaMail.TabIndex = 35;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(331, 328);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(206, 31);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrans.Location = new System.Drawing.Point(7, 15);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(50, 17);
            this.lblBrans.TabIndex = 35;
            this.lblBrans.Text = "Branşı:";
            // 
            // cmbKisiBrans
            // 
            this.cmbKisiBrans.FormattingEnabled = true;
            this.cmbKisiBrans.Location = new System.Drawing.Point(116, 15);
            this.cmbKisiBrans.Name = "cmbKisiBrans";
            this.cmbKisiBrans.Size = new System.Drawing.Size(206, 21);
            this.cmbKisiBrans.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKisiBrans);
            this.panel1.Controls.Add(this.lblBrans);
            this.panel1.Location = new System.Drawing.Point(215, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 63);
            this.panel1.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHemsire
            // 
            this.pnlHemsire.Controls.Add(this.label3);
            this.pnlHemsire.Controls.Add(this.label2);
            this.pnlHemsire.Controls.Add(this.btnCikar);
            this.pnlHemsire.Controls.Add(this.btnEkle);
            this.pnlHemsire.Controls.Add(this.chlBosHemsire);
            this.pnlHemsire.Controls.Add(this.chlsDktHemsire);
            this.pnlHemsire.Location = new System.Drawing.Point(546, 15);
            this.pnlHemsire.Name = "pnlHemsire";
            this.pnlHemsire.Size = new System.Drawing.Size(261, 344);
            this.pnlHemsire.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Boştaki Hemşireler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Doktora Bağlı Hemşireler:";
            // 
            // btnCikar
            // 
            this.btnCikar.BackgroundImage = global::OppBitirme.Properties.Resources.Down;
            this.btnCikar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikar.Location = new System.Drawing.Point(142, 153);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(40, 38);
            this.btnCikar.TabIndex = 94;
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::OppBitirme.Properties.Resources.Up;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Location = new System.Drawing.Point(61, 153);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(46, 38);
            this.btnEkle.TabIndex = 93;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chlBosHemsire
            // 
            this.chlBosHemsire.FormattingEnabled = true;
            this.chlBosHemsire.Location = new System.Drawing.Point(1, 214);
            this.chlBosHemsire.Name = "chlBosHemsire";
            this.chlBosHemsire.Size = new System.Drawing.Size(261, 124);
            this.chlBosHemsire.TabIndex = 92;
            // 
            // chlsDktHemsire
            // 
            this.chlsDktHemsire.FormattingEnabled = true;
            this.chlsDktHemsire.Location = new System.Drawing.Point(1, 23);
            this.chlsDktHemsire.Name = "chlsDktHemsire";
            this.chlsDktHemsire.Size = new System.Drawing.Size(261, 124);
            this.chlsDktHemsire.TabIndex = 91;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(86, 338);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(132, 20);
            this.txtArama.TabIndex = 92;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Arama:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sil});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(87, 26);
            // 
            // Sil
            // 
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(152, 22);
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // GuncelleEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.pnlHemsire);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHastaMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtHastaAdres);
            this.Controls.Add(this.txtHastaTel);
            this.Controls.Add(this.txtHastaTckn);
            this.Controls.Add(this.dtpHastaDogumTarihi);
            this.Controls.Add(this.cmbHastaCinsiyeti);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Name = "GuncelleEkran";
            this.Size = new System.Drawing.Size(827, 607);
            this.Load += new System.EventHandler(this.GuncelleEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHemsire.ResumeLayout(false);
            this.pnlHemsire.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtHastaAdres;
        private System.Windows.Forms.TextBox txtHastaTel;
        private System.Windows.Forms.TextBox txtHastaTckn;
        private System.Windows.Forms.DateTimePicker dtpHastaDogumTarihi;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyeti;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHastaMail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.ComboBox cmbKisiBrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHemsire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckedListBox chlBosHemsire;
        private System.Windows.Forms.CheckedListBox chlsDktHemsire;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Sil;
    }
}