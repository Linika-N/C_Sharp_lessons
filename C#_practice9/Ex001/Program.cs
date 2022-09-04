// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


//Ход программы
int m = 3, n = 2;
do
{
    m = Prompt("Введите первое число: ");
    n = Prompt("Введите второе число(должно быть больше первого): ");
}
while (m >= n);
System.Console.WriteLine($"Четные натуральные числа от {m} до {n}: ");
EvenNumbers(m, n);


//Функции
int Prompt(string message)      //Ввод числа строк и столбцов
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 1)
    {
        throw new Exception("Необходимо натуральное число!");
    }
    else return result;
}


void EvenNumbers(int a, int b)
{
    if (a > b) return;
    if (a % 2 != 0)
    {
        a++;
    }
    System.Console.Write(a + " ");
    EvenNumbers(a + 2, b);
}