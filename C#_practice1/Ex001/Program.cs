System.Console.WriteLine("Введите первое число:");
short a=Convert.ToInt16(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
short b=Convert.ToInt16(System.Console.ReadLine());

if (a>b) 
System.Console.WriteLine("Максимальное число: " + a + "\nМинимальное: "+ b);
else 
System.Console.WriteLine("Максимальное число: " + b + "\nМинимальное: "+ a);
