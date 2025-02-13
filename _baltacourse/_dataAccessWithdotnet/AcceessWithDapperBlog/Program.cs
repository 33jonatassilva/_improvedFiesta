
using AccessWithDapperBlog.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Xml;
using AccessWithDapperBlog.Repositories;

namespace AccessWithDapperBlog
{
    public class Program
    {

        private const string  CONNECTION_STRING = "Server=localhost;Database=blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True";


        static void Main(string[] args)
        {
            ReadUsers(CONNECTION_STRING);
        }

        public static void ReadUsers(string connectionString)
        {

            var repository = new UserRepository();
            var users = repository.Get(connectionString);

            foreach (var user in users)
            {
                System.Console.WriteLine(user.Name);
            }
            
        }

        public static void ReadUser(int id)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(id);
                System.Console.WriteLine(user.Name);
            }
        }

        public static void CreateUser(User user)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                System.Console.WriteLine("Cadastro realizado com sucesso!");
                
            }
        }

        public static void UpdateUser(User user)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                System.Console.WriteLine("Update realizado com sucesso!");
                
            }
        }

        public static void DeleteUser(int id)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(id);
                connection.Delete<User>(user);
                System.Console.WriteLine("Delete realizado com sucesso!");
                
            }
        }
    }
}