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
    public partial class AddTrain : Form
    {
        private readonly Train _parent;

        public string id, capacity, status;
        public AddTrain(Train parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void updateInfo()
        {
            idT.Text = id;
            capacityT.Text = capacity;
            if (status == "Available") 
            {
                available.Checked = true;
            }
            else
            {
                notAvailable.Checked = true;
            }
            saveT.Text = "Update";
            title.Text = "Enter the new Informations";
        }
        public void addInfo()
        {

            title.Text = "Add a new Train";
            saveT.Text = "SAVE";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clear()
        {
            idT.Text = capacityT.Text = string.Empty;
            available.Checked = notAvailable.Checked = false;
        }

        private void saveP_Click(object sender, EventArgs e)
        {
            string statusTrain="";
            if (idT.Text == "")
            {
                MessageBox.Show("Fill in the Train number Case", "Information", MessageBoxButtons.OK);
                return;
            }
            if (capacityT.Text == "")
            {
                MessageBox.Show("Fill in the capacity of the train  Case", "Information", MessageBoxButtons.OK);
                return;
            }
            if (available.Checked == true)
            {
                statusTrain = "Available";
            }
            else if(notAvailable.Checked == true)
            {
                statusTrain = "Not Available";
            }
            else
            {
                MessageBox.Show("The button radio is obligary!","Information",MessageBoxButtons.OK);
                return;
            }
            if(saveT.Text == "SAVE")
            {
                ClassTrain tr = new ClassTrain(idT.Text.Trim(), capacityT.Text.Trim(), statusTrain);
                ClassDbTrain.AddNewTrain(tr);
                clear();
                
            }
            if(saveT.Text == "Update")
            {
                if(idT.Text == id)
                {
                    ClassTrain tr = new ClassTrain(idT.Text.Trim(), capacityT.Text.Trim(), statusTrain);
                    ClassDbTrain.updateTrain(tr);
                    clear();

                }
                else
                {
                    MessageBox.Show("You haven't a privilege for moving the train number", "Information", MessageBoxButtons.OK);
                    idT.Text = id;
                }
                
            }
            _parent.Display();
        }
    }
}
