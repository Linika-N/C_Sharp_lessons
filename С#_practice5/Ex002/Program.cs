// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(3,10);
    int[] arr1 = new int [length]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(-25,25);
    }
    return arr1;
}


int SumOfElementsOnOddPosition(int[] array){      //Подсчет суммы элементов, стоящих на нечетных позициях
    int sum=0;
    for (int i= 1; i <array.Length; i+=2){
        sum += array[i];
    }
    return sum;
}
void ArrayPrint(int[] array){       //Вывод массива в консоль
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    } 
    System.Console.WriteLine();
}


//Ход работы программы
int[] arr = ArrayFill();
ArrayPrint(arr);
int result = SumOfElementsOnOddPosition(arr);
System.Console.WriteLine("Сумма элементов с нечетными позициями: " + result);
