using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1000;
            double percent = 0.02;
            double increase;

            for (int i = 1; i <= 10; i++)
            {
                increase = sum * percent;
                sum += increase;
                Console.WriteLine("Прирост за " + i + " месяц равен " + "{0:#.## руб.}", increase);
            }

            for (int i = 1; i <= 12; i++)
            {
                sum += sum * percent;
                if (i >= 3 && i <= 12)
                {
                 Console.WriteLine("Сумма вклада через " + i + " месяца(-ев) равна " + "{0:#.## руб.}", sum);
                }
            }
        }
    }
}
