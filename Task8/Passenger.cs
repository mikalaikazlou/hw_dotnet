using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Passenger
    {
        string firstName;
        string lastName;
        string patronymic;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Patronymic
        {
            get => patronymic;
            set => patronymic = value;
        }

        public void Welcome()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 6 & hour < 12)
                Console.WriteLine("Доброе утро!");
            else if (hour >= 12 & hour < 18)
                Console.WriteLine("Добрый день!");
            else if (hour >= 18 & hour < 23)
                Console.WriteLine("Добрый вечер!");
            else if (hour >= 23 & hour < 6)
                Console.WriteLine("Доброй ночи!");
        }

        public void FullName()
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }
    }
}