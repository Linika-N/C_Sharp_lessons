//Найти все четные числа от 1 до N

System.Console.WriteLine("Введите число: ");
byte n=Convert.ToByte(Console.ReadLine());
int count=1;
string result="";
while (count<=n){
    if (count%2==0){
        result+=count.ToString()+ " ";
    }
    count++;
}
System.Console.WriteLine(result);
