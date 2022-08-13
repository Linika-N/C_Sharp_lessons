// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] Prompt(string message){     //Ввод координат точек 
    System.Console.WriteLine(message);
    int[] arr1 = new int [3];
    string value = "";
    for (int i= 0; i <arr1.Length; i++){
        value = Console.ReadLine();
        arr1[i] = int.Parse(value);
    }
    return arr1;
}

double DistanceBtwPoints(int[] arr1, int[] arr2){       //Расстояние между точками
    double result = 0;
    int diff = 0;
    for (int i=0; i< arr1.Length; i++){
        diff = arr2[i]-arr1[i];
        result += diff*diff;
    }
    result = Math.Round(Math.Sqrt(result),2);
    return result;
}


int [] point1 = Prompt("Введите координаты первой точки: ");
int [] point2 = Prompt("Введите координаты второй точки: ");
double dist = DistanceBtwPoints(point1, point2);

System.Console.WriteLine(dist);
