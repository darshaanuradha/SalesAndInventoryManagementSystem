using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace IMS.AppLogic
{
    internal class DatabaseHelper
    {
        private static string connectionString = "Server=.\\SQLEXPRESS;Database=IMS;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
