//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(3,13);
    int[] arr1 = new int [length]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(100,1000);
    }
    return arr1;
}


int NumberOfEven(int[] array){      //Подсчет количества четных чисел
    int count=0;
    for (int i= 0; i <array.Length; i++){
        if(array[i]%2==0)
            count++;
    }
    return count;
}
void ArrayPrint(int[] array){       //Вывод массива в консоль
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    } 
    System.Console.WriteLine();
}


//Ход работы программы
Console.Clear();
int[] arr = ArrayFill();
ArrayPrint(arr);
int result = NumberOfEven(arr);
System.Console.WriteLine("Количество четных чисел в массиве: " + result);
