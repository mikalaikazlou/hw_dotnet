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
        {   byte b1 = 10;
            sbyte b = 2;
            int i = 5;
            uint i1 = 3;
            short s = 6;
            ushort s1 = 4;
            long lon = 2;
            ulong lon1 = 99;
            double dou = 11.2;
            float fl = 2.2F;
            char ch = 'A';
            decimal dec = 22;

            //3 примера неявного преобразования типов
            int q;
            q = b + i;
            long w;
            w = i + q;
            ulong e;
            e = i1 + lon1;
            Console.WriteLine("Результаты неявного преобразования типов" + "\n" +"int q = "+ q + "\n" + "long w = " + w + "\n" + "ulong e = " + e + "\n");
            
             //3 примера явного преобразования типов
            char qw;
            qw = (char)(lon1 + i1);
            byte we;
            we = (byte)(i1 + s);
            int er;
            er = (int)(dou + fl);
            Console.WriteLine("Результаты явного преобразования типов" + "\n" + "char qw = " + qw + "\n" + "byte we = " + we + "\n" + "int er = " + er + "\n");
            
            //1 пример операции упаковки
            object up = b1;
            Console.WriteLine("Результат операции упаковки" + "\n" + "object up = " + b1 + "\n");
           
            //1 пример операции распаковки
            byte v = (byte)(up);
            Console.WriteLine("Результат операции распаковки" + "\n" + "byte v = " + v);
            Console.ReadLine();
        }
    }
}
