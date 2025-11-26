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
                var connectionString = JsonNode.Parse(File.ReadAllText("appsetings.json"))["ConnectionStrings"]["DefaultConnection"].ToString();
                _dataSource = NpgsqlDataSource.Create(connectionString);

                return _dataSource;
            }
            catch (Exception er)
            {
                MessageBox.Show("Erreur lors de la création du DataSource : " + er.Message);
                throw;
            }
        }

        public static NpgsqlConnection Open_Connection(NpgsqlDataSource dataSource)
        {
            try
            {
                _connection = dataSource.OpenConnection(); // Ouvere la connexion
                return _connection;
            }
            catch(NpgsqlException er)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de la connexion. : " + er.Message);
                throw;
            }
        }
    }
}
