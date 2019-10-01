using System;

namespace Task1
{
    class Program
    {
        static int ReadConvert()
        {
            Console.WriteLine("Введите число № 1 и нажмите кнопку - <Enter>");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите число № 2 и нажмите кнопку - <Enter>");
            string num2 = Console.ReadLine();
            int num11 = Convert.ToInt32(num1);
            int num12 = Convert.ToInt32(num2);
            int sum = num11 + num12;
            Console.WriteLine("Чему равна сумма?");
            return sum;
        }

        static void Main(string[] args)
        {
            int sumEnd = ReadConvert();
            string numberAnswer = Console.ReadLine();
            int answer = Convert.ToInt32(numberAnswer);
                if (answer == sumEnd)  Console.WriteLine("Правильно!");
                else Console.WriteLine("Неправильно!");
        }
    }
}