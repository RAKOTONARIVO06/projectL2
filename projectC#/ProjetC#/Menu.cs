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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Train tr = new Train();
            tr.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Train tr = new Train();
            tr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            index tr = new index();
            tr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            index tr = new index();
            tr.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            voyage tr = new voyage();
            tr.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            voyage tr = new voyage();
            tr.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            reservation res = new reservation();
            res.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            reservation res = new reservation();
            res.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
