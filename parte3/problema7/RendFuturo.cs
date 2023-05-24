using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _TesteDeMesa
{
    public class RendFuturo
    {
        public double valorpresente;
        public double taxa;
        public double rendaAcumulada;
        public double saque = 0;
        public double saldo;
        public double valorfinal;
        public double mes;
        public double rendLiquido()
        {
            return valorfinal - valorpresente;
        }
        public void calculo()
        {
            taxa /= 100;
            Console.WriteLine("V. presente | Taxa | Mes | Rendimento \t| Rend. Liq \t| Renda Ac. \t| Saldo | \t");

            for (mes = 0; mes <= 8; mes++)
            {

                if (mes == 6)
                {
                    Console.WriteLine("Quanto vc quer sacar? ");
                    saque = Convert.ToDouble(Console.ReadLine());
                    valorpresente = valorfinal - saque;
                    rendaAcumulada = (rendLiquido() + valorpresente) - saque;
                    valorfinal -= saque;
                    rendLiquido();
                    valorfinal = valorpresente * Math.Pow((1 + taxa), 1);
                    saldo = valorfinal;
                    Console.Write($"\n| Saque: {saque.ToString("N2")} R$ | \n");
                    Console.Write($"----------------------\n");
                    rendaAcumulada = valorpresente;
                }
                else
                {
                    valorfinal = valorpresente * Math.Pow((1 + taxa), mes);
                    rendaAcumulada = valorpresente + rendLiquido();
                    saldo = valorfinal;
                }

                Console.Write($"{valorpresente.ToString("N2")} R$ | \t");
                Console.Write($"{(taxa * 100).ToString()}% | \t");
                Console.Write($"{mes.ToString()} | \t");
                Console.Write($"{valorfinal.ToString("N2")} R$ | \t");
                Console.Write($"{(rendLiquido()).ToString("N2")} R$ | \t");
                Console.Write($"{(rendaAcumulada).ToString("N2")} R$ | \t");
                Console.Write($"{(saldo).ToString("N2")} R$ | \n");
            }
        }

    }
}

