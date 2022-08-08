// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message){
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 100 || result > 999){
        throw new Exception("Число не трехзначное!!!");
    } else 
        return result;
}
int FineMiddleNumber( int result){
    int rmd = result/10 % 10;
    return rmd;
}

System.Console.WriteLine(FineMiddleNumber(Prompt("Введите число: ")));

