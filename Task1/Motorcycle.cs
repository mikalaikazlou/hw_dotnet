using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class MotorcycleInternal
    {
        private const int MaxSpeedPrivate = 300;
        protected string vinNumberProtected = "6465-4651FGJH-F5445-4SDFH";
        private protected int odometerPrivateProtected = 20_000;
        public int ageMotobike = 4;
        private int StartEnginePrivate()
        {
            return MaxSpeedPrivate;// константа доступна только в классе MotorcycleInternal
        }
        public void StartEnginePublic()
        {
            Console.WriteLine($"MaxSpeedPrivate = {StartEnginePrivate()}");// метод доступен только в классе MotorcycleInternal
        }
    }
    public class MotorcyclePublic
    {
        internal const int MaxSpeedInternal = 200;
        public string engineNumberPublic = "564-756-444";
        private protected int StartEnginePrivateProtected()
        {
            return MaxSpeedInternal * 2;
        }
        protected void StartEngineProtected()
        {
            StartEnginePrivateProtected();
        }
    }
    class SportBike : MotorcycleInternal
    {
        protected internal string nameMotobike = "Honda";

        internal void StartEngineInternal()
        {
            Console.WriteLine($"Вин номер мотоцикла {nameMotobike}: {vinNumberProtected}");// string vinNumberProtected наследуемый от класса MotorcycleInternal
            Console.WriteLine($"MaxSpeedInternal = {MotorcyclePublic.MaxSpeedInternal}");
        }
        protected internal string StartEngineProtectedInternal()
        {
            return vinNumberProtected;
        }
    }
    public class SportBikeTwo : MotorcyclePublic
    {
        public int MaxSpeedSport = MaxSpeedInternal;
        public void StartEngineSport()
        {
            StartEngineProtected();
        }
    }
}
