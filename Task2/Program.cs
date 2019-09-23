using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 10;
            Byte B1 = 11;

            sbyte b = 2;
            SByte B = 4;
            int i = 5;
            Int32 I = 45;
            uint i1 = 3;
            UInt32 I1 = 23;
            short s = 6;
            Int16 S = 43;
            ushort s1 = 4;
            UInt16 S1 = 34;
            long lon = 2;
            Int64 Lon = 234;
            ulong lon1 = 99;
            UInt64 Lon1 = 2345;
            double dou = 11.2;
            Double Dou = 234.34;
            float fl = 2.2F;
            Single Fl = 23.345F;
            char ch = 'a';
            Char CH = 'A';
            decimal dec = 22m;
            Decimal DEC = 235.34m;
            object ob;
            Object OB;
            string str = "Good morning";
            String STR = "Good evening";

            Console.WriteLine("Тип данных" + b1.GetType() + "\n" + B1.GetType());
            Console.ReadKey();
        }
    }
}
