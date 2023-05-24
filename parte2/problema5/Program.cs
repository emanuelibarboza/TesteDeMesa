using System;  
double VP;  
double VF = 7390.61;  
double periodo = 2;  
double taxa;  

Console.WriteLine("----------------------------------"); 
 
Console.WriteLine("Qual a taxa? ");  
taxa = Convert.ToDouble(Console.ReadLine());  

taxa /= 100;  
double calculo(){  
return VP = VF / Math.Pow((1+taxa), periodo);  
}  
  
Console.WriteLine("----------------------------------");  
Console.WriteLine($"Valor presente: "+calculo().ToString("N2"));  
Console.WriteLine("taxa: "+taxa*100+"%");  
Console.WriteLine("periodo: "+periodo+" Anos");  
Console.WriteLine("Valor Final: "+VF.ToString("N2"));