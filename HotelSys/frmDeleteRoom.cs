using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceSYS_Prototype
{
    public partial class frmDeleteRoom : Form
    {
        private Room aRoom = new Room();

        public frmDeleteRoom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDeleteRoom_Load_1(object sender, EventArgs e)
        {
            loadRooms();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRooms.SelectedIndex == -1)
            return;
            aRoom.getRoomNumber(Convert.ToInt32(cboRooms.Text.Substring(0, 3)));
        }

        private void loadRooms()
        {
            DataSet ds = Room.getSummaryRooms();

            cboRooms.Items.Clear();

            for (int i = 0; i < ds.Tables["WS"].Rows.Count; i++)
                cboRooms.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') +
                    " " + ds.Tables[0].Rows[i][3].ToString() + " " );
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            
            if(cboRooms.SelectedIndex == -1)
            {
                MessageBox.Show("No room selected", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (Room.checkIfReserved(Convert.ToInt32(cboRooms.Text.Substring(0, 3))) == true)
            {
                MessageBox.Show("Room number is registered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                aRoom.deleteRoom();
                MessageBox.Show("Room has been Deleted", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboRooms.SelectedIndex = -1;
                loadRooms();
            }
        }
    }
}
