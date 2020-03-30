using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcyclePublic motorcyclePublic = new MotorcyclePublic();
            string engineNumber = motorcyclePublic.engineNumberPublic;

            SportBikeTwo sportBikeTwo = new SportBikeTwo();
            sportBikeTwo.StartEngineSport();
            int ageSportbike = sportBikeTwo.MaxSpeedSport;
            string nameSportbike = sportBikeTwo.engineNumberPublic;
        }
    }
}
