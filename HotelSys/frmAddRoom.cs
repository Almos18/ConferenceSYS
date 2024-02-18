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
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent();
        }

        private void FrmRoomAdd_Load(object sender, EventArgs e)
        {
            Room.loadRoomTypes(cboRoomType);
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            double numbers = 1234567890;
            bool result1 = double.TryParse(txtRoomNo.Text, out numbers);
            bool result2 = double.TryParse(txtRoomCapacity.Text, out numbers);

            if (txtRoomNo.Text.Equals(""))
            {
                MessageBox.Show("Room number must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();
                return;
            }

            else if (txtRoomCapacity.Text.Equals(""))
            {
                MessageBox.Show("Room capacity must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomCapacity.Focus();
                return;
            }

            else if (cboRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Room Type must be selected", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRoomType.Focus();
                return;
            }
          
            else if (txtRoomName.Text.Equals(""))
            {
                MessageBox.Show("Room description must be entered", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomName.Focus();
                return;
            }
            
            else if (!result1 == true)
            {
                MessageBox.Show("Room number is not a digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();    
                return;
            }

            else if(!result2 == true)
            {
                MessageBox.Show("Capacity is not a digit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomCapacity.Focus();
                return;
            }

            else if (Room.roomNumberExists(int.Parse(txtRoomNo.Text)) == true)
            {
                MessageBox.Show("Room number already in use", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNo.Focus();
                return;
            }

            else
            {
                Room aRoom = new Room(Convert.ToInt32(txtRoomNo.Text), cboRoomType.Text.Substring(0,2), Convert.ToInt32(txtRoomCapacity.Text), txtRoomName.Text);
                
                aRoom.addRoom();

                MessageBox.Show("Room has been added", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRoomNo.Clear();
                txtRoomCapacity.Clear();
                txtRoomName.Clear();
                cboRoomType.SelectedIndex = -1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpRoom_Enter(object sender, EventArgs e)
        {

        }
    }
}