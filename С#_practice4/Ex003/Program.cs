//Напишите программу, которая задаёт массив из 8 элементов, 
//выводит их на экран. И ищет второй максимум (элемент меньше 
//максимального, но больше всех остальных)

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int[] arr1 = new int [8]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(1,50);
    }
    return arr1;
}

int[] ArraySort(int[] array){
    for (int i=0; i <array.Length-1; i++ ){
        if (array[i]>array[i+1]){
            array[i]=array[i] + array[i+1];
            array[i+1]=array[i] - array[i+1];
            array[i]=array[i] - array[i+1];
            i=0;
        }
    }
    return array;
}

void ArrayPrint(int[] array){
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    } 
    System.Console.WriteLine();
}

//Этапы выполнения задачи
int[] arr = ArrayFill();
ArrayPrint(arr);
arr = ArraySort(arr);
System.Console.WriteLine($"Второе максимальное число: {arr[arr.Length-2]}");