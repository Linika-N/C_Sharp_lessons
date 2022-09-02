// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Ход программы
int[,] arr = ArrayFill();
ArrayPrint(arr, "Двумерный массив чисел: ");
int[] result = ElSumInRow(arr);
MinSumRow(result);


//Функции
int[,] ArrayFill()      //Ввод массива чисел
{
    int[,] array = new int[5, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-25, 25);
        }
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
            if (array[i, j] >= 0)
            {
                if (array[i, j] % 100 > 9)
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
                else
                {
                    System.Console.Write("  " + array[i, j] + " ");
                }
            }
            else
            {
                if (array[i, j] % 100 <= -10)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                else
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
            }
        }
        System.Console.WriteLine();
    }
}
int[] ElSumInRow(int[,] array)      //Подсчет суммы элементов по строкам
{
    int[,] arr = array;
    int[] sum = new int[arr.GetLength(0)];
    System.Console.WriteLine("Сумма элементов по строкам: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
        System.Console.WriteLine(i + " = " + sum[i]);
    }
    return sum;
}
void MinSumRow(int[] array)     // Поиск строки с минимальной суммой элементов
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    System.Console.WriteLine("Строка с наименьшей суммой элементов : " + minIndex);
}