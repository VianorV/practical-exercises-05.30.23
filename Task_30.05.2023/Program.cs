// int number = ReadLine();
// int sum = Sum(number);
// Console.WriteLine(sum);

// int Sum(int a)
// {
//     int sum = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// int ReadLine()
// {
//     Console.WriteLine("Введите число");
//     string input = Console.ReadLine();
//     int number = Convert.ToInt32(input);
//     return number;
// }

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Task 26

// int ReadLine()
// {
//      Console.WriteLine("Введите число");
//      string input = Console.ReadLine();
//      int number = Convert.ToInt32(input);
//      return number;
// }
// int number = ReadLine();
// int q = 0;
// for (;q >= number; q++)
// {
//     int result = number % 10;

// }

// int ReadLine()
// {
//       Console.WriteLine("Введите число");
//       string input = Console.ReadLine();
//       int number = Convert.ToInt32(input);
//       return number;
// }

// int ReadLine()
// {

// }

int [] array = new int [8];

void RandomNumber(int [] array)
{
   
    for (int a = 0; a < array.Length; a++)
    {
        array[a] =  new Random().Next(2);
        Console.Write(array[a]+" ");
    }
}

RandomNumber(array);

int [] array = new int [8];

void RandomNumber(int [] array)
{
   
    for (int a = 0; a < array.Length; a++)
    {
        array[a] =  new Random().Next(2);
        Console.Write(array[a]+" ");
    }
}

RandomNumber(array)