using System;

namespace Task1
{
    class Program
    {
        static int ReadConvert()
        {
            Console.WriteLine("Введите число № 1 и нажмите кнопку - <Enter>");
            string number1 = Console.ReadLine();

            Console.WriteLine("Введите число № 2 и нажмите кнопку - <Enter>");
            string number2 = Console.ReadLine();

            int number11 = Convert.ToInt32(number1);
            int number12 = Convert.ToInt32(number2);

            Console.WriteLine("Введите оператор \"+\" или \"-\"");
            string operators = Console.ReadLine();
            
            if (operators == "+" ) {
                int resalt = number11 + number12;
                return resalt;}
            else {
                int resalt = number11 - number12;
                return resalt;
            }
        }
        static void Main(string[] args)
        {
            int resaltEnd = ReadConvert();
            Console.WriteLine("Какой результат вычисления?");
            string numberAnswer = Console.ReadLine();
            int answer = Convert.ToInt32(numberAnswer);
            if (answer == resaltEnd) Console.WriteLine("Правильно!");
            else if (answer < resaltEnd) Console.WriteLine("Неправильно!\n\nДолжно быть больше!");
            else Console.WriteLine("Неправильно!\nДолжно быть  меньше!");
        }
    }
}