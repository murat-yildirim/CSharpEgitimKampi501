﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionString
{
    public class DatabaseConnectionString
    {
        //public static void SQLDatabaseConnectionString()
        //{
        //    SqlConnection connection = new SqlConnection("Server=DESKTOP-363RU31\\SQLEXPRESS;initial Catalog=EgitimKampi501Db;integrated security=true");

        //}

        private static readonly string _connectionString ="Server=DESKTOP-363RU31\\SQLEXPRESS;initial Catalog=EgitimKampi501Db;integrated security=true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
