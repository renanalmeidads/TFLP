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
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.fdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbFormula
            // 
            this.tbFormula.Location = new System.Drawing.Point(12, 103);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(404, 20);
            this.tbFormula.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnVerificar.Location = new System.Drawing.Point(113, 160);
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
            this.btnUpload.Location = new System.Drawing.Point(215, 160);
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
            // TFLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 314);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.tbFormula);
            this.Name = "TFLP";
            this.Text = "TFLP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog fdArquivo;
    }
}

