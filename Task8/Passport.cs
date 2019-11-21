using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Passport
    {
        readonly string seriesPassport;
        readonly int numberPassport;
        readonly string visaPassport;

        public Passport(string s, int n)
        {
            seriesPassport = s;
            numberPassport = n;
            visaPassport = "no";
        }

        public Passport(string s, int n, string v)
        {
            seriesPassport = s;
            numberPassport = n;
            visaPassport = v;
        }

        public void PassportControl()
        {
            if (visaPassport.Equals("visa"))
            {
                Console.WriteLine("Вы допущены к рейсу, проходите в зал ожидания!\n Счастливого пути!");
            }
            else Console.WriteLine("Вы не допущены к рейсу, у Вас отсутствует виза!");
        }
    }
}