using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public static class Utilidades
    {
        public static string nome { get; set; }
        public static bool[] respostas = new bool[5];

        public static void ArmazenaResposta(int i, bool valor)
        {
            respostas[i] = valor;
        }

        public static string DevolveResposta()
        {
            int acertos = 0;
            for (int i = 0; i < 5; i++)
            {
                if (respostas[i].Equals(true))
                    acertos++;
            }

            return acertos.ToString();
        }
    }
}
