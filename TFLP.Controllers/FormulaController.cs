using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFLP.Comum;
using TFLP.Entidades;

namespace TFLP.Controllers
{
    public class FormulaController
    {
        public void ProcessarTextoArquivo(string texto)
        {

            List<string> linhas = ManipuladorArquivo.SepararLinhas(texto);

            //List<string> linhasComentario = linhas.Where(e => e[0] == 'c').ToList();

            //string comentario = PegarComentarioNaLinha(linhasComentario.FirstOrDefault());
            List<Formula> lLstFormulas = new List<Formula>();
            
            foreach(Formula oFormula in SepararFormulasString(linhas))
            {
                Formula formula = new Formula(oFormula.sFormula);
                lLstFormulas.Add(formula);
            }

        }

        private List<Formula> SepararFormulasString(List<string> pLinhas)
        {
            List<Formula> lLstFormulas = new List<Formula>();
            int countC = 0;
            List<string> sFormula = new List<string>();
            Formula formula;

            foreach (string linha in pLinhas)
            {
                if (ValidarLinha(linha, 'c'))
                    ++countC;

                if (countC < 2)
                {
                    sFormula.Add(linha.Trim());
                }

                if (countC == 2)
                {
                    formula = new Formula();
                    formula.sFormula = sFormula;
                    lLstFormulas.Add(formula);
                    countC = 1;
                    sFormula = new List<string>();
                    sFormula.Add(linha);
                }
            }

            formula = new Formula();
            formula.sFormula = sFormula;
            lLstFormulas.Add(formula);

            foreach(Formula formulaAtual in lLstFormulas)
            {
                formulaAtual.sFormula.RemoveAll(e => e == "");
            }

            return lLstFormulas;
        }

        private bool ValidarLinha(string pLinha, char pInicial)
        {
            if (pLinha[0].Equals(pInicial))
                return true;

            return false;
        }
    }
}
