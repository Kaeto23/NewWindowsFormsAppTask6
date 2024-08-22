using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWindowsFormsAppTask6
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Text = "";

            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
            }
        }

        private void txtemailaddress_Enter(object sender, EventArgs e)
        {
            if (txtemailaddress.Text == "Email Address")
            {
                txtemailaddress.Text = "";

            }
        }

        private void txtemailaddress_Leave(object sender, EventArgs e)
        {
            if (txtemailaddress.Text == "")
            {
                txtemailaddress.Text = "Email Address";
            }

        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
            }
        }

        private void txtconfirmpassword_Enter(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text == "Confirm Password")
            {
                txtconfirmpassword.Text = "";
            }
        }

        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text == "")
            {
                txtconfirmpassword.Text = "Confirm Password";
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Name")
            {
                txtname.Text = "";
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Name";
            }
        }

        private void txtphone_Enter(object sender, EventArgs e)
        {
            if (txtphone.Text == "Phone")
            {
                txtphone.Text = "";
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            if (txtphone.Text == "")
            {
                txtphone.Text = "Phone";
            }
        }

        private void txtfamilyname_Enter(object sender, EventArgs e)
        {
            if (txtfamilyname.Text == "Family Name")
            {
                txtfamilyname.Text = "";
            }
        }

        private void txtfamilyname_Leave(object sender, EventArgs e)
        {
            if (txtfamilyname.Text == "")
            {
                txtfamilyname.Text = "Family Name";
            }
        }

        private void txtmobile_Enter(object sender, EventArgs e)
        {
            if (txtmobile.Text == "Mobile")
            {
                txtmobile.Text = "";
            }
        }

        private void txtmobile_Leave(object sender, EventArgs e)
        {
            if (txtmobile.Text == "")
            {
                txtmobile.Text = "Mobile";
            }
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            if (txtdate.Text == "Date")
            {
                txtdate.Text = "";
            }
        }

        private void txtdate_Leave(object sender, EventArgs e)
        {
            if (txtdate.Text == "")
            {
                txtdate.Text = "Date";
            }
        }

        private void txtbirthplace_Enter(object sender, EventArgs e)
        {
            if (txtbirthplace.Text == "Birth Place")
            {
                txtbirthplace.Text = "";
            }
        }

        private void txtbirthplace_Leave(object sender, EventArgs e)
        {
            if (txtbirthplace.Text == "")
            {
                txtbirthplace.Text = "Birth Place";
            }
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void txtname_Enter_1(object sender, EventArgs e)
        {
            if (txtname.Text == "Name")
            {
                txtname.Text = "";
            }
        }

    }
}