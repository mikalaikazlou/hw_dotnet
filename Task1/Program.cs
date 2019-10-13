using System;
using System.Diagnostics;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleInternal motorcycleInternal = new MotorcycleInternal();
            motorcycleInternal.StartEnginePublic();
            int age = motorcycleInternal.ageMotobike;

            MotorcyclePublic motorcyclePublic = new MotorcyclePublic();
            string engineNumber = motorcyclePublic.engineNumberPublic;
            int speedInternal = MotorcyclePublic.MaxSpeedInternal;

            SportBike sportBike = new SportBike();
            sportBike.StartEngineInternal();
            sportBike.StartEngineProtectedInternal();
            sportBike.StartEnginePublic();
            int ageSportbike = sportBike.ageMotobike;
            string nameSportbike = sportBike.nameMotobike;


        }
    }
}

