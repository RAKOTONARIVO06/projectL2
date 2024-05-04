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
    public partial class AddClient : Form
    {
        private readonly index _parent;


        public string ID, NAME, CONTACT;
        public AddClient(index parent)
        {
            InitializeComponent();

            _parent = parent;
        }
        public void UpdateInfo()
        {
            id.Text = ID;
            nameP.Text = NAME;
            contactP.Text = CONTACT;
            title.Text = "Update Passenger";
            saveP.Text = "UPDATE";

        }
        public void addInfo()
        {
            
            title.Text = "Add a new Client";
            saveP.Text = "SAVE";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            id.Text = nameP.Text = contactP.Text = string.Empty;
        }

        public void save_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || nameP.Text == "" || contactP.Text == "")
            {
                MessageBox.Show("Fill in all the case");
                return;
            }
            else
            {
                if (nameP.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Name Incorrect (>3)");
                    return;
                }
                if (contactP.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Phone Mobile incorrect (<11)");
                    return;
                }
                if (saveP.Text == "SAVE")
                {
                    ClassClient clt = new ClassClient(id.Text.Trim(), nameP.Text.Trim(), contactP.Text.Trim());
                    ClassDbClient.AddClient(clt);

                    clear();
                }
                if (saveP.Text == "UPDATE")
                {
                    if (id.Text == ID)
                    {
                        ClassClient clt = new ClassClient(id.Text.Trim(), nameP.Text.Trim(), contactP.Text.Trim());
                        ClassDbClient.updateClient(clt, id.Text.Trim());
                        clear();
                    }

                    else
                    {
                        MessageBox.Show("You haven't a privilege for moving the Client number", "Information", MessageBoxButtons.OK);
                        id.Text = ID;


                    }
                    
                }
                _parent.Display();
            }
        }
    }
}
