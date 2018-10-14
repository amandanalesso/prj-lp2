namespace LP2_inventario_instrumentos
{
    partial class consultar_instrumentos
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
            this.dataGridView_Instrumentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Instrumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Instrumentos
            // 
            this.dataGridView_Instrumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Instrumentos.Location = new System.Drawing.Point(44, 42);
            this.dataGridView_Instrumentos.Name = "dataGridView_Instrumentos";
            this.dataGridView_Instrumentos.Size = new System.Drawing.Size(548, 437);
            this.dataGridView_Instrumentos.TabIndex = 0;
            // 
            // consultar_instrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 515);
            this.Controls.Add(this.dataGridView_Instrumentos);
            this.Name = "consultar_instrumentos";
            this.Text = "consultar_instrumentos";
            this.Load += new System.EventHandler(this.consultar_instrumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Instrumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Instrumentos;
    }
}