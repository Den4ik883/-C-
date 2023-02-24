// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + number;
//         number--;
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите число:  ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите число:  ");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр =  {GetSumNums(num)}");
// Console.WriteLine($"Сумма цифр =  {GetSumNums(num1)}");
// Console.WriteLine($"Сумма цифр =  {GetSumNums(num2)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int NumberOfDigits (int number)
// {
//     int numberN = number;
//     int count = 0;
//     while(numberN > 0)
//     {
//         numberN = numberN / 10;
//         count++;
//     }
//     return count;
// }
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество цифр в числу:   {NumberOfDigits(num)}");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

//  int GetSumNums(int number)
// {
//      int sum = 1;
//      while(number > 0)
//      {
//          sum = sum * number;
//          number--; //5 //4 //3 //2
//      }
//      return sum;
// }

// Console.Clear();
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение чисел = {GetSumNums(num)}");

// int GetSumNums(int number)
// {
//      int sum = 1;
//      while(number > 0)
//      {
//          sum = sum * number;
//          number--; //5 //4 //3 //2
//      }
//      return sum;
// }

// Console.Clear();
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Произведение чисел = {GetSumNums(num)}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int [8];
// int SilArray(int[] array)
// {
//     int count = array.Length;

//     for(int i = 0; i < count; i++)
//     {
//        int i[arr] = new Random.Next(0,1);
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// SilArray(arr);

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for ( int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for ( int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for ( int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально валидное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально валидное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);