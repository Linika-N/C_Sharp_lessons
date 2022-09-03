// Задача 4. Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Ход программы
int row = Prompt("Введите количество строк массива: ");
int column = Prompt("Введите количество столбцов массива: ");
int[,] array = ArrayFill(row, column);
ArrayPrint(array, "Массив чисел: ");



int Prompt(string message)      //Ввод числа строк и столбцов
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 2 && result > 9)
        throw new Exception("Это очень сложно :) Может попроще число попробуем?)");
    else
        return result;
}
int[,] ArrayFill(int rows, int columns)      //Ввод массива чисел
{
    int[,] array = new int[rows, columns];
    int count = 1;
    int a = 0;
    int j = 0;
    int elements = rows * columns;
    while (count <= elements)
    {
        while (j < columns && count <= elements)
        {
            array[a, j] = count++;
            j++;
        }
        a++;
        j--;
        while (a < rows && count <= elements)
        {
            array[a, j] = count++;
            a++;
        }
        j--;
        a--;
        while (j >= array.GetLength(1)-columns && count <= elements)
        {
            array[a, j] = count++;
            j--;
        }
        a--;
        j++;
        while (a > array.GetLength(0)-rows && count <= elements)
        {
            array[a, j] = count++;
            a--;
        }
        j++;
        a++;
        rows--;
        columns--;
    }
    return array;
}
void ArrayPrint(int[,] array, string description)        //Вывод массива в консоль
{
    System.Console.WriteLine(description);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
