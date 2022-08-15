// Сортировка массива вставками
// {5,3,45,12,7,25,63,2}
// {2,3,5,7,12,25,45,63}


int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Неотсортированный массив чисел");
    int[] arr1 = new int [11]; 
    for (int i= 0; i <arr1.Length; i++){
        arr1[i] = new Random().Next(1,100);
        System.Console.Write(arr1[i] + " ");
    }
    System.Console.WriteLine();
    return arr1;
}


int[] ArraySort(int[] array){
    int temp = 0;
    int count=0;
    int j;
    for (count=0; count < array.Length-1; count++){
        if (array[count+1] < array[count]){
            temp = array[count+1];
            for (j=count+1; j>0; j--){
                if (array[j-1]<= temp){
                    j=0;
                    array[j]=temp;
                }
                else {
                    array[j]=array[j-1];
                    array[j]=temp;                    
                }
            }
        }
    }
    return array;
}

void ArrayPrint(int[] array){
    System.Console.WriteLine("Отсортированный массив чисел: ");
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    }
}

int[] arrayBegin = ArrayFill();
int[] arrayEnd = ArraySort(arrayBegin);
ArrayPrint(arrayEnd);