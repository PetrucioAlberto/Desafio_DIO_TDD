using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalent.Services
{



    public class CalculadoraDesen
    {
        private string data;
        private List<string> listaHistorico;


        public CalculadoraDesen(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }



        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;

            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);



            return res;
        }

        public int Subtrair(int n1, int n2)
        {


             int res = n1 - n2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
             int res = n1 * n2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int Dividir(int n1, int n2)
        {

            if (n2 == 0  )
            {
                throw new ArgumentException("Nao pode ser dividido por ZERO, meu caro amigo");
            }

             int res = n1 / n2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);

            return res;
        }

        public List<string> Historico()
        {

            if (listaHistorico.Count > 3)
            {
                listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            }

            return listaHistorico;
        }
        
    }
}