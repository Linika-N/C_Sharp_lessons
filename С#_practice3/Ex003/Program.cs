//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int Prompt(string message){     //Ввод пятизначного числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

void CubeNumbers(int n){
    int result = 1;
    for (int count = 1; count <= n; count++){
        result = Convert.ToInt32(Math.Pow(count,3));
        System.Console.Write(result + " ");
    }
}


int n = Prompt("Введите число: ");
CubeNumbers(n);