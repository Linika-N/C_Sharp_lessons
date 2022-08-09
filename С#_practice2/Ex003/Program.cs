//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message){
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
string FindThirdNumber(int number){
    int rmd=number;
    if (number < 100)
        return "Третьей цифры нет!";
    else {
        while (number >1000){
            number = number *10 /100;
        }
        rmd = number % 10;
        return rmd.ToString();
    }
}

System.Console.WriteLine(FindThirdNumber(Prompt("Введите число: ")));