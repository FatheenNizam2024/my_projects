using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentManagementSystem
{
    public partial class frmSMS : Form
    {
        public frmSMS()
        {
            InitializeComponent();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            this.Hide();
            frmStudent.ShowDialog();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher();
            this.Hide();
            frmTeacher.ShowDialog();
        }

        private void btnsubjects_Click(object sender, EventArgs e)
        {
            frmSubjects frmSubjects = new frmSubjects();
            this.Hide();
            frmSubjects.ShowDialog();
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            frmPayments frmPayments = new frmPayments();
            this.Hide();
            frmPayments.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frmLogin = new frmlogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void frmSMS_Load(object sender, EventArgs e)
        {

        }
    }
}
