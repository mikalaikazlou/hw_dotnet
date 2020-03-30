using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_09_new_with_SQL_
{
    class MotocycleRepositoryDB : IMotocycleRepository
    {
        string _connectionString = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=DatabaseMoto;Integrated Security=True";
        
        public void CreateMotocycle(Motocycle moto)
        {
            string query = $"insert into MOTORCYCLE values('{moto.Model}','{moto.MotoName}',{moto.Year},{moto.Odometer})";
            ExecuteQuery(query);
        }

        public void DeleteMotocycle(int id)
        {
            string query = $"delete from MOTORCYCLE where MOTORCYCLE.ID = {id}";
            ExecuteQuery(query);
        }

        public Motocycle GetMotocycle(int id)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand($"select * from MOTORCYCLE where MOTORCYCLE.ID = {id}", con);
            Motocycle resultMoto = new Motocycle();
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    resultMoto.Id = (int)reader["Id"];
                    resultMoto.Model = (string)reader["Model"];
                    resultMoto.MotoName = (string)reader["MotoName"];
                    resultMoto.Year = !(reader["YearMoto"] is DBNull) ? (int)reader["YearMoto"] : 0;
                    resultMoto.Odometer = (int)reader["Odometer"];
                }
            }

            con.Close();
            Console.WriteLine($"Motorcyle Id is: { resultMoto.Id.ToString()}" +
                $"\nModel is: { resultMoto.Model.ToString()}" +
                $"\nName is: { resultMoto.MotoName.ToString()}" +
                $"\nYear is: { resultMoto.Year.ToString()}" +
                $"\nOdometr is: { resultMoto.Odometer.ToString()}");
            return resultMoto;
        }

        public void UpdateMotoCycleModel(int id, string model)
        {
            string query = $"update MOTORCYCLE set MOTORCYCLE.Model = '{model}' where MOTORCYCLE.Id = {id}";
            ExecuteQuery(query);
        }

        public void UpdateMotoCycleName(int id, string name)
        {
            string query = $"update MOTORCYCLE set MOTORCYCLE.MotoName = '{name}' where MOTORCYCLE.Id = {id}";
            ExecuteQuery(query);
        }

        public void UpdateMotoCycleYear(int id, int year)
        {
            string query = $"update MOTORCYCLE set MOTORCYCLE.YearMoto = '{year}' where MOTORCYCLE.Id = {id}";
            ExecuteQuery(query);
        }

        public void UpdateMotoCycleOdometer(int id, int odometer)
        {
            string query = $"update MOTORCYCLE set MOTORCYCLE.Odometer = '{odometer}' where MOTORCYCLE.Id = {id}";
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            command.ExecuteReader();
            con.Close();
        }
    }
}