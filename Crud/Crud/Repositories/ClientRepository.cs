using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Repositories
{
    public class ClientRepository
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=winformdb;Integrated Security=True;TrustServerCertificate=True";

        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption: " + ex.ToString());
            }

            return clients;
        }
    }
}
