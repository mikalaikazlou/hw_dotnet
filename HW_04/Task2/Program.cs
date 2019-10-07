using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Нажмите клавишу W,S,A,D" + "\n");
            string letters = Console.ReadLine();
            char letter = Convert.ToChar(letters);

            if (letter == 'W' || letter == 'w') Console.WriteLine("Переместить фигуру вверх");
            else if (letter == 'S' || letter == 's') Console.WriteLine("Переместить фигуру вниз");
            else if (letter == 'A' || letter == 'a') Console.WriteLine("Переместить фигуру влево");
            else if (letter == 'D' || letter == 'd') Console.WriteLine("Переместить фигуру вправо");
            else Console.WriteLine("Фигуру перемещать не надо");
        }
    }
}
