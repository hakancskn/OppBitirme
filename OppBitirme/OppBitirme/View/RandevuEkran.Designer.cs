namespace OppBitirme.View
{
    partial class YeniRandevuEkrani
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
            this.lstHasta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbServisler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSaatler = new System.Windows.Forms.Panel();
            this.pnlDoktor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.lstRandevu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDoktor.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHasta
            // 
            this.lstHasta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lstHasta.FullRowSelect = true;
            this.lstHasta.HideSelection = false;
            this.lstHasta.Location = new System.Drawing.Point(17, 60);
            this.lstHasta.MultiSelect = false;
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(296, 239);
            this.lstHasta.TabIndex = 48;
            this.lstHasta.UseCompatibleStateImageBehavior = false;
            this.lstHasta.View = System.Windows.Forms.View.Details;
            this.lstHasta.SelectedIndexChanged += new System.EventHandler(this.lstHasta_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tckn";
            this.columnHeader5.Width = 117;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(442, 417);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 58);
            this.btnKaydet.TabIndex = 50;
            this.btnKaydet.Text = "Randevu Oluştur";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbServisler
            // 
            this.cmbServisler.FormattingEnabled = true;
            this.cmbServisler.Location = new System.Drawing.Point(442, 66);
            this.cmbServisler.Name = "cmbServisler";
            this.cmbServisler.Size = new System.Drawing.Size(121, 21);
            this.cmbServisler.TabIndex = 3;
            this.cmbServisler.SelectedIndexChanged += new System.EventHandler(this.cmbServisler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Servisler:";
            // 
            // pnlSaatler
            // 
            this.pnlSaatler.Location = new System.Drawing.Point(356, 152);
            this.pnlSaatler.Name = "pnlSaatler";
            this.pnlSaatler.Size = new System.Drawing.Size(283, 239);
            this.pnlSaatler.TabIndex = 56;
            // 
            // pnlDoktor
            // 
            this.pnlDoktor.Controls.Add(this.label1);
            this.pnlDoktor.Controls.Add(this.cmbDoktorlar);
            this.pnlDoktor.Location = new System.Drawing.Point(356, 93);
            this.pnlDoktor.Name = "pnlDoktor";
            this.pnlDoktor.Size = new System.Drawing.Size(207, 53);
            this.pnlDoktor.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Doktorlar:";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(86, 11);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktorlar.TabIndex = 4;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // lstRandevu
            // 
            this.lstRandevu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lstRandevu.ContextMenuStrip = this.menu;
            this.lstRandevu.FullRowSelect = true;
            this.lstRandevu.HideSelection = false;
            this.lstRandevu.Location = new System.Drawing.Point(17, 301);
            this.lstRandevu.Name = "lstRandevu";
            this.lstRandevu.Size = new System.Drawing.Size(296, 184);
            this.lstRandevu.TabIndex = 57;
            this.lstRandevu.UseCompatibleStateImageBehavior = false;
            this.lstRandevu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Servis";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doktor";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 85;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(71, 34);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(242, 20);
            this.txtArama.TabIndex = 58;
            this.txtArama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Arama:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sil});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(153, 48);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Sil
            // 
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(152, 22);
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // YeniRandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lstRandevu);
            this.Controls.Add(this.pnlSaatler);
            this.Controls.Add(this.pnlDoktor);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbServisler);
            this.Name = "YeniRandevuEkrani";
            this.Size = new System.Drawing.Size(669, 508);
            this.Load += new System.EventHandler(this.YeniRandevuEkrani_Load);
            this.pnlDoktor.ResumeLayout(false);
            this.pnlDoktor.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstHasta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbServisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSaatler;
        private System.Windows.Forms.Panel pnlDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ListView lstRandevu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Sil;
    }
}
