﻿// See https://aka.ms/new-console-template for more information
// logical operators - used to check if more than one condition is true/false

//&& (AND)
//|| (OR)
Console.WriteLine("What's the temperature outside: (C)");
double temp = Convert.ToDouble(Console.ReadLine());
if (temp >= 10 && temp <= 25)
{
    Console.WriteLine("It's warm outside!");
}
else if (temp <= -50 || temp >= 50)
{
    Console.WriteLine("DO NOT GO OUTSIDE!!");
}
Console.ReadKey();
