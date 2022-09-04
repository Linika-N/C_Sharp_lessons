// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


//Ход программы
int m = 3, n = 2;
do
{
    m = Prompt("Введите первое число: ");
    n = Prompt("Введите второе число(должно быть больше первого): ");
}
while (m >= n);
int sum = SumOfIntegers(m, n);
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n}:  {sum}");


//Функции
int Prompt(string message)      //Ввод числа строк и столбцов
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
int SumOfIntegers(int a, int b, int sumInt = 0)     //Сумма натуральных чисел от m до n
{
    if (a > b) return sumInt;
    if (a <= 0)
    {
        a = 1;
    }
    sumInt += a;
    return SumOfIntegers(a + 1, b, sumInt);
}