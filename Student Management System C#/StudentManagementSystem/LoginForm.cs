using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "admin" && txtpassword.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                frmSMS frmSMS = new frmSMS();
                this.Hide();
                frmSMS.ShowDialog();
            }
            else
            {
                MessageBox.Show("incorrect username or password");
                txtusername.Focus();

            }
                    
            
           
            


        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good BYE");
            Application.Exit();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
