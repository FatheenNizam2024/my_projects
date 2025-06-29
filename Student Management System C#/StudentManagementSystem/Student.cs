using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Eventing.Reader;

namespace StudentManagementSystem
{

    public partial class frmStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-c93bn7j\sqlexpress;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand com;
        


        public frmStudent()
        {
            InitializeComponent();

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmSMS frmSMS = new frmSMS();
            this.Hide();
            frmSMS.ShowDialog();

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtclass.Text) || string.IsNullOrWhiteSpace(dtbdob.Text))
                {
                    MessageBox.Show("Record not added. Please fill in all required fields.");
                    txtstudent.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    txtclass.Clear();
                    dtbdob.Text = "";
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                }
                else
                {
                    dtbdob.Format = DateTimePickerFormat.Custom;
                    dtbdob.CustomFormat = "yyyy/MM/dd";
                    string Gender = "";
                    if (rdbmale.Checked)
                    {
                        Gender = "Male";
                    }
                    else if (rdbfemale.Checked)
                    {
                        Gender = "Female";

                    }
                     string sqlinsert = "insert into studentform(StudentID,Name,Address,ContactNo,DateofBirth,Gender,class)values('" + txtstudent.Text + "','" + txtname.Text + "','" + rtbaddress.Text + "','" + txtcontact.Text + "','" + dtbdob.Text + "', '" + Gender + "', '" + txtclass.Text + "')";
                     com = new SqlCommand(sqlinsert, con);
                     com.ExecuteNonQuery();
                     MessageBox.Show("Record added");
                     txtstudent.Clear();
                     txtname.Clear();
                     rtbaddress.Clear();
                     txtcontact.Clear();
                     txtclass.Clear();
                     dtbdob.Text = "";
                     rdbmale.Checked = false;
                     rdbfemale.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                {
                    if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtclass.Text) || string.IsNullOrWhiteSpace(dtbdob.Text))
                    {
                        MessageBox.Show("Record not updated.");
                        txtstudent.Clear();
                        txtname.Clear();
                        rtbaddress.Clear();
                        txtcontact.Clear();
                        txtclass.Clear();
                        dtbdob.Text = "";
                        rdbmale.Checked = false;
                        rdbfemale.Checked = false;

                    }
                    else
                    {

                        dtbdob.Format = DateTimePickerFormat.Custom;
                        dtbdob.CustomFormat = "yyyy/MM/dd";
                        string gender = "";
                        if (rdbmale.Checked)
                        {
                            gender = "Male";
                        }
                        else if (rdbfemale.Checked)
                        {
                            gender = "Female";
                        }
                        string sqlupdate = "update studentform set studentid = '" + txtstudent.Text + "', name = '" + txtname.Text + "', address = '" + rtbaddress.Text + "', contactno = '" + txtcontact.Text + "', DateofBirth = '" + dtbdob.Text + "', gender = '" + gender + "', class = '" + txtclass.Text + "' WHERE studentid = '" + txtstudent.Text + "'";
                        com = new SqlCommand(sqlupdate, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated");
                        txtstudent.Clear();
                        txtname.Clear();
                        rtbaddress.Clear();
                        txtcontact.Clear();
                        txtclass.Clear();
                        dtbdob.Text = "";
                        rdbmale.Checked = false;
                        rdbfemale.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstudent.Text))
            {
                MessageBox.Show("Please enter a student ID before searching.");
                return;
            }
            try
            {
                con.Open();
                string sqlselect = "select * from studentform where studentid = '" + txtstudent.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtstudent.Text = dr["studentid"].ToString();
                    txtname.Text = dr["name"].ToString();
                    rtbaddress.Text = dr["address"].ToString();
                    txtcontact.Text = dr["contactno"].ToString();
                    dtbdob.Text = dr["DateofBirth"].ToString();
                    txtclass.Text = dr["class"].ToString();
                    string gender = dr["gender"].ToString();
                    if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                    {
                        rdbmale.Checked = true;
                        rdbfemale.Checked = false;                        
                    }
                    else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
                    {
                        rdbmale.Checked = false;
                        rdbfemale.Checked = true;
                    }
                    else 
                    {
                        rdbmale.Checked = false;
                        rdbfemale.Checked = false;

                        MessageBox.Show("Record found");                    
                    }

                }
                else  
                {
                    MessageBox.Show("Record not found");
                    txtstudent.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    txtclass.Clear();
                    dtbdob.Text = "";
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtclass.Text) || string.IsNullOrWhiteSpace(dtbdob.Text))
                {
                    MessageBox.Show("No records found");
                }
                else
                {
                    string sqldelete = "delete from studentform where studentid = '" + txtstudent.Text + "'";
                    com = new SqlCommand(sqldelete, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    txtstudent.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    txtclass.Clear();
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                    dtbdob.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudent.Clear();
            txtname.Clear();
            rtbaddress.Clear();
            txtcontact.Clear();
            rdbmale.Checked = false;
            rdbfemale.Checked= false;
            dtbdob.Text = "";
            txtclass.Clear();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from studentform where studentid = '" + txtstudent.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                txtstudent.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from studentform";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                txtstudent.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
