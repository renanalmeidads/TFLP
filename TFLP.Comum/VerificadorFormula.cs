using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFLP.Entidades;

namespace TFLP.Comum
{
    public class VerificadorFormula
    {

        public bool DPLL(Formula formula)
        {
            //Se a fórmula não tem cláusulas, retorna true
            if (!formula.Clausulas.Any())
                return true;

            //Se a fórmula contém uma cláusula vazia, retorna falso
            foreach(Clausula clausula in formula.Clausulas)
            {
                if (!clausula.Atomicas.Any())
                    return false;
            }

            foreach(Clausula cls in formula.Clausulas)
            {
                //Se a fórmula contém uma cláusula unitária
                if(cls.Atomicas.Count == 1)
                {
                    return DPLL(Simplifica(formula, cls.Atomicas.First()));
                }
            }

            //Escolher uma atômica da fórmula
            var atmEscolhida = formula.Clausulas.First().Atomicas.First();

            if (DPLL(Simplifica(formula, atmEscolhida)))
                return true;
            else
            {
                atmEscolhida.Negado = true;
                return DPLL(Simplifica(formula, atmEscolhida));
            }
        }

        public Formula Simplifica(Formula formula, Atomica atomica)
        {

            for(int i = 0; i < formula.Clausulas.Count(); i++)
            {
                for(int j = 0; j < formula.Clausulas[i].Atomicas.Count; j++)
                {
                    var atm = formula.Clausulas[i].Atomicas[j];
                    var cls = formula.Clausulas[i];

                    //Remove cláusulas da fórmula onde a atômica é positiva
                    if (atm.Nome.Equals(atomica.Nome) && !atm.Negado)
                    {
                        formula.Clausulas.Remove(cls);
                        break;
                    }

                    //Remove ¬atômica das cláusulas onde a mesma aparece
                    if (atm.Nome.Equals(atomica.Nome) && atm.Negado)
                    {
                        cls.Atomicas.Remove(atm);
                    }
                }
            }

            return formula;
        }

        public List<Atomica> ValoracaoVerdadeira(Formula formula)
        {
            List<Atomica> retorno = new List<Atomica>();
            var auxFormula = formula.DeepClone();

            if (DPLL(formula))
            {
                foreach(Clausula cls in auxFormula.Clausulas)
                {
                    foreach(Atomica atm in cls.Atomicas)
                    {
                        bool jaAdicionado = retorno.Where(x => x.Nome == atm.Nome).ToList().Any();

                        if (atm.Negado && !jaAdicionado)
                        {
                            atm.Valor = false;
                            retorno.Add(atm);
                        }
                        else if (!atm.Negado && !jaAdicionado)
                        {
                            atm.Valor = true;
                            retorno.Add(atm);
                        }
                            
                    }
                }
            }

            return retorno.OrderBy(x => x.Nome).ToList();
        }
    }
}
