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
    public partial class frmUpdateClient : Form
    {
        private Client aClient = new Client();
       
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            loadClients();
            grpClient.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            txtClientId.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpClient.Visible = true;

            if (cboClient.SelectedIndex == -1)
                return;

            aClient.getClient(Convert.ToInt32(cboClient.Text.Substring(0, 3)));

            txtClientId.Text = aClient.getClientId().ToString();
            txtFirstName.Text = aClient.getFirstName().ToString();
            txtLastName.Text = aClient.getLastName().ToString();
            txtEmail.Text = aClient.getEmail().ToString();
            txtPhone.Text = aClient.getPhone().ToString();

            grpClient.Visible = true;
        }

        private void loadClients()
        {
            DataSet ds = Client.getSummaryClients();

            cboClient.Items.Clear();

            for(int i = 0; i < ds.Tables["WS"].Rows.Count; i++)
                cboClient.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                " " + ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString() + " " + ds.Tables[0].Rows[i][3].ToString());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            double numbers = 1234567890;
            bool result1 = double.TryParse(txtPhone.Text, out numbers);

            if (txtClientId.Text.Equals(""))
            {
                MessageBox.Show("Client Id must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientId.Focus();
                return;
            }

            else if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientId.Focus();
                return;
            }
            else if (txtLastName.Text.Equals(""))
            {
                MessageBox.Show("Last name must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientId.Focus();
                return;
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Client Email must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClientId.Focus();
                return;
            }

            else if (!result1 == true)
            {

                MessageBox.Show("Phone Number is not a digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                aClient.setFirstName((txtFirstName.Text));
                aClient.setLastName(txtLastName.Text);
                aClient.setEmail(txtEmail.Text);
                aClient.setPhone(txtPhone.Text);

                aClient.updateClient();

                MessageBox.Show("Client has been Updated", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpClient.Visible = false;
                loadClients();

                cboClient.SelectedIndex = -1;
                txtClientId.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtFirstName.Clear();
            }        
        }
    }
}