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
using System.Linq.Expressions;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class frmSubjects : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-c93bn7j\sqlexpress;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand com;
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            frmSMS frmSMS = new frmSMS();
            this.Hide();
            frmSMS.ShowDialog();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(cmbsid.Text) || string.IsNullOrWhiteSpace(cmbsname.Text) || string.IsNullOrWhiteSpace(txttid.Text) || string.IsNullOrWhiteSpace(txttname.Text) || string.IsNullOrWhiteSpace(cmbclass.Text))
                {
                    MessageBox.Show("Record not updated.");
                }
                else
                {
                    string sqlupdate = "update subjectform set subjectid = '" + cmbsid.Text + "', subjectname = '" + cmbsname + "', teacherid = '" + txttid.Text + "', teachername = '" + txttname.Text + "', class = '" + cmbclass.Text + "' WHERE subjectid = '" + cmbsid.Text + "'";
                    com = new SqlCommand(sqlupdate, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated");
                    cmbsid.Text = "";
                    cmbsname.Text = "";
                    txttid.Clear();
                    txttname.Clear();
                    cmbclass.Text = "";
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

        private void frmSubjects_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(cmbsid.Text) || string.IsNullOrWhiteSpace(cmbsname.Text) || string.IsNullOrWhiteSpace(txttid.Text) || string.IsNullOrWhiteSpace(txttname.Text) || string.IsNullOrWhiteSpace(cmbclass.Text))
                {
                    MessageBox.Show("Record not added. Please fill in all required fields.");
                }
                else
                {
                    string sqlinsert = "insert into subjectform(subjectid,subjectname,teacherid,teachername,class)values('" + cmbsid.Text + "','" + cmbsname.Text + "', '" + txttid.Text + "', '" + txttname.Text + "', '" + cmbclass.Text + "')";
                    com = new SqlCommand(sqlinsert, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record added");
                    cmbsid.Text = "";
                    cmbsname.Text = "";
                    txttid.Clear();
                    txttname.Clear();
                    cmbclass.Text = "";
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

        private void btnview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbsid.Text))
            {
                MessageBox.Show("Please enter a subjectID before searching.");
                return;
            }
            try
            {
                con.Open();
                string sqlselect = "select * from subjectform where subjectid = '" + cmbsid.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    cmbsid.Text = dr["subjectid"].ToString();
                    cmbsname.Text = dr["subjectname"].ToString();
                    txttid.Text = dr["teacherid"].ToString();
                    txttname.Text = dr["teachername"].ToString();
                    cmbclass.Text = dr["class"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                    cmbsid.Text = "";
                    cmbsname.Text = "";
                    txttid.Clear();
                    txttname.Clear();
                    cmbclass.Text = "";
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
                string sqldelete = "delete from subjectform where subjectid = '" + cmbsid.Text + "'";
                com = new SqlCommand(sqldelete, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                cmbsid.Text = "";
                cmbsname.Text = "";
                txttid.Clear();
                txttname.Clear();
                cmbclass.Text = "";
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
            cmbsid.Text = "";
            cmbsname.Text = "";
            txttid.Clear();
            txttname.Clear();
            cmbclass.Text = "";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from subjectform where subjectid = '" + cmbsid.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                cmbsid.Text = "";
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
                string sqlselect = "select * from subjectform";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                cmbsid.Text = "";
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
    }
}
