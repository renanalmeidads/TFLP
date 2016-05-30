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
        public List<string> ProcessarTextoArquivo(string texto)
        {

            List<string> linhas = ManipuladorArquivo.SepararLinhas(texto);

            List<Formula> lLstFormulas = new List<Formula>();
            
            foreach(Formula oFormula in SepararFormulasString(linhas))
            {
                Formula formula = new Formula(oFormula.sFormula);
                lLstFormulas.Add(formula);
            }

            VerificadorFormula vf = new VerificadorFormula();
            List<string> retorno = new List<string>();

            foreach(Formula formula in lLstFormulas)
            {
                string valoracao = ValoracoesParaString(vf.ValoracaoVerdadeira(formula));
                
                if(valoracao != "")
                    retorno.Add(formula.Comentario + " - " + valoracao);
            }

            return retorno;

        }

        private string ValoracoesParaString(List<Atomica> atomicas)
        {
            string retorno = String.Empty;

            foreach(Atomica atm in atomicas)
            {
                retorno = retorno + " v(" + atm.Nome + ")" + " = " + atm.Valor + ", ";
            }

            if(retorno.Length > 2)
                retorno = retorno.Remove(retorno.Length - 2);

            return retorno;
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
            if (!string.IsNullOrEmpty(pLinha) && pLinha[0].Equals(pInicial))
                return true;

            return false;
        }
    }
}
