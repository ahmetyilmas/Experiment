namespace BuBilet_V_0._0._1.Sayfalar
{
    partial class UCucakBiletleri
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
            this.PnlUcakBiletleriAna = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlUcakBiletleriAna.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUcakBiletleriAna
            // 
            this.PnlUcakBiletleriAna.Controls.Add(this.label1);
            this.PnlUcakBiletleriAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlUcakBiletleriAna.Location = new System.Drawing.Point(0, 0);
            this.PnlUcakBiletleriAna.Name = "PnlUcakBiletleriAna";
            this.PnlUcakBiletleriAna.Size = new System.Drawing.Size(1843, 1022);
            this.PnlUcakBiletleriAna.TabIndex = 0;
            this.PnlUcakBiletleriAna.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlUcakBiletleriAna_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(615, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UÇAK BİLETLERİ";
            // 
            // UCucakBiletleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.PnlUcakBiletleriAna);
            this.Name = "UCucakBiletleri";
            this.Size = new System.Drawing.Size(1843, 1022);
            this.PnlUcakBiletleriAna.ResumeLayout(false);
            this.PnlUcakBiletleriAna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlUcakBiletleriAna;
        private System.Windows.Forms.Label label1;
    }
}
