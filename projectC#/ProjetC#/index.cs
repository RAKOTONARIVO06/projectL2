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
    public partial class index : Form
    {
        AddClient form;
        public index()
        {
            InitializeComponent();
            form = new AddClient(this);
        }

       

        public void Display()
        {
            ClassDbClient.DisplayAndSearch("SELECT idCli,nameCli,contactCli from client", dataGridView3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.clear();
            form.addInfo();
            form.ShowDialog();
        }

        private void index_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClassDbClient.DisplayAndSearch("SELECT idCli,nameCli,contactCli from client WHERE nameCli  LIKE '%" + txtSearch.Text+ "%' OR  contactCli LIKE '%" + txtSearch.Text + "%' ", dataGridView3);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.clear();
                form.ID = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.NAME = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.CONTACT = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you sure to delete it?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClassDbClient.deleteClient(dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display(); 
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
