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
    public partial class AddTravel : Form
    {
        public string CDV, COMBOBOX, SRC, DST;
        public int TRV;
        public DateTime DTV;
        public AddTravel()
        {
            InitializeComponent();
            showAllowTrain();
        }

        public void updateInfo()
        {
            cdv.Text = CDV;
            comboBox.Text = COMBOBOX;
            src.Text = SRC;
            dst.Text = DST;

            trv.Text = TRV.ToString();
            dtv.Text = DTV.ToString();
            title34.Text = "Update the last travel";
            saveT.Text = "Update";


        }
        public void addInfo()
        {

            title34.Text = "Add a new travel";
            saveT.Text = "SAVE";

        }
        private void idT_TextChanged(object sender, EventArgs e)
        {

        }

        private void available_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            //RESTE A FAIRE
            string trav = trv.Text;
            int.TryParse(trav, out int trvCoast);
            cdv.Text = comboBox.Text = src.Text = dst.Text = string.Empty;
            trv.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void showAllowTrain()
        {
            string sql1 = "SELECT numTrain FROM train WHERE statusTrain='Available' ";
            string sql = "server=localhost; port=3306; username=root; password=narivo2777; database=railway";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql1, con);

                MySqlDataReader rdr;

                rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                comboBox.Items.Clear();

                dt.Columns.Add("numTrain", typeof(String));


                dt.Load(rdr);

                comboBox.DisplayMember = "numTrain";

                comboBox.DataSource = dt;

                comboBox.ValueMember = "numTrain";

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MYSQL Connection \n" + ex.Message);
            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveT_Click(object sender, EventArgs e)
        {
            if (cdv.Text == "")
            {
                MessageBox.Show("the  travel code is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (dtv.Text == "")
            {
                MessageBox.Show("the travel date is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (comboBox.Text == "")
            {
                MessageBox.Show("the  travel code Train is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (src.Text == "")
            {
                MessageBox.Show("the travel source is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (dst.Text == "")
            {
                MessageBox.Show("the travel destination is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (trv.Text == "")
            {
                MessageBox.Show("the  travel coast is obligatory!", "Information", MessageBoxButtons.OK);
                return;
            }
            if (saveT.Text == "SAVE")
            {
                // ON vas lle transformer en entier
                string trav = trv.Text;
                int.TryParse(trav, out int trvCoast);

                //transformation en type DateTime
                DateTime dateTime = dtv.Value;

                ClassTravel ve = new ClassTravel(cdv.Text, dateTime, comboBox.Text, src.Text, dst.Text, trvCoast);
                ClassDbVoyage.AddNewTravel(ve);
                clear();
            }

            if (saveT.Text == "Update")
            {
                string trav = trv.Text;
                int.TryParse(trav, out int trvCoast);

                //transformation en type DateTime
                DateTime dateTime = dtv.Value;
                ClassTravel ve = new ClassTravel(cdv.Text, dateTime, comboBox.Text, src.Text, dst.Text, trvCoast);
                ClassDbVoyage.updateTravel(ve);
                clear();
            }

            
        }
    }
}
