using OppBitirme.Models;

namespace OppBitirme
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarListesiTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşirelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşirelerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuOluşturToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.hemşirelerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuOluşturToolStripMenuItem
            // 
            this.randevuOluşturToolStripMenuItem.Name = "randevuOluşturToolStripMenuItem";
            this.randevuOluşturToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.randevuOluşturToolStripMenuItem.Text = "Randevular";
            this.randevuOluşturToolStripMenuItem.Click += new System.EventHandler(this.randevuOluşturToolStripMenuItem_Click);
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleTSM,
            this.doktorlarListesiTSM});
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.doktorlarToolStripMenuItem.Text = "Doktorlar";
            // 
            // doktorEkleTSM
            // 
            this.doktorEkleTSM.Name = "doktorEkleTSM";
            this.doktorEkleTSM.Size = new System.Drawing.Size(158, 22);
            this.doktorEkleTSM.Tag = OppBitirme.Models.Kisi.Unvan.Doktor;
            this.doktorEkleTSM.Text = "Doktor Ekle";
            this.doktorEkleTSM.Click += new System.EventHandler(this.KisiEkleToolStripMenuItem_Click);
            // 
            // doktorlarListesiTSM
            // 
            this.doktorlarListesiTSM.Name = "doktorlarListesiTSM";
            this.doktorlarListesiTSM.Size = new System.Drawing.Size(158, 22);
            this.doktorlarListesiTSM.Tag = OppBitirme.Models.Kisi.Unvan.Doktor;
            this.doktorlarListesiTSM.Text = "Doktorlar Listesi";
            this.doktorlarListesiTSM.Click += new System.EventHandler(this.KisiListesiToolStripMenuItem_Click);
            // 
            // hemşirelerToolStripMenuItem
            // 
            this.hemşirelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hemşireEkleToolStripMenuItem,
            this.hemşirelerListesiToolStripMenuItem});
            this.hemşirelerToolStripMenuItem.Name = "hemşirelerToolStripMenuItem";
            this.hemşirelerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.hemşirelerToolStripMenuItem.Text = "Hemşireler";
            // 
            // hemşireEkleToolStripMenuItem
            // 
            this.hemşireEkleToolStripMenuItem.Name = "hemşireEkleToolStripMenuItem";
            this.hemşireEkleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hemşireEkleToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Hemşire;
            this.hemşireEkleToolStripMenuItem.Text = "Hemşire Ekle";
            this.hemşireEkleToolStripMenuItem.Click += new System.EventHandler(this.KisiEkleToolStripMenuItem_Click);
            // 
            // hemşirelerListesiToolStripMenuItem
            // 
            this.hemşirelerListesiToolStripMenuItem.Name = "hemşirelerListesiToolStripMenuItem";
            this.hemşirelerListesiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hemşirelerListesiToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Hemşire;
            this.hemşirelerListesiToolStripMenuItem.Text = "Hemşireler Listesi";
            this.hemşirelerListesiToolStripMenuItem.Click += new System.EventHandler(this.KisiListesiToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelListesiToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personelEkleToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Personel;
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.KisiEkleToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personelListesiToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Personel;
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.KisiListesiToolStripMenuItem_Click);
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaListesiToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.hastaEkleToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Hasta;
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.KisiEkleToolStripMenuItem_Click);
            // 
            // hastaListesiToolStripMenuItem
            // 
            this.hastaListesiToolStripMenuItem.Name = "hastaListesiToolStripMenuItem";
            this.hastaListesiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.hastaListesiToolStripMenuItem.Tag = OppBitirme.Models.Kisi.Unvan.Hasta;
            this.hastaListesiToolStripMenuItem.Text = "Hasta Listesi";
            this.hastaListesiToolStripMenuItem.Click += new System.EventHandler(this.KisiListesiToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 314);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "........ Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşirelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleTSM;
        private System.Windows.Forms.ToolStripMenuItem doktorlarListesiTSM;
        private System.Windows.Forms.ToolStripMenuItem hemşireEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşirelerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaListesiToolStripMenuItem;
    }
}