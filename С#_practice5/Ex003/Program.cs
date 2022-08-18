// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76


float[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(5,10);
    float[] arr1 = new float[length]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(-27,27);
    }
    return arr1;
}

float MinSearch(float[] array){     //Поиск минимального числа в массиве
    float min=array[0];
    for (int i= 0; i <array.Length; i++){
        if(array[i] < min) min=array[i];
    }
    return min;
}


float MaxSearch(float[] array){     //Поиск минимального числа в массиве
    float max=array[0];
    for (int i= 0; i <array.Length; i++){
        if(array[i] > max) max=array[i];
    }
    return max;
}

float MinMaxDifference(float min, float max){      //Подсчет разницы между минимальным и максимальным элементами массива
    float diff=0;
    if (min < 0){
        diff = - min + max;
    }
    else if (max<0){
        diff = -(min - max);
    }
    else{
        diff = max - min;
    }
    return diff;
}
void ArrayPrint(float[] array){       //Вывод массива в консоль
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    } 
    System.Console.WriteLine();
}


//Ход работы программы
Console.Clear();
float[] arr = ArrayFill();
ArrayPrint(arr);
float min = MinSearch(arr);
float max = MaxSearch(arr);
System.Console.WriteLine($"Mаксимальный элемент: {max}\nМинимальный элемент: {min}");
float result = MinMaxDifference(min,max);
System.Console.WriteLine("Разница между минимальным и максимальным элементами массива: " + result);
