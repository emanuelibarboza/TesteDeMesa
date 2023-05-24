using System;
namespace _TesteDeMesa
{
    class Program
    {
        public static void Main(){
        int p = 3800;
        double i = 0.0125;
        double f = 0;
        double rendaAcumulada = p;
        int n = 1;
        
        double rendLiquido()
        {
          return f-p;
        }
        Console.Write($"\nValor Investido: {p.ToString("N2")} R$\n");
        Console.Write("-----------------------------------------------------------------------------\n");
        for (n = 1; n<= 6; n++){
        f = p * Math.Pow((1+i),n);
        Console.Write($"Mês: {n.ToString()} | ");
        Console.Write($"Taxa: {(i*100).ToString()}% | ");
        Console.Write($"Rendimento: {f.ToString("N2")} R$ | ");
        Console.Write($"Rendimento Liq.: {(rendLiquido()).ToString("N2")} R$ | ");   
        rendaAcumulada += f-p;
        Console.Write($"Renda Acumulada: {(rendaAcumulada).ToString("N2")} R$ | \n"); 
        }
    
        } 
    }  
}