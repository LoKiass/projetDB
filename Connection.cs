using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;

namespace projetDB
{
    internal class connection
    {
        public static NpgsqlDataSource _dataSource;
        public static NpgsqlConnection _connection;

        public static NpgsqlDataSource Get_Datasource()
        {
            try
            {
                var connectionString = JsonNode.Parse(File.ReadAllText("Appsetings.json"))["ConnectionStrings"]["DefaultConnection"].ToString();
                _dataSource = NpgsqlDataSource.Create(connectionString);

                return _dataSource;
            }
            catch (Exception er)
            {
                return null;
            }
        }

        public static NpgsqlConnection Open_Connection(NpgsqlDataSource dataSource)
        {
            try
            {
                _connection = dataSource.OpenConnection(); // Ouvere la connexion
                return _connection;
            }
            catch (NpgsqlException er)
            {
                return null;
            }
        }
        public static void update_DataGrid(NpgsqlConnection conn, DataGridView dataGrid)
        {
            // Retrieve tous les Rows pour les affiches dans la DataGrid 
            using (var cmd = new NpgsqlCommand("SELECT * FROM intervention", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataGrid.Rows.Add(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3)
                            );
                    }
                }
            }

        }

    }
}
