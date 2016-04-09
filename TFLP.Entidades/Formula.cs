using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLP.Entidades
{
    public class Formula
    {
        #region Propriedades
        public List<string> sFormula { get; set; }
        public string Comentario { get; set; }
        public string Tipo { get; set; }
        public List<Clausula> Clausulas { get; set; }
        #endregion

        #region Construtores
        public Formula()
        {
            this.sFormula = new List<string>();
            this.Clausulas = new List<Clausula>();
        }

        public Formula(List<String> sFormula)
        {
            this.sFormula = sFormula;
            Comentario = PegarComentarioNaLinha(sFormula.First());
            Tipo = PegarTipoNaLinha(sFormula[1]);
            Clausulas = PegarClausulas(sFormula);
        }
        #endregion

        #region Métodos
        private List<Clausula> PegarClausulas(List<string> sFormula)
        {
            int countInicio = 2;

            List<Clausula> lLstClausulas = new List<Clausula>();

            while(countInicio <= sFormula.Count - 1)
            {
                Clausula oClausula = new Clausula();
                List<string> sAtomicas = sFormula[countInicio].Split(' ').ToList();


                foreach(string atomica in sAtomicas)
                {
                    int indexAtomica = Int32.Parse(atomica);

                    if (indexAtomica != 0)
                    {
                        Atomica oAtomica = new Atomica();

                        if (indexAtomica > 0)
                            oAtomica.Valor = true;
                        else
                            oAtomica.Valor = false;

                        oAtomica.Nome = "p" + Math.Abs(indexAtomica);

                        oClausula.Atomicas.Add(oAtomica);
                    }
                }

                lLstClausulas.Add(oClausula);

                countInicio++;
            }

            return lLstClausulas;
        }

        private string PegarTipoNaLinha(string pLinha)
        {
            List<string> parametros = pLinha.Split(' ').ToList();
            return parametros[1];
        }

        private string PegarComentarioNaLinha(string pLinha)
        {
            string comentario = String.Empty;

            if (ValidarLinha(pLinha, 'c'))
            {
                int sIndex = pLinha.IndexOf(' ');

                comentario = pLinha.Substring(sIndex, pLinha.Length - sIndex);

                comentario = comentario.Trim();
            }

            return comentario;
        }

        private bool ValidarLinha(string pLinha, char pInicial)
        {
            if (pLinha[0].Equals(pInicial))
                return true;

            return false;
        }
        #endregion
    }
}
