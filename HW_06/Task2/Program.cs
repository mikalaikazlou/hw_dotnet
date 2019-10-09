using System;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string verse = "Текст это упорядоченный набор предложений предназначенный для того чтобы выразить некий смысл";

            DeleteWordMax(verse);
            Console.WriteLine();

            ChangePosition(verse);
            Console.WriteLine();

            CountLetterMark(verse);

            ReversWords(verse);
        }

        static void DeleteWordMax(string text)
        {
            char[] symbol = { ' ', '.', ',', '!', '?', ';', ':', '"', '-', '\'', '\\' };
            string[] textSplit = text.Split(symbol);
            string maxWord = "";

            for (int i = 0; i < textSplit.Length; i++)
            {
                if (textSplit[i].Length > maxWord.Length) maxWord = textSplit[i];
            }

            int count = maxWord.Length + 1;
            int indexMaxWord = text.IndexOf(maxWord);
            string textNew = text.Remove(indexMaxWord, count);

            Console.WriteLine(textNew);
        }
        static void ChangePosition(string text)
        {
            char[] symbol = { ' ', '.', ',', '!', '?', ';', ':', '"', '-', '\'', '\\' };
            string maxWord = "";
            string minWord = text;
            string[] textSplit = text.Split(symbol);

            for (int i = 0; i < textSplit.Length; i++)
            {
                if (textSplit[i].Length > maxWord.Length) maxWord = textSplit[i];
                if (textSplit[i].Length < minWord.Length) minWord = textSplit[i];
            }

            string changeWord = text.Replace(maxWord, minWord);
            int count = minWord.Length;

            if (text.IndexOf(minWord) > changeWord.IndexOf(minWord))
            {
                int indexMinWord = changeWord.LastIndexOf(minWord);
                string deleteWord = changeWord.Remove(indexMinWord, count);
                string newText = deleteWord.Insert(indexMinWord, maxWord);

                Console.WriteLine(newText);
            }
            else
            {
                int indexMinWord = changeWord.IndexOf(minWord);
                string deleteWord = changeWord.Remove(indexMinWord, count);
                string newText = deleteWord.Insert(indexMinWord, maxWord);

                Console.WriteLine(newText);
            }
        }
        static void CountLetterMark(string text)
        {
            char[] symbol = { ' ', '.', ',', '!', '?', ';', ':', '"', '-', '\'', '\\' };
            string[] textSplit = text.Split(symbol);
            string joinWord = String.Join("", textSplit);
            int countLetter = joinWord.Length;
            int countMark = text.Length - countLetter;

            Console.WriteLine($"Count of letters: {countLetter}\nCount of punctuation mark: {countMark}\n");
        }
        static void ReversWords(string text)
        {
            char symbol = ' ';
            string[] textSplit = text.Split(symbol);

            for (int i = 0; i < textSplit.Length - 1; i++)
            {
                for (int j = textSplit.Length - 1; j > 0; j--)
                {
                    if (textSplit[j].Length > textSplit[j - 1].Length)
                    {
                        string tmp = textSplit[j];
                        textSplit[j] = textSplit[j - 1];
                        textSplit[j - 1] = tmp;
                    }
                }
            }

            foreach (string str in textSplit)
            {
                Console.WriteLine(str);
            }
        }
    }
}