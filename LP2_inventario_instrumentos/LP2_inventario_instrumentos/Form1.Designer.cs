namespace LP2_inventario_instrumentos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_retirada = new System.Windows.Forms.Button();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.groupBox_inicio = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(55, 183);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(158, 22);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar novo instrumento";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(233, 183);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(158, 22);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar Instrumentos";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_retirada
            // 
            this.btn_retirada.Location = new System.Drawing.Point(55, 224);
            this.btn_retirada.Name = "btn_retirada";
            this.btn_retirada.Size = new System.Drawing.Size(158, 23);
            this.btn_retirada.TabIndex = 2;
            this.btn_retirada.Text = "Retirada de Instrumentos";
            this.btn_retirada.UseVisualStyleBackColor = true;
            this.btn_retirada.Click += new System.EventHandler(this.btn_retirada_Click);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.Location = new System.Drawing.Point(233, 224);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Size = new System.Drawing.Size(158, 23);
            this.btn_relatorios.TabIndex = 3;
            this.btn_relatorios.Text = "Relatórios";
            this.btn_relatorios.UseVisualStyleBackColor = true;
            this.btn_relatorios.Click += new System.EventHandler(this.btn_relatorios_Click);
            // 
            // groupBox_inicio
            // 
            this.groupBox_inicio.Controls.Add(this.pictureBox1);
            this.groupBox_inicio.Controls.Add(this.btn_relatorios);
            this.groupBox_inicio.Controls.Add(this.btn_cadastrar);
            this.groupBox_inicio.Controls.Add(this.btn_retirada);
            this.groupBox_inicio.Controls.Add(this.btn_consultar);
            this.groupBox_inicio.Location = new System.Drawing.Point(21, 25);
            this.groupBox_inicio.Name = "groupBox_inicio";
            this.groupBox_inicio.Size = new System.Drawing.Size(434, 297);
            this.groupBox_inicio.TabIndex = 4;
            this.groupBox_inicio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LP2_inventario_instrumentos.Properties.Resources.logopng;
            this.pictureBox1.Location = new System.Drawing.Point(114, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 346);
            this.Controls.Add(this.groupBox_inicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventário de Instrumentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_retirada;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.GroupBox groupBox_inicio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

