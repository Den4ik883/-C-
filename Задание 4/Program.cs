 
 // Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите первое число ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите последнее число");
int b = int.Parse(Console.ReadLine()!);
int max = x;
if(x > y){
    Console.WriteLine("Максимальное число" + x);
}
if(y > b){
    Console.WriteLine("Максимальное число" + y);
}
else{
    Console.WriteLine("Максимальное число" + b);
}