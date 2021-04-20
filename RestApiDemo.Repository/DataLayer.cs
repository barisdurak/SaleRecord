using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace RestApiDemo.Repository
{
    public class DataLayer
    {
        internal static IDbConnection GetConnection(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            return new MySqlConnection(connectionString);
        }



    }
}
