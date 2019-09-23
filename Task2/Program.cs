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
            object ob = 11.1;
            Object OB = 10.5;
            string str = "Good morning";
            String STR = "Good evening";

            Console.WriteLine("Типы данных" + "\n" + " byte b1 = "+ b1.GetType() + "\t" + "\t" + "Byte B1 = " + B1.GetType()+
             "\n" + " sbyte b = " + b.GetType() + "\t" + "\t" + " SByte B = " + B.GetType()+ "\n"+
             " int i = " + i.GetType() +"\t" + "\t" + " Int32 I = "+ I.GetType()+"\n" + 
             " uint i1 = " + i1.GetType() + "\t" + " UInt32 I1 = " + I1.GetType()+"\n" +
             " short s = " + s.GetType() + "\t" + "\t" + " Int16 S = " + S.GetType() + "\n" +
             " ushort s1 = " + s1.GetType() + "\t" + " UInt16 S1 = " + S1.GetType() + "\n" +
             " long lon = " + lon.GetType() + "\t" + " Int64 Lon = " + Lon.GetType() + "\n" +
             " ulong lon1 = " + lon1.GetType() + "\t" + " UInt64 Lon1 = " + Lon1.GetType() + "\n" +
             " double dou = " + dou.GetType() + "\t" + " Double Dou = " + Dou.GetType() + "\n" +
             " float fl = " + fl.GetType() + "\t" + " Single Fl = " + Fl.GetType() + "\n" +
             " char ch = " + ch.GetType() + "\t" + "\t" + " Char CH = " + CH.GetType() + "\n" +
             " decimal dec = " + dec.GetType() + "\t" + " Decimal DEC = " + DEC.GetType() + "\n" +
             "  object ob = " + ob.GetType() + "\t" + " Object OB = " + OB.GetType() + "\n" +
             " string str = " + str.GetType() + "\t" + " String STR = " + STR.GetType() + "\n" );
            Console.ReadKey();
        }
    }
}
