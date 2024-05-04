using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION
{
    public partial class idCli : Form
    {
        public string idcli, codeR, typeOfpaid;
        public idCli()
        {
            InitializeComponent();
        }

        private void Advanced_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int.TryParse(a,out int b);
            reservation rsv = new reservation();
            rsv.t = Convert.ToInt32(b);


            string connectionString = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                {
                    con.Open();

                    string sql = "SELECT coastV FROM travel WHERE codeV = @trvlCode"; // Utilisation de paramètres pour éviter les problèmes de sécurité
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@trvlCode", codeR); // Associer la valeur du paramètre

                    MySqlDataReader reader = cmd.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            // Récupérer la valeur de la colonne "travelCoast" à partir du résultat de la requête
                            // decimal travelCoast = reader.GetDecimal("coastV");

                            int travelCoast = reader.GetInt32("coastV");

                            // Convertir la valeur en chaîne et l'assigner à la variable "id"
                            

                            ClassReservation cl = new ClassReservation(idcli, codeR, typeOfpaid, travelCoast-b);
                            ClassDbReservation.addNewReservation(cl);

                            // Maintenant, vous pouvez utiliser la valeur dans votre application

                        }
                        else
                        {
                            Console.WriteLine("Aucun résultat trouvé pour le code de voyage spécifié.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
            }
            textBox1.Text = string.Empty;
            this.Hide();
        }

      
                

         

           

    }
 }

