﻿using System.Data;
using Npgsql;

namespace Plan_B
{
    public class ConecctionDB
    {
        private static string host = "127.0.0.1",
            database = "Felidae",
            UserId = "postgres",
            password = "gato";

        private static string sConnection =
            $"Server={host};Port=5432;User Id={UserId};Password={password};Database={database};";

        public static DataTable ExecuteQuery(string query)
        {
            //coneccion
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            //conjunto de tablas
            DataSet ds = new DataSet();
            
            connection.Open();
            
            //adaptador, ejecuta la consulta en una coneccion
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,connection);
            //llenar un dataset
            da.Fill(ds);
            
            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(act,connection);
            command.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}