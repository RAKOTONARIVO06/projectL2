using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION
{
    public partial class reservation : Form
    {
        
        string ide="";
        public int value;
        public int t;
        
        public reservation()
        {
            InitializeComponent();
            showAllowVoyage();
            showAllowClient();
            showRecette();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reservation res = new reservation();
            this.Hide();
            res.Show();
        }

        public void Display()
        {
            ClassDbClient.DisplayAndSearch("SELECT idReservation,idClient,codeVoyage,typeOfpaid,reste from reservation,client,travel where reservation.idClient=client.idCli and reservation.codeVoyage=travel.codeV", dataGridView50);
        }
        public void showAllowVoyage()
        {
            string sql1 = "SELECT codeV FROM travel,train where travel.codeTrain=train.numTrain and statusTrain='Available' ";
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql1, con);

                MySqlDataReader rdr;

                rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                trvc.Items.Clear();

                dt.Columns.Add("codeV", typeof(String));

                dt.Load(rdr);

                trvc.DisplayMember = "codeV";

                trvc.DataSource = dt;

                trvc.ValueMember = "codeV";

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }



        }
        public void showRecette()
        {
            string sql1 = "SELECT SUM(coastV) from reservation,travel where travel.codeV=reservation.codeVoyage ";
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql1, con);

                MySqlDataReader rdr;

                rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                total.Items.Clear();

                dt.Columns.Add("SUM(coastV)", typeof(int));


                dt.Load(rdr);

                total.DisplayMember = "SUM(coastV)";

                total.DataSource = dt;

                total.ValueMember = "SUM(coastV)";

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }



        }
        public void showAllowClient()
        {
            string sql1 = "SELECT idCli FROM client ";
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql1, con);

                MySqlDataReader rdr;

                rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                idcl.Items.Clear();

                dt.Columns.Add("idCli", typeof(String));


                dt.Load(rdr);

                idcl.DisplayMember = "idCli";

                idcl.DataSource = dt;

                idcl.ValueMember = "idCli";

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }



        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveR.Text == "Suivant") {
            if (trvc.Text == "")
            {
                MessageBox.Show("This first case is obligatory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (idcl.Text == "")
            {
                MessageBox.Show("This second case is obligatory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tpop.Text == "")
            {
                MessageBox.Show("This third case is obligatory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                if (tpop.Text == "All")
                {
                    int rest = 0;
                    ClassReservation clr = new ClassReservation(idcl.Text, trvc.Text, tpop.Text, rest);
                    ClassDbReservation.addNewReservation(clr);
                }
                else if (tpop.Text == "Null")
                {

                    string connectionString = "server=localhost; port=3306; username=root; password=narivo2777; database=railway"; // Remplacez cela par votre chaîne de connexion MySQL
                    string trvlCode = trvc.Text;

                    try
                    {
                        MySqlConnection con = new MySqlConnection(connectionString);
                        {
                            con.Open();

                            string sql = "SELECT coastV FROM travel WHERE codeV = @trvlCode"; // Utilisation de paramètres pour éviter les problèmes de sécurité
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@trvlCode", trvc.Text); // Associer la valeur du paramètre

                            MySqlDataReader reader = cmd.ExecuteReader();
                            {
                                if (reader.Read())
                                {
                                    // Récupérer la valeur de la colonne "travelCoast" à partir du résultat de la requête
                                    // decimal travelCoast = reader.GetDecimal("coastV");

                                    int travelCoast = reader.GetInt32("coastV");

                                    // Convertir la valeur en chaîne et l'assigner à la variable "id"


                                    ClassReservation cl = new ClassReservation(idcl.Text, trvc.Text, tpop.Text, travelCoast);
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

                }
                else
                {
                    idCli ad = new idCli();
                    ad.idcli = idcl.Text;
                    ad.codeR = trvc.Text;
                    ad.typeOfpaid = tpop.Text;
                    ad.ShowDialog();
                   
                }
            }
            if (saveR.Text == "Update")
            {
                string req = "UPDATE reservation set idClient=@idclient,codeVoyage=@trvlc,typeOfpaid=@typeofpaid,reste=0 WHERE idReservation=@id";
                string sql = "datasource=localhost;port=3306;username=root;password=narivo2777;database=railway";
                MySqlConnection conn = new MySqlConnection(sql);
                
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(req, conn);
                    cmd.Parameters.Add("@idclient", MySqlDbType.VarChar).Value = idcl.Text;
                    cmd.Parameters.Add("@trvlc", MySqlDbType.VarChar).Value = trvc.Text;
                    cmd.Parameters.Add("@typeofpaid", MySqlDbType.VarChar).Value = tpop.Text;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = ide;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error!" + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                saveR.Text = "Suivant";
                tpop.Text = string.Empty;
                idcl.Text = string.Empty;
                trvc.Text = string.Empty;
                Display();
            }
            if (saveR.Text == "PDF")
            {
                MessageBox.Show("PDF bien généré","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string outfile = Environment.CurrentDirectory + "/Facture.pdf";
                iTextSharp.text.Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(outfile, FileMode.Create));

                // Ouvrir le document avant d'ajouter du contenu
                doc.Open();

                // Couleurs
                BaseColor blue = new BaseColor(0, 75, 155);

                // Police
                Font policetitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
                Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f);


                // Ajouter le contenu au document
                Paragraph para = new Paragraph("Reçue\n\n", policetitre);
                para.Alignment = Element.ALIGN_CENTER;
                doc.Add(para);

                try
                {

                    string sql = "datasource=localhost;port=3306;username=root;password=narivo2777;database=railway";

                    using (MySqlConnection conn = new MySqlConnection(sql))
                    {
                        conn.Open();
                       

                        //string query = "select c.nameCli,c.contactCli,t.codeTrain,t.dateV,t.coastV,t.sourceV,t.destinationV,r.typeOfpaid,r.reste from client c,reservation r,travel t where c.idCli=r.idClient and t.codeV=r.codeVoyage and idReservation=45";
                        string query = "SELECT nameCli,contactCli,typeOfpaid,reste,coastV,sourceV,dateV,destinationV,codeTrain from client,reservation,travel where client.idCli=reservation.idClient and reservation.codeVoyage=travel.codeV and idReservation=@CODE";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.Add("@CODE", MySqlDbType.VarChar).Value = CODE.Text;

                            using (MySqlDataReader reader = cmd.ExecuteReader())

                                while (reader.Read())
                                {

                                    // string id = reader.GetString("idCli");
                                    string nom = reader.GetString("nameCli");
                                    string contact = reader.GetString("contactCli");
                                    string codeTrains = reader.GetString("codeTrain");
                                    DateTime dateVoyage = reader.GetDateTime("dateV");
                                    string dateVoyageFormatted = dateVoyage.ToString("yyyy-MM-dd");

                                    int coast = reader.GetInt32("coastV");
                                    string source = reader.GetString("sourceV");
                                    string dest = reader.GetString("destinationV");
                                    string type = reader.GetString("typeOfpaid");
                                    int rest = reader.GetInt32("reste");
                                    int valeur = coast - rest;




                                    Paragraph info = new Paragraph($"Date du voyage:  {dateVoyageFormatted}  \n\nNumero_du_train:  {codeTrains}\n\nDepart: {source}\n\n Destination: {dest}\n\nNom du Client:  {nom}\n\n Contact:  {contact}\n\nFrais:  {coast}\n\nPayment:  {type}/\t\t Montant :{valeur}\t\t/ Reste à payer:  {rest}", policeTh); //+
                                                                                                                                                                                                                                                                                                                             //  $"Numero_du_train:{codeTrains}\n,policeTh");// +
                                                                                                                                                                                                                                                                                                                             //$"Date de voyage:  \n Depart: {source} \n Destination: {dest} \n Frais: {coast}\n Paiment: {type}\n" +
                                                                                                                                                                                                                                                                                                                             //$"Reste à payer: {rest}", policeTh);
                                    info.Alignment = Element.ALIGN_LEFT;
                                    doc.Add(info);


                                    Paragraph testPara = new Paragraph("Ceci est un test.", policeTh);
                                    doc.Add(testPara);

                                }
                        }
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Erreur : " + ex.Message);
                }

                doc.Close();


                trvc.Text = idcl.Text = tpop.Text = string.Empty;
                CODE.Text = "Refresh";
                saveR.Text = "Suivant";
                //Display();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    

    private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reservation_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reservation res = new reservation();
            res.Show();
            this.Hide();
          
        }

        private void dataGridView50_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
                saveR.Text = "Update";
                ide = dataGridView50.Rows[e.RowIndex].Cells[3].Value.ToString();
                idcl.Text = dataGridView50.Rows[e.RowIndex].Cells[4].Value.ToString();
                trvc.Text = dataGridView50.Rows[e.RowIndex].Cells[5].Value.ToString();
                tpop.Text  = dataGridView50.Rows[e.RowIndex].Cells[6].Value.ToString();
                
                
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure to delete it?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClassDbReservation.deleteReservation(dataGridView50.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
            }
            if (e.ColumnIndex == 2)
            {
                saveR.Text = "PDF";
                CODE.Text = dataGridView50.Rows[e.RowIndex].Cells[3].Value.ToString();

                idcl.Text = dataGridView50.Rows[e.RowIndex].Cells[4].Value.ToString();
                trvc.Text = dataGridView50.Rows[e.RowIndex].Cells[5].Value.ToString();

                tpop.Text = dataGridView50.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string outfile = Environment.CurrentDirectory + "/Facture.pdf";
            iTextSharp.text.Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(outfile, FileMode.Create));

            // Ouvrir le document avant d'ajouter du contenu
            doc.Open();

            // Couleurs
            BaseColor blue = new BaseColor(0, 75, 155);

            // Police
            Font policetitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);
            Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f);


            // Ajouter le contenu au document
            Paragraph para = new Paragraph("Reçue\n\n", policetitre);
            para.Alignment = Element.ALIGN_CENTER;
            doc.Add(para);

            try
            {

                string sql = "datasource=localhost;port=3306;username=root;password=narivo2777;database=railway";

                using (MySqlConnection conn = new MySqlConnection(sql))
                {
                    conn.Open();


                    //string query = "select c.nameCli,c.contactCli,t.codeTrain,t.dateV,t.coastV,t.sourceV,t.destinationV,r.typeOfpaid,r.reste from client c,reservation r,travel t where c.idCli=r.idClient and t.codeV=r.codeVoyage and idReservation=45";
                    string query = "SELECT nameCli,contactCli,typeOfpaid,reste,coastV,sourceV,dateV,destinationV,codeTrain from client,reservation,travel where client.idCli=reservation.idClient and reservation.codeVoyage=travel.codeV and idReservation=48";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {


                        using (MySqlDataReader reader = cmd.ExecuteReader())

                            while (reader.Read())
                            {

                               // string id = reader.GetString("idCli");
                                string nom = reader.GetString("nameCli");
                               string contact = reader.GetString("contactCli");
                               string codeTrains = reader.GetString("codeTrain");
                                DateTime dateVoyage = reader.GetDateTime("dateV");
                                string dateVoyageFormatted = dateVoyage.ToString("yyyy-MM-dd");

                                int coast = reader.GetInt32("coastV");
                                 string source = reader.GetString("sourceV");
                                string dest = reader.GetString("destinationV");
                                 string type = reader.GetString("typeOfpaid");
                                 int rest = reader.GetInt32("reste");





                                Paragraph info = new Paragraph($"Date du voyage:  {dateVoyageFormatted}  \n\nNumero_du_train:  {codeTrains}\n\nDepart: {source}\n\n Destination: {dest}\n\nNom du Client:  {nom}\n\n Contact:  {contact}\n\nFrais:  {coast}\n\nPayment:  {type}\t\t/ Reste à payer:  {rest}", policeTh); //+
                                  //  $"Numero_du_train:{codeTrains}\n,policeTh");// +
                                                                                                                                                       //$"Date de voyage:  \n Depart: {source} \n Destination: {dest} \n Frais: {coast}\n Paiment: {type}\n" +
                                                                                                                                                       //$"Reste à payer: {rest}", policeTh);
                                info.Alignment = Element.ALIGN_LEFT;
                                doc.Add(info);


                                Paragraph testPara = new Paragraph("Ceci est un test.", policeTh);
                                doc.Add(testPara);

                            }
                    }
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }

            doc.Close();
        }

        private void idcl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

        // ClassReservation rs = new ClassReservation(trvc.Text,idcl.Text,tpop.Text);
        // ClassDbReservation.addNewReservation(rs);
        //clear();
    }
    
