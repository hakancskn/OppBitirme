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
            this.kişiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşirelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiEkleToolStripMenuItem,
            this.randevuOluşturToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.hemşirelerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastalarToolStripMenuItem,
            this.randevularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiEkleToolStripMenuItem
            // 
            this.kişiEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kişiEkleToolStripMenuItem.Name = "kişiEkleToolStripMenuItem";
            this.kişiEkleToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.kişiEkleToolStripMenuItem.Text = "Yeni Kişi";
            // 
            // randevuOluşturToolStripMenuItem
            // 
            this.randevuOluşturToolStripMenuItem.Name = "randevuOluşturToolStripMenuItem";
            this.randevuOluşturToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.randevuOluşturToolStripMenuItem.Text = "Yeni Randevu";
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.doktorlarToolStripMenuItem.Text = "Doktorlar";
            this.doktorlarToolStripMenuItem.Click += new System.EventHandler(this.doktorlarToolStripMenuItem_Click);
            // 
            // hemşirelerToolStripMenuItem
            // 
            this.hemşirelerToolStripMenuItem.Name = "hemşirelerToolStripMenuItem";
            this.hemşirelerToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.hemşirelerToolStripMenuItem.Text = "Hemşireler";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.randevularToolStripMenuItem.Text = "Randevular";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 314);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 339);
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
        private System.Windows.Forms.ToolStripMenuItem kişiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşirelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}