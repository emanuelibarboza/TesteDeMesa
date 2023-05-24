using System;
 int[] v = new int[7];
 int a = 7;
int b = a - 6;

while (b < a) 
{
   v[b] = b + a;
   b= b + 2;
}

for (int i = 0; i < 7; i++)
{
Console.WriteLine($"No vetor: {i} o resultado é {v[i]}");
}
Console.ReadLine();