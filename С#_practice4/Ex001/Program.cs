//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int[] Prompt(string message){     //Ввод чисел
    System.Console.WriteLine(message);
    int[] result = new int [2]; 
    string value = Console.ReadLine();
    result[0] = int.Parse(value);
    value = Console.ReadLine();
    result[1] = int.Parse(value);
    if (result[1]<1)
        throw new Exception ("Степень должна быть натуральным числом, т.е. больше 0!");
    else 
        return result;
}

int NumbersPower(int number, int power){
    int res = number;
    for (int i=1; i<power;i++){
        res *= number;
    }
    return res;
}

int[] parameters = Prompt("Введите число и степень: ");
int answer = NumbersPower(parameters[0], parameters[1]);
Console.WriteLine(answer);