using System;
namespace _TesteDeMesa{
class Program {

static void Main(string[] args){
RendFuturo Rend = new RendFuturo();
Console.WriteLine("Insira o valor presente: ");
Rend.valorpresente = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a taxa juros: ");
Rend.taxa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quantos meses? ");
Rend.mes = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quantos dias? ");
Rend.dia = Convert.ToInt32(Console.ReadLine());
Rend.DiaMes();
Rend.apresentar();
}
}
}