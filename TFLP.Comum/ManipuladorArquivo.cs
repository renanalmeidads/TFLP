using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLP.Comum
{
    public static class ManipuladorArquivo
    {

        public static List<string> SepararLinhas(string texto)
        {
            List<string> lLstRetorno = new List<string>();
            int count = 0;
            bool finalString = false;

            while (!finalString)
            {
                string linha = String.Empty;
                int enterIndex = texto.IndexOf('\n', count);

                if (enterIndex != -1)
                    enterIndex -= count;
                else
                {
                    enterIndex = texto.Length - count;
                    finalString = true;
                }

                linha = texto.Substring(count, enterIndex);

                lLstRetorno.Add(linha);

                count += ++enterIndex;
            }

            return lLstRetorno;
        }
    }
}
