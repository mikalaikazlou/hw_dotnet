using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            Passport passport = new Passport("GT", 32546464, "visa");
            Ticket ticket = new Ticket();

            Gun gun = new Gun();
            Shoes shoes = new Shoes();
            Laptop laptop = new Laptop();
            Thing thing = new Thing();

            Suitcase suitcase = new Suitcase(gun, shoes, laptop, thing);
            Security security = new Security(suitcase);
            Random random = new Random();

            passenger.Welcome();
            Console.WriteLine($"Вас приветствует аэропорт IT-Academy. Представьтесь, пожалуйста!");
            Console.WriteLine("Ваша фамилия, имя, отчество:");

            passenger.LastName = Console.ReadLine();
            Console.Write("");
            passenger.FirstName = Console.ReadLine();
            Console.Write("");
            passenger.Patronymic = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"{passenger.FirstName} {passenger.Patronymic}, пройдите, пожалуйста, на регистрацию!\n");
            Console.WriteLine("Вы проходили регистрацию Online");

            string answerCheckIn = Console.ReadLine();

            if (answerCheckIn.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nПредъявите Ваш билет и паспорт");
            }
            else Console.WriteLine("\nПредъявите Ваш паспорт");

            ticket.NumberFlight = random.Next(100, 1000);
            ticket.NumberTicket = random.Next(1, 100);
            ticket.PasspControl = random.Next(1, 20);
            ticket.TicketGate();

            Console.WriteLine($"\n{passenger.FirstName} {passenger.Patronymic}, у Вас есть багаж?");

            string answerSuitcase = Console.ReadLine();

            if (answerSuitcase.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nПоложите Ваш багаж на ленту, проходите на досмотр");
            }
            else Console.WriteLine("Проходите на досмотр\n");

            passenger.Welcome();
            Console.WriteLine("Предъявите ручную кладь к досмотру, достаньте все вещи из карманов!");
            Console.WriteLine("В Ваших вещах есть что-нибудь запрещенное к провозу?");

            string answerSuit = Console.ReadLine();

            if (answerSuit.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nПройдите в комнату для детального досмотра!");
            }
            else
            {
                suitcase.SuitcaseThings();
                Console.WriteLine("\nЭто Ваш багаж с вещами?");
                string answer = Console.ReadLine();

                if (answer.Equals("да", StringComparison.OrdinalIgnoreCase) || answer.Equals("нет", StringComparison.OrdinalIgnoreCase))
                {
                    security.SecuritySuitcase();
                }
                else if (answer != "да" || answer != "Да" || answer != "нет" || answer != "Нет")
                {
                    throw new Exception("Неправильный ответ!");
                }
                else
                {
                    Console.ReadLine();
                    Console.Read();
                    passenger.Welcome();
                    Console.WriteLine("\nПредъявите Ваш паспорт!");
                    passenger.FullName();
                    passport.PassportControl();
                }
            }
        }
    }
}