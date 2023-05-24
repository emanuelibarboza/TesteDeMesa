using System;
namespace _TesteDeMesa{
public class Program {

public static void Main(string[] args){
RendFuturo Rend = new RendFuturo();
Console.WriteLine("Insira o valor presente: ");
Rend.valorpresente = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a taxa juros: ");
Rend.taxa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quantos meses? ");
Rend.mes = Convert.ToDouble(Console.ReadLine());

Rend.calculo();
}
}
}