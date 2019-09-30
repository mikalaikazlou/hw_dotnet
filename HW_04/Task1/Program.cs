using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i > 64; i--)
            {
                string upperChar = Char.ConvertFromUtf32(i);
                Console.Write(upperChar + " ");
            }

            Console.WriteLine();

            for (int i = 122; i > 96; i--)
            {
                string lowerChar = Char.ConvertFromUtf32(i);
                Console.Write(lowerChar + " ");
            }
        }
    }
}
