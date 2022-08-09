// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int DeleteMiddle(){
    int number = new Random().Next(100,1000);
    System.Console.WriteLine(number);
    int rmd = number % 10;
    return number/100 *10 + rmd;
    
}
System.Console.WriteLine(DeleteMiddle());
