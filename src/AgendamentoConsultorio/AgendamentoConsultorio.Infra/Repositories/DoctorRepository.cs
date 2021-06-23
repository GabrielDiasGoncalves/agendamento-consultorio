using AgendamentoConsultorio.Domain.Models;
using Dapper;

using MySql.Data.MySqlClient;

using System;

namespace AgendamentoConsultorio.Infra.Repositories
{
    public class DoctorRepository : Services.Interfaces.IRepository<Doctor>
    {
        private string _connectionString;

        private const string _INSERTCOMMAND =
            "INSERT INTO tb_doctor (Name, Specialty, CPF, Salary, Address, CEP) " +
            "VALUES (@Name, @Specialty, @CPF, @Salary, @Address, @CEP);" +
            "SELECT LAST_INSERT_ID();";

        public DoctorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Doctor obj)
        {
            try
            {
                MySqlConnection connection;
                using (connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    var id = connection.ExecuteScalar<int>(
                        _INSERTCOMMAND, 
                        new { Name = obj.Name, Specialty = obj.Specialty, CPF = obj.CPF, Salary = obj.Salary, Address = obj.Address, CEP = obj.CEP }
                    );


                    Console.WriteLine(id);
                }

                Console.WriteLine(connection.State);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
