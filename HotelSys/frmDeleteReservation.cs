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
    public partial class frmDeleteRes : Form
    {
        private Booking aBooking = new Booking();
        public frmDeleteRes()
        {
            InitializeComponent();
        }

        private void frmDeleteRes_Load(object sender, EventArgs e)
        {
            loadReservations();
        }

        private void cboReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReservations.SelectedIndex == -1)
            return;
            aBooking.getBookingId(Convert.ToInt32(cboReservations.Text.Substring(0, 3)));
        }

        private void loadReservations()
        {
            
            DataSet ds = Booking.getSummaryBookings();

            cboReservations.Items.Clear();

            for (int i = 0; i < ds.Tables["WS"].Rows.Count; i++)
            cboReservations.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
            " " + ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString() + " " 
            + ds.Tables[0].Rows[i][3].ToString() + " ");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            aBooking.deleteBooking();
            MessageBox.Show("Reservation has been deleted", "Success!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboReservations.SelectedIndex = -1;
            loadReservations();
        }
    }
}
