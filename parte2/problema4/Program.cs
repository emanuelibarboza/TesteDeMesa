using System;
namespace _TesteDeMesa
{
    class Program
    {
        public static void Main()
        {
            double p = 2000;
            double i = 0.02;
            double f = 0;
            double rendaAcumulada = p;
            double n = 0;
            double saque = 0;
            double saldo;
            double rendLiquido()
            {
                return f - p;
            }

            for (n = 0; n <= 6; n++)
            {    
                if (n == 6)
                {
                    Console.WriteLine("Quanto vc quer sacar? ");
                    saque = Convert.ToDouble(Console.ReadLine());
                    p = f - saque;
                    rendaAcumulada = (rendLiquido()+p) - saque;
                    f=-saque;
                    rendLiquido();
                    f = p * Math.Pow((1 + i), 1);
                    saldo=f;
                    Console.Write($"\n| Saque: {saque.ToString("N2")} R$ | \n");
                    Console.Write($"----------------------\n");
                }
                else
                {
                     f = p * Math.Pow((1 + i), n);
                    rendaAcumulada = p + rendLiquido();
                    saldo = f;
                }
                Console.Write($"Valor presente: {p.ToString("N2")} | ");
                Console.Write($"Taxa: {(i * 100).ToString()}% | ");
                Console.Write($"Mês: {n.ToString()} | ");
                Console.Write($"Rendimento: {f.ToString("N2")} R$ | ");
                Console.Write($"Rend. Liq: {(rendLiquido()).ToString("N2")} R$ | ");
                Console.Write($"Renda Acumulada: {(rendaAcumulada).ToString("N2")} R$ | ");
                Console.Write($"Saldo: {(saldo).ToString("N2")} R$ | \n");
                

            }
        }
    }
}