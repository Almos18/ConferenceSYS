using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceSYS_Prototype
{
    public partial class frmAddClient : Form
    {
        
        public frmAddClient()
        {
            InitializeComponent();
            txtClientId.Text = Client.getNextClientId().ToString();
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            txtClientId.ReadOnly = true;
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void Validate_Click(object sender, EventArgs e)
        {
            double numbers = 1234567890;
            bool result1 = double.TryParse(txtPhone.Text, out numbers);
            

            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            else if (!result1 == true)
            {

                MessageBox.Show("Phone Number is not a digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last name must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Client email must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }       

            else
            {
                Client aClient = new Client(Convert.ToInt32(txtClientId.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text);

                aClient.addClient();

                MessageBox.Show("Client has been added", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtLastName.Clear();
                txtEmail.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
                txtClientId.Text = Client.getNextClientId().ToString();

            }
        }       
    }
}
