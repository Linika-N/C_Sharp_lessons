//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


byte Prompt(string message){        //Ввод числа
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    byte result = byte.Parse(value);
    if (result < 1 || result >7){
        throw new Exception($"В неделе семь дней, а не {result}!!!");
    } else 
        return result;
}
string IsAWeekDay(byte number){     //Проверка выходного дня
    return (number == 6 || number == 7)? "Да" : "Нет";
}
System.Console.WriteLine(IsAWeekDay(Prompt("Введите число, обозначающее день недели: ")));