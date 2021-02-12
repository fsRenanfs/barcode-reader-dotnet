namespace BarcodeDecodeApp
{
    partial class Main
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
            this.filedialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImportarArq = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportarArq
            // 
            this.btnImportarArq.Location = new System.Drawing.Point(12, 12);
            this.btnImportarArq.Name = "btnImportarArq";
            this.btnImportarArq.Size = new System.Drawing.Size(551, 23);
            this.btnImportarArq.TabIndex = 0;
            this.btnImportarArq.Text = "Importar arquivo";
            this.btnImportarArq.UseVisualStyleBackColor = true;
            this.btnImportarArq.Click += new System.EventHandler(this.btnImportarArq_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(551, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Location = new System.Drawing.Point(12, 318);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(90, 13);
            this.lblCodBarras.TabIndex = 2;
            this.lblCodBarras.Text = "Código de barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(108, 315);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(454, 20);
            this.txtCodigoBarras.TabIndex = 3;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(15, 298);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(13, 13);
            this.lblArquivo.TabIndex = 4;
            this.lblArquivo.Text = "  ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 343);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.lblCodBarras);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnImportarArq);
            this.Name = "Main";
            this.Text = "Leitor código de barras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedialog;
        private System.Windows.Forms.Button btnImportarArq;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblArquivo;
    }
}

