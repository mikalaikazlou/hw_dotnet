using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];

            Console.WriteLine("Введите {0} численных элементов массива",numArray.Length - 1);

            for (int i = 0; i < numArray.Length - 1; i++)
            {
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine();

            foreach (int numberOne in numArray)
            {
                Console.WriteLine(numberOne);
            }

            Console.WriteLine();
            Console.Write("Введите еще один элемент массива: ");
            int numberAdd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Задайте позицию введенного элемента от {0} до {1}: ", 0, numArray.Length - 1);
            int numberPosition = Convert.ToInt32(Console.ReadLine());

            for (int i = numArray.Length - 1; i > numberPosition; i--)
            {
                numArray[i] = numArray[i - 1];
            }

            numArray[numberPosition] = numberAdd;

            Console.WriteLine();

            foreach (int numberTwo in numArray)
            {
                Console.WriteLine(numberTwo);
            }
        }
    }
}
