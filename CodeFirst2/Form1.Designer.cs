namespace CodeFirst2
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
            this.tANIMLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eĞİTMENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öĞRENCİEĞİTMENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tANIMLARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tANIMLARToolStripMenuItem
            // 
            this.tANIMLARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİToolStripMenuItem,
            this.eĞİTMENToolStripMenuItem,
            this.öĞRENCİEĞİTMENToolStripMenuItem});
            this.tANIMLARToolStripMenuItem.Name = "tANIMLARToolStripMenuItem";
            this.tANIMLARToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tANIMLARToolStripMenuItem.Text = "İÇERİK";
            // 
            // öĞRENCİToolStripMenuItem
            // 
            this.öĞRENCİToolStripMenuItem.Name = "öĞRENCİToolStripMenuItem";
            this.öĞRENCİToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.öĞRENCİToolStripMenuItem.Text = "ÖĞRENCİ";
            this.öĞRENCİToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİToolStripMenuItem_Click);
            // 
            // eĞİTMENToolStripMenuItem
            // 
            this.eĞİTMENToolStripMenuItem.Name = "eĞİTMENToolStripMenuItem";
            this.eĞİTMENToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eĞİTMENToolStripMenuItem.Text = "EĞİTMEN";
            this.eĞİTMENToolStripMenuItem.Click += new System.EventHandler(this.eĞİTMENToolStripMenuItem_Click);
            // 
            // öĞRENCİEĞİTMENToolStripMenuItem
            // 
            this.öĞRENCİEĞİTMENToolStripMenuItem.Name = "öĞRENCİEĞİTMENToolStripMenuItem";
            this.öĞRENCİEĞİTMENToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.öĞRENCİEĞİTMENToolStripMenuItem.Text = "ÖĞRENCİ-EĞİTMEN";
            this.öĞRENCİEĞİTMENToolStripMenuItem.Click += new System.EventHandler(this.öĞRENCİEĞİTMENToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tANIMLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eĞİTMENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİEĞİTMENToolStripMenuItem;
    }
}

