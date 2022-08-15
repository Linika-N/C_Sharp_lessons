//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message){     //Ввод пятизначного числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int SumNumbers(int number){
    int sum = 0;
    if(number <1) 
    number*=-1;
    while (number >1){
        sum+= number%10;
        number /=10;
    }
    return sum;
}

int number = Prompt("Введите число");
int answer = SumNumbers(number);
Console.WriteLine(answer);