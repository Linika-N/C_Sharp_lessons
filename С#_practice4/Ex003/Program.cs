//Напишите программу, которая задаёт массив из 8 элементов, 
//выводит их на экран. И ищет второй максимум (элемент меньше 
//максимального, но больше всех остальных)

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int[] arr1 = new int [8]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(7,9);
    }
    return arr1;
}


int FindSecondMax(int[] array){
    int max1=array[0];
    int max2= array[1];
    for (int i=0; i< array.Length; i++){
        if(array[i]>=max1){
            max2 = max1;
            max1 = array[i];
        }
        if (array[i]>max2 && array[i]<max1){
            max2=array[i];
        }
    }
    return max2;
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
int secondMax=FindSecondMax(arr);
System.Console.WriteLine($"Второе максимальное число: {secondMax}");