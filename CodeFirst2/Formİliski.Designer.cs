namespace CodeFirst2
{
    partial class Formİliski
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
            this.cmbBxEgitmenler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewİliski = new System.Windows.Forms.DataGridView();
            this.lstBxOgrenciler = new System.Windows.Forms.ListBox();
            this.btnIlıskilendir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİliski)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBxEgitmenler
            // 
            this.cmbBxEgitmenler.FormattingEnabled = true;
            this.cmbBxEgitmenler.Location = new System.Drawing.Point(185, 37);
            this.cmbBxEgitmenler.Name = "cmbBxEgitmenler";
            this.cmbBxEgitmenler.Size = new System.Drawing.Size(121, 21);
            this.cmbBxEgitmenler.TabIndex = 0;
            this.cmbBxEgitmenler.SelectedIndexChanged += new System.EventHandler(this.cmbBxEgitmenler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eğitmenler";
            // 
            // dataGridViewİliski
            // 
            this.dataGridViewİliski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewİliski.Location = new System.Drawing.Point(44, 129);
            this.dataGridViewİliski.Name = "dataGridViewİliski";
            this.dataGridViewİliski.Size = new System.Drawing.Size(240, 272);
            this.dataGridViewİliski.TabIndex = 2;
            // 
            // lstBxOgrenciler
            // 
            this.lstBxOgrenciler.FormattingEnabled = true;
            this.lstBxOgrenciler.Location = new System.Drawing.Point(406, 129);
            this.lstBxOgrenciler.Name = "lstBxOgrenciler";
            this.lstBxOgrenciler.Size = new System.Drawing.Size(355, 238);
            this.lstBxOgrenciler.TabIndex = 3;
            // 
            // btnIlıskilendir
            // 
            this.btnIlıskilendir.Location = new System.Drawing.Point(533, 377);
            this.btnIlıskilendir.Name = "btnIlıskilendir";
            this.btnIlıskilendir.Size = new System.Drawing.Size(149, 23);
            this.btnIlıskilendir.TabIndex = 4;
            this.btnIlıskilendir.Text = "İlişkilendir";
            this.btnIlıskilendir.UseVisualStyleBackColor = true;
            this.btnIlıskilendir.Click += new System.EventHandler(this.btnIlıskilendir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Öğrenciler";
            // 
            // Formİliski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIlıskilendir);
            this.Controls.Add(this.lstBxOgrenciler);
            this.Controls.Add(this.dataGridViewİliski);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxEgitmenler);
            this.Name = "Formİliski";
            this.Text = "Formİliski";
            this.Load += new System.EventHandler(this.Formİliski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewİliski)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxEgitmenler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewİliski;
        private System.Windows.Forms.ListBox lstBxOgrenciler;
        private System.Windows.Forms.Button btnIlıskilendir;
        private System.Windows.Forms.Label label2;
    }
}