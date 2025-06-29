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
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class frmPayments : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-c93bn7j\sqlexpress;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand com;
        public frmPayments()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            frmSMS frmSMS = new frmSMS();
            this.Hide();
            frmSMS.ShowDialog();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(cmbclass.Text) || string.IsNullOrWhiteSpace(cmbpaymethod.Text) || string.IsNullOrWhiteSpace(dtbdate.Text) || string.IsNullOrWhiteSpace(cmbpaytype.Text) || string.IsNullOrWhiteSpace(txtamount.Text))
                {
                    MessageBox.Show("Record not added. Please fill in all required fields.");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();
                }
                else
                {
                    string sqlinsert = "insert into paymentsform(studentid,class,paymentmethod,date,paymenttype,amount)values('" + txtstudent.Text + "', '" + cmbclass.Text + "', '" + cmbpaymethod.Text + "','" + dtbdate.Text + "', '" + cmbpaytype.Text + "', '" + txtamount.Text + "')";
                    com = new SqlCommand(sqlinsert, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record added");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(cmbclass.Text) || string.IsNullOrWhiteSpace(cmbpaymethod.Text) || string.IsNullOrWhiteSpace(dtbdate.Text) || string.IsNullOrWhiteSpace(cmbpaytype.Text) || string.IsNullOrWhiteSpace(txtamount.Text))
                {
                    MessageBox.Show("Record not updated.");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();
                }
                else
                {
                    string sqlupdate = "update paymentsform set studentid = '" + txtstudent.Text + "', class =  '" + cmbclass.Text + "', paymentmethod = '" + cmbpaymethod.Text + "', date = '" + dtbdate.Text + "', paymenttype = '" + cmbpaymethod.Text + "', amount = '" + txtamount.Text + "' WHERE studentid = '" + txtstudent.Text + "'";
                    com = new SqlCommand(sqlupdate, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Updated");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();
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
            if (string.IsNullOrWhiteSpace(txtstudent.Text))
            {
                MessageBox.Show("Please enter a student ID before searching.");
                return;
            }
            try
            {
                con.Open();
                string sqlselect = "select * from paymentsform where studentid = '" + txtstudent.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtstudent.Text = dr["studentid"].ToString();
                    cmbclass.Text = dr["class"].ToString();
                    cmbpaymethod.Text = dr["paymentmethod"].ToString();
                    dtbdate.Text = dr["date"].ToString();
                    cmbpaytype.Text = dr["paymenttype"].ToString();
                    txtamount.Text = dr["amount"].ToString();

                    MessageBox.Show("Record found");
                }
                else
                {
                    MessageBox.Show("Record not found");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close( );
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (string.IsNullOrWhiteSpace(txtstudent.Text) || string.IsNullOrWhiteSpace(cmbclass.Text) || string.IsNullOrWhiteSpace(cmbpaymethod.Text) || string.IsNullOrWhiteSpace(dtbdate.Text) || string.IsNullOrWhiteSpace(cmbpaytype.Text) || string.IsNullOrWhiteSpace(txtamount.Text))
                {
                    MessageBox.Show("No records found.");
                }
                else
                {
                    string sqldelete = "delete from paymentsform where studentid = '" + txtstudent.Text + "'";
                    com = new SqlCommand(sqldelete, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    txtstudent.Clear();
                    cmbclass.Text = "";
                    cmbpaymethod.Text = "";
                    dtbdate.Text = "";
                    cmbpaytype.Text = "";
                    txtamount.Clear();
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
            cmbclass.Text = "";
            cmbpaymethod.Text = "";
            dtbdate.Text = "";
            cmbpaytype.Text = "";
            txtamount.Clear();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from  paymentsform  WHERE studentid = '" + txtstudent.Text + "'";
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
                string sqlselect = "select * from paymentsform";
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
    }
}
