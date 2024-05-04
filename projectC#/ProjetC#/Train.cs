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
    public partial class Train : Form
    {
        AddTrain form;
        public Train()
        {
            InitializeComponent();
            form = new AddTrain(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.clear();
            form.addInfo();
            form.ShowDialog();
        }

        public void Display()
        {
            ClassDbClient.DisplayAndSearch("SELECT numTrain,capacityTrain,statusTrain from train", dataGridView4);
        }

        private void Train_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.clear();
                form.id = dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.capacity = dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.status = dataGridView4.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.updateInfo();
                form.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure to delete it?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClassDbTrain.deleteTrain(dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
