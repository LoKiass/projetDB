using Npgsql;

namespace projetDB
{
    internal static class Program
    {
        public static NpgsqlDataSource dataSource;
        public static NpgsqlConnection conn;

        [STAThread]

        static async Task Main()
        {

            try
            {
                dataSource = connection.Get_Datasource();
                conn = connection.Open_Connection(dataSource);

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture de la connexion : " + ex.Message);
                return;
            }
            catch (Exception er)
            {
                MessageBox.Show("Erreur application : " + er.Message);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new PagePrincipale(dataSource));

            dataSource.Dispose();
            conn.Dispose();


        }
    }
}