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
            try
            {
                using (var conn = connection.Open_Connection(_dataSource))
                {
                    // Select du dernier ID de la table 
                    using (var cmd = new NpgsqlCommand("SELECT * FROM get_last_id()", conn))
                    {


                        var id = cmd.ExecuteScalar();

                        if (id != null)
                        {
                            id_last = Convert.ToInt32(id) + 1;

                            id_LABEL.Text = "Intervention : " + id_last;
                        }
                        else
                        {
                            MessageBox.Show("ERREUR FATALE : LE PROGRAMME NA PAS PUE RECUP L'ID ");
                        }
                    }

                    connection.update_DataGrid(conn, dataGrid);
                }
            }
            catch (NpgsqlException er)
            {
                MessageBox.Show("Erreur lors de l'accès à la base de donnée : " + er.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erreur :" + er.Message);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = connection.Open_Connection(_dataSource))
            {
                using (var cmd = new NpgsqlCommand("CREATE TABLE B();", conn))
                {
                    
                    var result = cmd.ExecuteNonQuery();
                }
            }
        }

        private void string_TEXTBOX(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = connection.Open_Connection(_dataSource)) // Ouvertue de la connexion
                {
                    using (var cmd = new NpgsqlCommand("CALL insert_intervention(@de, @s, @da)", conn)) // Creation de la commande
                    {
                        if (!string.IsNullOrEmpty(description_TEXTBOX.Text) && // Verification si les cases sont pleines 
                            !string.IsNullOrEmpty(status_TEXTBOX.Text))
                        {

                            // Ajout des paramètres pour la base de donnée 
                            cmd.Parameters.AddWithValue("@de", description_TEXTBOX.Text);
                            cmd.Parameters.AddWithValue("@s", status_TEXTBOX.Text);
                            cmd.Parameters.AddWithValue("@da", date_DATETIMEPICKER.Value.Date);

                            cmd.ExecuteNonQuery(); // Executions de la commandes 

                            id_last += 1; // Modificaiton de l'id au niveau de l'interface 
                            id_LABEL.Text = "Intervention " + id_last;

                            dataGrid.Rows.Add(description_TEXTBOX.Text, status_TEXTBOX.Text, date_DATETIMEPICKER.Value.Date.ToShortDateString(), id_last - 1); // Ajout de la nouvelle ligne dans le datagrid
                        }


                        else
                        {
                            MessageBox.Show("Vous devez remplir toutes les cases ");
                        }

                    }
                }
            }
            catch (NpgsqlException er)
            {
                MessageBox.Show("Erreur lors de l'accès à la base de donnée : " + er.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erreur :" + er.Message);
            }

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
