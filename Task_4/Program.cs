using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("vvedite chislo: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);