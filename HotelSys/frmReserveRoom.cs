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
    public partial class frmReserveRoom : Form
    {
        public frmReserveRoom()
        {
            InitializeComponent();
            txtBookingId.Text = Booking.getNextBookingId().ToString();
        }

        private void frmReserveRoom_Load(object sender, EventArgs e)
        {
            cboTime.Items.Add("09:00-11:30");
            cboTime.Items.Add("12:00-14:30");
            cboTime.Items.Add("15:00-17:30");
            cboTime.Items.Add("18:00-20:30");
            cboTime.Items.Add("21:00-23:30");
            Room.loadRoomNumbers(cboRooms);
            Client.loadClients(cboClient);
            dtTimePicker.MinDate = DateTime.Now;
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (cboTime.Text.Equals(""))
            {
                MessageBox.Show("Time must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTime.Focus();
                return;
            }

            else if (cboRooms.Text.Equals(""))
            {
                MessageBox.Show("Room Number must be selected", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRooms.Focus();
                return;
            }

            else if(Booking.isReserved(dtTimePicker.Text, cboTime.Text, Convert.ToInt32(cboRooms.Text)) == true)
            {
                MessageBox.Show("Reservation already exists", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(cboClient.Text.Equals(""))
            {
                MessageBox.Show("Client ID must be selected", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClient.Focus();
                return;
            }
            
            else
            {
                int cost = Booking.generateCost(cboTime.Text);            

                Booking aBooking = new Booking(Convert.ToInt32(txtBookingId.Text), Convert.ToInt32(cboRooms.Text), Convert.ToInt32(cboClient.Text), dtTimePicker.Text, cboTime.Text, cost);

                aBooking.addBooking();

                MessageBox.Show("Room has been reserved", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("The cost of entry per person is €" + cost, "Fee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookingId.Text = Booking.getNextBookingId().ToString();

                cboClient.SelectedIndex = -1;
                cboRooms.SelectedIndex = -1;
                cboTime.SelectedIndex = -1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            txtBookingId.ReadOnly = true;
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBooking_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
