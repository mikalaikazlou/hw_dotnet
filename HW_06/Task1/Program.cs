using System;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение в одну строку разделяя строки точкой с запятой:\n");

            string verseRead = Console.ReadLine();
            char symbol = ';';
            string[] verseSplit = verseRead.Split(symbol);

            for (int i = 0; i < verseSplit.Length; i++)
            {
                string versh = verseSplit[i].Replace('О', 'А');
                Console.WriteLine(versh);
            }
        }
    }
}

