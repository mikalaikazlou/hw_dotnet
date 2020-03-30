using System.Data.Entity;

namespace Task9
{
    public class Motorcycle
    {
        public int id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int odometer { get; set; }
    }

    public class MotorcycleContext : DbContext
    {
        public MotorcycleContext() : base("DefaultConnection")
        {
        }
        public DbSet<Motorcycle> Motorcycles { get; set; }
    }
}