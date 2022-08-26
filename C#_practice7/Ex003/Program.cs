// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//Ход программы
int[,] array = ArrayFill();
ArrayPrint(array);
double[] res = AverageOfEachColumn(array);
ResultPrint(res);

//Функции
int[,] ArrayFill()      //Ввод массива чисел
{
    System.Console.WriteLine("Двумерный массив чисел: ");
    int[,] array = new int[6, 7];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}
void ArrayPrint(int[,] array)        //Вывод массива в консоль
{
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
double[] AverageOfEachColumn(int[,] array)       //Подсчет среднего арифметического в каждом столбце
{
    double[] result = new double[7];
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum/= result.Length;
        result[i] = Math.Round(sum, 2);
        sum = 0;
    }

    return result;
}
void ResultPrint(double[] array)     //Вывод результата в консоль
{
    System.Console.WriteLine("____________________________________________________________");
    System.Console.WriteLine("Среднее арифметическое для каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}


