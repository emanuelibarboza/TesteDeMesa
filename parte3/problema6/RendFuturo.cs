using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _TesteDeMesa{

  public class RendFuturo
    {
        public double valorpresente;
        public double taxa;

        public double mes;
        public int dia;
        public double DiaMes(){
         return 30/(mes*30+dia);
        }
        double valorfinal;
        public double calculo()
        {
            return valorfinal = valorpresente * Math.Pow((1+taxa),DiaMes());
        }
        public void apresentar (){
        double ObterResultado = calculo();
        Console.WriteLine("| Rendimento Futuro: "+ObterResultado.ToString("N2")+" | ");
        Console.WriteLine("-------------------------------");
        }
       } 
}
    