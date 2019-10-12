using System;
using System.Diagnostics;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numArray = new long[100];
            Random random = new Random();
            Stopwatch watching = new Stopwatch();
            Stopwatch watching2 = new Stopwatch();

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = random.Next(1, 100);
            }

            Console.WriteLine();

            foreach (int firstArray in numArray)
            {
                Console.WriteLine(firstArray);
            }

            watching.Start();

            for (int i = 0, t = numArray.Length - 1; i < (numArray.Length) / 2; i++, t--)
            {
                long copyValue = numArray[i];
                numArray[i] = numArray[t];
                numArray[t] = copyValue;
            }
            
            watching.Stop();

            Console.WriteLine();

            foreach (int finalArray in numArray)
            {
                Console.WriteLine(finalArray);
            }

            Console.WriteLine();
            
            watching2.Start();
            
            Array.Reverse(numArray);

            watching2.Stop();

            foreach (int finalArray in numArray)
            {
                Console.WriteLine(finalArray);
            }
            
            Console.WriteLine("\nThe result of my method: {0} millisecond", watching.ElapsedMilliseconds);
            Console.WriteLine("\nThe result of reverse method: {0} millisecond", watching2.ElapsedMilliseconds);

            if (watching.ElapsedMilliseconds < watching2.ElapsedMilliseconds)
                {
                   Console.WriteLine("\nMy method is better");
                }
              else if (watching.ElapsedMilliseconds > watching2.ElapsedMilliseconds) Console.WriteLine("\nReverse method is better");
                else Console.WriteLine("\nMethods are equal");
        }
    }
}
