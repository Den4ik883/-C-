//Задание 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.


Console.Write("Введите первое число ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
if (number > number2){
    Console.WriteLine(number + "больше чем" + number2);
}
else{
    Console.WriteLine(number2 + "больше чем" + number);
}