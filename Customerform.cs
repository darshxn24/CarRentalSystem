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
namespace d2_rentals
{
    public partial class Customerform : Form
    {
        public Customerform()
        {
            InitializeComponent();
        }
        SqlConnection db2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Web Development\Final year project\d2 rentals\d2 rentals\d2db.mdf;Integrated Security=True");
        private void populate()
        {
            string query2 = "Select * from Customertbl";
            SqlDataAdapter da = new SqlDataAdapter(query2, db2);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerDatagrid.DataSource = ds.Tables[0];
        }
        private void ADDuser_Click(object sender, EventArgs e)
        {
            if (Custid.Text == "" || CustName.Text == "" || Address.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db2.Open();
                    string query = "insert into Customertbl Values(" + Custid.Text + ",'" + CustName.Text + "','" + Address.Text + "','" + Phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, db2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    db2.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void CustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EDITuser_Click(object sender, EventArgs e)
        {
            if (Custid.Text == "" || CustName.Text == "" || Address.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db2.Open();
                    string query2 = "update Customertbl set CustName='" + CustName.Text + "',Custadd='" + Address.Text + "',Phone=" + Phone.Text + " where CustID ='" + Custid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query2, db2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
                    db2.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void DELETEuser_Click(object sender, EventArgs e)
        {
            if (Custid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db2.Open();
                    string query2 = "delete from Customertbl where CustID='" + Custid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query2, db2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    db2.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void BACKuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm home = new HomeForm();
            home.Show();
        }
    }
}
