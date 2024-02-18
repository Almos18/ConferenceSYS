using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.ManagedDataAccess.Client;

namespace ConferenceSYS_Prototype
{
    public partial class frmMainMenu : Form
    {
       // OracleConnection conn = new OracleConnection(DBConnect.oraDB);
        public frmMainMenu()
        {
            InitializeComponent();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask user if they wish to exit

            DialogResult dialog1 = (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
               
            if(dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuRates_Click(object sender, EventArgs e)
        {

        }

        private void mnuReservations_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddRoom newTaskForm = new frmAddRoom();
            newTaskForm.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient newTaskForm = new frmAddClient();
            newTaskForm.ShowDialog();
        }

        private void deleteRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteRoom newTaskForm = new frmDeleteRoom();
            newTaskForm.ShowDialog();
        }

        private void bookRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserveRoom newTaskForm = new frmReserveRoom();
            newTaskForm.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void deleteReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteRes newTaskForm = new frmDeleteRes();
            newTaskForm.ShowDialog();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateClient newTaskForm = new frmUpdateClient();
            newTaskForm.ShowDialog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            

        }

        private void issueInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
