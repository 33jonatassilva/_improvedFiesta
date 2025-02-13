using AccessWithDapper.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AccessWithDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True";
            
            using (var connection = new SqlConnection(connectionString))
            {
                ListCategories(connection);
                //CreateCategory(connection);
            }
        }
        static void ListCategories(SqlConnection connection)
        {
           
                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
                
                foreach (var item in categories)
                {
                    Console.WriteLine($"{item.Id} = {item.Title}");
                }
            
        }

        static void CreateCategory(SqlConnection connection)
        {

            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Apache Kafka";
            category.Url = "Apache";
            category.Description = "Categoria destinada a serviços da AWS";
            category.Order = 8;
            category.Summary = "Mensageria";
            category.Featured = false;

            var insertSql = @"INSERT INTO 
                [Category] 
            VALUES (
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order, 
                @Description, 
                @Featured)";


               
                var rows = connection.Execute(insertSql, new {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                });

                System.Console.WriteLine($"{rows} linhas inserida(s)");
                

        }
    
        

    }
}