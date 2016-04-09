using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFLP.Controllers;

namespace TFLP
{
    public partial class TFLP : Form
    {
        public TFLP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            this.AbrirFormUploadArquivo();
        }

        private void AbrirFormUploadArquivo()
        {
            FormulaController formulaController = new FormulaController();
            DialogResult result = fdArquivo.ShowDialog();
            if(result == DialogResult.OK)
            {
                string caminhoArquivo = fdArquivo.FileName;

                try
                {
                    string texto = File.ReadAllText(caminhoArquivo);
                    formulaController.ProcessarTextoArquivo(texto);
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
