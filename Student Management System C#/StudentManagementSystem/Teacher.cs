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


namespace StudentManagementSystem
{
    public partial class frmTeacher : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=desktop-c93bn7j\sqlexpress;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand com;

        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            frmSMS frmSMS = new frmSMS();
            this.Hide();
            frmSMS.ShowDialog();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtteacher.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(dtbdob.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtclass.Text))
                {
                    MessageBox.Show("Record not added. Please fill in all required fields.");
                    txtteacher.Clear();
                    txtname.Clear();
                    dtbdob.Text = "";
                    rtbaddress.Clear();
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                    txtcontact.Clear();
                    txtclass.Clear();
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
                        string sqlinsert = "insert into teacherform(teacherID,name,DateofBirth,address,gender,contactno,class)values('" + txtteacher.Text + "','" + txtname.Text + "','" + dtbdob.Text + "','" + rtbaddress.Text + "','" + Gender + "','" + txtcontact.Text + "','" + txtclass.Text + "')";
                        com = new SqlCommand(sqlinsert, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record added");
                        txtteacher.Clear();
                        txtname.Clear();
                        dtbdob.Text = "";
                        rtbaddress.Clear();
                        rdbfemale.Checked = false;
                        rdbmale.Checked = false;
                        txtcontact.Clear();
                        txtclass.Clear();                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
            finally 
            { 
                con.Close();
            }

        }
        

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtteacher.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(dtbdob.Text) || string.IsNullOrWhiteSpace(txtclass.Text))
                {
                    MessageBox.Show("Record not updated");
                    txtteacher.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    dtbdob.Text = "";
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                    txtclass.Clear();
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
                        string sqlupdate = "update teacherform set teacherID = '" + txtteacher.Text + "', name = '" + txtname.Text + "', address = '" + rtbaddress.Text + "', contactno = '" + txtcontact.Text + "', DateofBirth = '" + dtbdob.Text + "', gender = '" + gender + "', class = '" + txtclass.Text + "' WHERE teacherID = '" + txtteacher.Text + "'";
                        com = new SqlCommand(sqlupdate, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Record Updated");
                        txtteacher.Clear();
                        txtname.Clear();
                        rtbaddress.Clear();
                        txtcontact.Clear();
                        dtbdob.Text = "";
                        rdbmale.Checked = false;
                        rdbfemale.Checked = false;
                        txtclass.Clear();
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

        private void btnview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtteacher.Text))
            {
                MessageBox.Show("Please enter a teacher ID before searching.");
                return;
            }
            try
            {
                con.Open();
                string sqlselect = "select * from teacherform where teacherID = '" + txtteacher.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com .ExecuteReader();
                if (dr.Read()) 
                {
                    txtteacher.Text = dr["teacherID"].ToString();
                    txtname.Text = dr["name"].ToString();
                    rtbaddress.Text = dr["address"].ToString();
                    txtcontact.Text = dr["contactno"].ToString();
                    dtbdob.Text = dr["DateofBirth"].ToString();
                    string gender = dr["gender"].ToString();
                    txtclass.Text = dr["class"].ToString();
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
                    txtteacher.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    dtbdob.Text = "";
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                    txtclass.Clear();
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
                if (string.IsNullOrWhiteSpace(txtteacher.Text) || string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(rtbaddress.Text) || string.IsNullOrWhiteSpace(txtcontact.Text) || string.IsNullOrWhiteSpace(txtclass.Text) || string.IsNullOrWhiteSpace(dtbdob.Text))
                {
                    MessageBox.Show("No records found");
                }
                else
                {
                    string sqldelete = "delete from teacherform where teacherid = '" + txtteacher.Text + "'";
                    com = new SqlCommand(sqldelete, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    txtteacher.Clear();
                    txtname.Clear();
                    rtbaddress.Clear();
                    txtcontact.Clear();
                    rdbmale.Checked = false;
                    rdbfemale.Checked = false;
                    dtbdob.Text = "";
                    txtclass.Clear();
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
        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtteacher.Clear();
            txtname.Clear();
            rtbaddress.Clear();
            txtcontact.Clear();
            rdbmale.Checked = false;
            rdbfemale.Checked = false;
            dtbdob.Text = "";
            txtclass.Clear();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from teacherform where teacherid = '" + txtteacher.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                txtteacher.Clear();
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
                string sqlselect = "select * from teacherform";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                txtteacher.Clear();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
