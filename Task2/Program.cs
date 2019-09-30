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
            Console.WriteLine("Типы данных:");
            byte b1 = 10;
            Byte clrb1 = 11;
            Console.WriteLine(b1.GetType() + "\t\t"+ clrb1.GetType());

            sbyte b = 2;
            SByte clrB = 4;
            Console.WriteLine(b.GetType() + "\t\t" + clrB.GetType());

            int i = 5;
            Int32 clrI = 45;
            Console.WriteLine(i.GetType() + "\t\t" + clrI.GetType());

            uint i1 = 3;
            UInt32 clrI1 = 23;
            Console.WriteLine(i1.GetType() + "\t\t" + clrI1.GetType());

            short s = 6;
            Int16 clrS = 43;
            Console.WriteLine(s.GetType() + "\t\t" + clrS.GetType());

            ushort s1 = 4;
            UInt16 clrS1 = 34;
            Console.WriteLine(s1.GetType() + "\t\t" + clrS1.GetType());

            long lon = 2;
            Int64 clrLon = 234;
            Console.WriteLine(lon.GetType() + "\t\t" + clrLon.GetType());

            ulong lon1 = 99;
            UInt64 clrLon1 = 2345;
            Console.WriteLine(lon1.GetType() + "\t\t" + clrLon1.GetType());

            double dou = 11.2;
            Double clrDou = 234.34;
            Console.WriteLine(dou.GetType() + "\t\t" + clrDou.GetType());

            float fl = 2.2F;
            Single clrFl = 23.345F;
            Console.WriteLine(fl.GetType() + "\t\t" + clrFl.GetType());

            char ch = 'a';
            Char clrCH = 'A';
            Console.WriteLine(ch.GetType() + "\t\t" + clrCH.GetType());

            decimal dec = 22m;
            Decimal clrDEC = 235.34m;
            Console.WriteLine(dec.GetType() + "\t\t" + clrDEC.GetType());

            object ob = 11.1;
            Object clrOB = 10.5;
            Console.WriteLine(ob.GetType() + "\t\t" + clrOB.GetType());

            string str = "Good morning";
            String clrSTR = "Good evening";
            Console.WriteLine(str.GetType() + "\t\t" + clrSTR.GetType());
            Console.ReadKey();
        }
    }
}
