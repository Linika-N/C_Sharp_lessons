using System;

//Найти максимальное из трёх чисел

short a,b,c, max=0;
System.Console.WriteLine("Введите первое число: ");
a=Convert.ToInt16(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
b=Convert.ToInt16(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
c=Convert.ToInt16(System.Console.ReadLine());

if (a>b) max=a;
if (b>c) max=b;
if (c>a) max=c;
System.Console.WriteLine("Максимальное число: "+ max);