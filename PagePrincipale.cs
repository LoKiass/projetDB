using Npgsql;

namespace projetDB
{
    public partial class PagePrincipale : Form
    {
        private static NpgsqlDataSource _dataSource;
        private static int id_last;

        public PagePrincipale(NpgsqlDataSource dataSource) // Datasource crée dans Program.Cs
        {
            InitializeComponent();

            _dataSource = dataSource;

            using (var conn = connection.Open_Connection(_dataSource))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM get_last_id()", conn))
                {
                   
                    try
                    {
                        var id = cmd.ExecuteScalar();

                        if (id != null)
                        {
                            id_last = Convert.ToInt32(id) + 1;

                            id_LABEL.Text = "Intervention : " + id_last ;
                        }
                        else
                        {
                            MessageBox.Show("ERREUR FATALE : LE PROGRAMME NA PAS PUE RECUP L'ID ");
                        }
                        
                    }
                    catch (NpgsqlException er)
                    {
                        MessageBox.Show(er.Message);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }
                   
                }

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = connection.Open_Connection(_dataSource))
            {
                using (var cmd = new NpgsqlCommand("CREATE TABLE B();", conn))
                {
                    try
                    {
                        var result = cmd.ExecuteNonQuery();
                    }

                    catch (NpgsqlException er)
                    {
                        MessageBox.Show("Erreur lors de l'exécution de la commande SQL : " + er.Message);
                    }

                }
            }
        }

        private void string_TEXTBOX(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conn = connection.Open_Connection(_dataSource)) // Ouvertue de la connexion
            {
                using ( var cmd = new NpgsqlCommand("CALL insert_intervention(@de, @s, @da)", conn)) // Creation de la commande
                {
                    if (!string.IsNullOrEmpty(description_TEXTBOX.Text) && // Verification si les cases sont pleines 
                        !string.IsNullOrEmpty(status_TEXTBOX.Text))
                    {
                        try 
                        {
                            // Ajout des paramètres pour la base de donnée 
                            cmd.Parameters.AddWithValue("@de", description_TEXTBOX.Text);
                            cmd.Parameters.AddWithValue("@s", status_TEXTBOX.Text);
                            cmd.Parameters.AddWithValue("@da", date_DATETIMEPICKER.Value.Date);

                            cmd.ExecuteNonQuery(); // Executions de la commandes 

                            id_last += 1; // Modificaiton de l'id au niveau de l'interface 
                            id_LABEL.Text = "Intervention " + id_last;
                        }
                        catch (NpgsqlException er)
                        {
                            MessageBox.Show(er.Message); // Si erreur lors de l'accès à la base de donné ou autres
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez remplir toutes les cases ");
                    }

                }
            }
        }

        
    }
}
