using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_new_with_SQL_
{
    interface IMotocycleRepository
    {
        void CreateMotocycle(Motocycle moto);

        Motocycle GetMotocycle(int id);

        void UpdateMotoCycleModel(int id, string model);

        void UpdateMotoCycleName(int id, string name);

        void UpdateMotoCycleOdometer(int id, int odometer);

        void UpdateMotoCycleYear(int id, int year);

        void DeleteMotocycle(int id);
    }
}