// Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами).

//Ход программы
int[,] array = ArrayFill();
ArrayPrint(array);
int SumMax = RowsMaxSum(array);
int SumMin = ColumnsMinSum(array);
DiffMaxMin(SumMax, SumMin);


//Функции
int[,] ArrayFill()      //Ввод массива чисел
{
    System.Console.WriteLine("Двумерный массив чисел: ");
    int[,] array = new int[6, 7];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-25, 25);
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
int RowsMaxSum(int[,] array)      //Поиск максимальных чисел в каждой строке массива
{
    System.Console.WriteLine("Максимальные числа: ");
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max) max = array[i, j];
        }
        System.Console.Write(max + " ");
        sum += max;
    }
    System.Console.WriteLine();
    return sum;
}
int ColumnsMinSum(int[,] array)      //Поиск минимальных чисел в каждом столбце массива
{
    System.Console.WriteLine("Минимальные числа: ");
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int min = array[0, i];
        for (int j = 1; j < array.GetLength(0); j++)
        {
            if (array[j, i] < min) min = array[j, i];
        }
        System.Console.Write(min + " ");
        sum += min;
    }
    System.Console.WriteLine();
    return sum;
}
void DiffMaxMin(int max, int min)       //Разность сумм максимальных и минимальных чисел
{
    System.Console.WriteLine("Сумма максимальных чисел каждой строки: " + max);
    System.Console.WriteLine("Сумма минимальных чисел каждого столбца: " + min);
    System.Console.WriteLine("Разность сумм максимальных и минимальных чисел: " + (max - min));
}