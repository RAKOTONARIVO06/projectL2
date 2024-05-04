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
    public partial class voyage : Form
    {
        AddTravel form;
        public voyage()
        {
            InitializeComponent();
            form = new AddTravel();
        }

        public void Display()
        {
            ClassDbVoyage.DisplayAndSearch("SELECT codeV,dateV,codeTrain,sourceV,destinationV,coastV from travel,train where travel.codeTrain=train.numTrain and statusTrain='Available'", dataGridView10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.clear();
            form.addInfo();
            form.ShowDialog();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void voyage_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.clear();
                form.CDV = dataGridView10.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateTime.TryParse(dataGridView10.Rows[e.RowIndex].Cells[3].Value.ToString(), out DateTime dateValue);
                form.DTV = dateValue;
                form.COMBOBOX = dataGridView10.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.SRC = dataGridView10.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.DST = dataGridView10.Rows[e.RowIndex].Cells[6].Value.ToString();
                int.TryParse(dataGridView10.Rows[e.RowIndex].Cells[7].Value.ToString(), out int a);
                form.TRV = a;
               
                form.updateInfo();
                form.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure to delete it?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ClassDbVoyage.deleteTravel(dataGridView10.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voyage vg = new voyage();
            vg.Show();
            this.Hide();
;        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
