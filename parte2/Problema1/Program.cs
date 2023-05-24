using System;
namespace _TesteDeMesa
{
    class Program
    {
       public static void Main(){
        int p = 1000;
        double i = 0.053;
        int n = 70;
        Console.WriteLine("Seu investimento de 1000 em 2 anos e 6 meses com 5.3% de juros é: ");
        double f = p * Math.Pow((1+i),n);
        Console.WriteLine($"R${f.ToString("N2")}");
       } 
    }  
}