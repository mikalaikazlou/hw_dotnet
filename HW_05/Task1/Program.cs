using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { 
          int[] firstArray = new int[8];
          int[] secondArray = new int[8];
          int[] thirdArray = new int[8];
          Random random = new Random();

          for (int i = 0; i < firstArray.Length; i++)
            {
               firstArray[i] = random.Next(1, 10);
            }

          Console.WriteLine("Введите восемь чисел");

          for (int i = 0; i < secondArray.Length; i++)
            {
               int number = Convert.ToInt32(Console.ReadLine());
               secondArray[i] = number;
            }

          Console.WriteLine();

          for (int i = 0; i < thirdArray.Length; i++)
            {
               thirdArray[i] = firstArray[i] + secondArray[i];
            }

          Console.WriteLine("\nfirstArray:\n");

          foreach (int number1 in firstArray)
            {
               Console.WriteLine(number1);
            }

          Console.WriteLine("\nsecondArray:\n");

          foreach (int number2 in secondArray)
            {
               Console.WriteLine(number2);
            }

          Console.WriteLine("\nthirdArray:\n");

          foreach (int number3 in thirdArray)
            {
               Console.WriteLine(number3);
            }
        }
    }
}
