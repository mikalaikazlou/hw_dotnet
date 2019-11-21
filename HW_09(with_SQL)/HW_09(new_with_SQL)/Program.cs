using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace HW_09_new_with_SQL_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            XmlConfigurator.Configure();
            log.Info("The program is running");

            MotocycleRepositoryDB rep = new MotocycleRepositoryDB();
            log.Info("The process of CRUD operations began");

            Motocycle moto1 = new Motocycle();
            Motocycle moto2 = new Motocycle();
            Motocycle moto3 = new Motocycle();
           
            moto1.Model = "Honda";
            moto1.MotoName = "Gold Wings";
            moto1.Odometer = 20_222;
            moto1.Year = 4;

            log.Info("The process of creating an object №1 in a database");
            rep.CreateMotocycle(moto1);

            moto2.Model = "Susuki";
            moto2.MotoName = "H450";
            moto2.Odometer = 10_240;
            moto2.Year = 2;

            log.Info("The process of creating an object №2 in a database");
            rep.CreateMotocycle(moto2);

            moto3.Model = "Susuki";
            moto3.MotoName = "H450";
            moto3.Odometer = 10_240;
            moto3.Year = 2;

            log.Info("The process of creating an object №3 in a database");
            rep.CreateMotocycle(moto3);

            log.Info("The process of updating an object model in a database");
            rep.UpdateMotoCycleModel(17, "X250");

            log.Info("The process of updating an object name in a database");
            rep.UpdateMotoCycleName(17, "Minsk");

            try
            {
                log.Debug("Error search");
                rep.UpdateMotoCycleName(-1, "Kawasaki");
            }

            catch
            {
                log.Error("Update operation failed, no object detected");
            }

            log.Info("The process of updating an object year in a database");
            rep.UpdateMotoCycleYear(17, 2018);

            log.Info("The process of updating an object odometer reading in a database");
            rep.UpdateMotoCycleOdometer(17, 21001);

            try
            {
                log.Debug("Error search");
                rep.GetMotocycle(0);
            }

            catch
            {
                log.Error("The object does not exist in the database");
            }

            log.Info("The process of getting an object  from a database");
            rep.GetMotocycle(18);

            log.Info("The process of deleting an object  from a database");
            rep.DeleteMotocycle(19);

            try
            {
                log.Debug("Error search");
                rep.DeleteMotocycle(1);
            }

            catch
            {
                log.Error("The object does not exist in the database");
            }

            log.Info("The program is ended");
            Console.ReadLine();
        }
    }
}