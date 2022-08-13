//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

int Prompt(string message){     //Ввод пятизначного числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 10000 || result > 99999){
        throw new Exception("Число не пятизначное!!!");
    } else 
        return result;
}

string IsPalindrome(int num){      //Проверка числа на палиндром
    string res = "Нет";
    if (num / 10000 == num % 10){
        if (num / 1000 - (num/10000*10) == num /10 % 10){
            res = "Да";
        }
    }
    return res;
}

int number = Prompt("Введите пятизначное число: ");
string plnd = IsPalindrome(number);

System.Console.WriteLine(plnd);
