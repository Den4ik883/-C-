// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



// Console.WriteLine("Введите число:  ");
// int num = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine("Введите Степень:  ");
// int num1 = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"{num}  В степени  {num1} =" + Math.Pow(num, num1) ); //Math.Pow - Возведение в степень



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         int minNum = number % 10;
//         sum = sum + minNum;
//         number = number / 10;
//     }
//     return sum;

    
// }
// Console.WriteLine("Введите число:  ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {num} = {GetSumNums(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{   
   int[] array = new int[size];  
   for(int i = 0; i < size; i++)
   {
    Console.WriteLine("Введите число массива: ",i);
    array[i] = Convert.ToInt32(Console.ReadLine()!);
   }
   return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.WriteLine("Введите длину массива:");
int num = int.Parse(Console.ReadLine()!);
int[] myArray = CreateArray(num);
ShowArray(myArray);

