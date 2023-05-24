using System;

double vp;
double i;
double p;
double rend;

Console.WriteLine("_______________________");
Console.WriteLine("Digite o valor presente: ");
vp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o periodo: ");
p = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Digite a taxa de juros: ");
i = Convert.ToDouble(Console.ReadLine());

rend = vp * Math.Pow((1+i/100), p);

Console.WriteLine("---------------------");
Console.WriteLine($"| Rendimento: {(rend).ToString("N2")} | ");
Console.WriteLine("---------------------");


