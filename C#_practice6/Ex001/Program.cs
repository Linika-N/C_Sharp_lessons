// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


//Ход программы
string stringNumbers = Prompt("Введите числа через пробел");
int result = CountNumbers(stringNumbers);
System.Console.WriteLine($"{result} раз(а) пользователь ввел число больше 0");

string Prompt(string message)
{   //Ввод строки чисел через пробел
    System.Console.WriteLine(message);
    return Console.ReadLine();
}

int CountNumbers(string str)
{   // Счетчик положительных чисел
    int count = 0;
    string[] numStrs = str.Trim().Split(" ");
    for (int i = 0; i < numStrs.Length; i++)
    {
        bool isNum = int.TryParse(numStrs[i], out int nullNum);
        if (isNum)
        {
            int number = int.Parse(numStrs[i]);
            if (number > 0) count++;
        }
    }
    return count;
}