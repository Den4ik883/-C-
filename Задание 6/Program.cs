// Напишите программу, которая га вход принимает число и выдает, является ли число четным.

Console.Write("Введите число");
int number = int.Parse(Console.ReadLine()!);

if(number %2 == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}