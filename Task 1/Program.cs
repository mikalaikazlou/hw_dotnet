using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            int b = 5;
            short c = 6;
            long d = 2;
            double e = 11.2;
            char f = 'A';

            //3 примера неявного преобразования типов
            c = a;
            b = c;
            d = a;

            //3 примера явного преобразования типов
            e = (double) a;
            f = (char) c;
            e = (double)d;

            //1 пример операции упаковки
            object up = a;

            //1 пример операции распаковки
            up = 111;
            int a1 = (int) up;
        }
    }
}
