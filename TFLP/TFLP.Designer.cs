namespace TFLP
{
    partial class TFLP
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.fdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.taValoracoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificar.Location = new System.Drawing.Point(111, 172);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(96, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar fórmula";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpload.Location = new System.Drawing.Point(213, 172);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Abrir arquivo...";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // fdArquivo
            // 
            this.fdArquivo.FileName = "fdArquivo";
            // 
            // taValoracoes
            // 
            this.taValoracoes.Location = new System.Drawing.Point(13, 13);
            this.taValoracoes.Multiline = true;
            this.taValoracoes.Name = "taValoracoes";
            this.taValoracoes.Size = new System.Drawing.Size(399, 153);
            this.taValoracoes.TabIndex = 3;
            // 
            // TFLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 207);
            this.Controls.Add(this.taValoracoes);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnVerificar);
            this.Name = "TFLP";
            this.Text = "TFLP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog fdArquivo;
        private System.Windows.Forms.TextBox taValoracoes;
    }
}

