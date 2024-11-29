namespace BuBilet_V_0._0._1.Sayfalar
{
    partial class UCotobusler
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projeDenemesiDataSet = new BuBilet_V_0._0._1.ProjeDenemesiDataSet();
            this.kullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanicilarTableAdapter = new BuBilet_V_0._0._1.ProjeDenemesiDataSetTableAdapters.kullanicilarTableAdapter();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDenemesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(590, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "OTOBÜS BİLETLERİ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(270, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1100, 1016);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.kullanicilarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(255, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // projeDenemesiDataSet
            // 
            this.projeDenemesiDataSet.DataSetName = "ProjeDenemesiDataSet";
            this.projeDenemesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicilarBindingSource
            // 
            this.kullanicilarBindingSource.DataMember = "kullanicilar";
            this.kullanicilarBindingSource.DataSource = this.projeDenemesiDataSet;
            // 
            // kullanicilarTableAdapter
            // 
            this.kullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // UCotobusler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCotobusler";
            this.Size = new System.Drawing.Size(1843, 1022);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeDenemesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kullanicilarBindingSource;
        private ProjeDenemesiDataSet projeDenemesiDataSet;
        private ProjeDenemesiDataSetTableAdapters.kullanicilarTableAdapter kullanicilarTableAdapter;
    }
}
