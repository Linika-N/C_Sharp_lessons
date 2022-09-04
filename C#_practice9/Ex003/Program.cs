// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

//Ход программы
int a=-1, b=-1;
do
{
    a = Prompt("Введите первое неотрицательное число: ");
    b = Prompt("Введите второе неотрицательное число: ");
}
while (a <0 || b<0);
int result = AckermannFunction(a, b);
System.Console.WriteLine($"A({a},{b})= {result}");


//Функции
int Prompt(string message)      //Ввод числа строк и столбцов
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
int AckermannFunction(int m, int n)     //Функция Аккермана
{
    if (m==0) return n+=1;
    else if (n==0) return AckermannFunction(m-1,1);
    else return AckermannFunction(m-1,AckermannFunction(m,n-1));
}