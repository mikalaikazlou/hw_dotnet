using log4net;
using log4net.Config;
using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            log.Info("Приложение Program, namespace Task9");

            using (MotorcycleContext db = new MotorcycleContext())
            {
                log.Info("Начался процесс CRUD операций");
                
                Motorcycle motorcycle = new Motorcycle { name = "honda", model = "fg", year = 3, odometer = 244_325 };
                Motorcycle motorcycle1 = new Motorcycle { name = "Minsk", model = "lider", year = 34, odometer = 252_000 };
                
                db.Motorcycles.Add(motorcycle);
                db.Motorcycles.Add(motorcycle1);
                db.SaveChanges();

                motorcycle.name = "HONDA";
                motorcycle.model = "Gold Wing";
                db.SaveChanges();

                db.Motorcycles.Attach(motorcycle1);
                db.Motorcycles.Remove(motorcycle1);
                db.SaveChanges();

                log.Info("Начался процесс вывода данных на Консоль");

                var motobike = db.Motorcycles.ToList();
                foreach (var moto in motobike)
                    Console.WriteLine($"{moto.id}, {moto.name} , {moto.model}, {moto.odometer}, {moto.year}");

                log.Info("Программа успешна завершена");
            }
        }
    }
}