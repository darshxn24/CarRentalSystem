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
    public partial class Rentalform : Form
    {
        public Rentalform()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Web Development\Final year project\d2 rentals\d2 rentals\d2db.mdf;Integrated Security=True");
        private void fillcombo()
        {
            db.Open();
            string query = "select  regnum from Carstbl";
            SqlCommand order = new SqlCommand(query, db);
            SqlDataReader read;
            read = order.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("regnum", typeof(string));
            table.Load(read);
            regbox.ValueMember = "regnum";
            regbox.DataSource = table;
            db.Close();
        }
        private void fillCustomer()
        {
            db.Open();
            string query = "select  CustID from Customertbl";
            SqlCommand order = new SqlCommand(query, db);
            SqlDataReader read;
            read = order.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("CustID", typeof(string));
            table.Load(read);
            custbox.ValueMember = "CustID";
            custbox.DataSource = table;
            db.Close();
        }

        private void lets_Click(object sender, EventArgs e)
        {
            
        }

        private void labelReturn_Click(object sender, EventArgs e)
        {

        }

        private void regbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void fetchCustName()
        {
            db.Open();
            string query = "select * from Customertbl where CustID=" +custbox.SelectedValue.ToString()+ "";
            SqlCommand order = new SqlCommand(query, db);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(order);
            da.Fill(table);
            foreach(DataRow dr in table.Rows)
            {
                Cname.Text = dr["CustName"].ToString();
            }
            db.Close();

        }
        private void populate()
        {

            string query = "Select * from Rentaltbl";
            SqlDataAdapter da = new SqlDataAdapter(query, db);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Rentalgrid.DataSource = ds.Tables[0];

        }
        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void regbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void Rentalform_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillCustomer();
            populate();
        }

        private void custbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchCustName();
        }

        private void ADDuser_Click(object sender, EventArgs e)
        {
            if (RRentid.Text == "" || Cname.Text == "" || Renttb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "insert into Rentaltbl Values(" + RRentid.Text + ",'" + regbox.SelectedValue.ToString() + "','" + Cname.Text + "','" + rentdatecldr.Text + "','" + returndatecldr.Text + "',"+Renttb.Text+")";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Rented");
                    db.Close();
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

        private void DELETEuser_Click(object sender, EventArgs e)
        {
            if (RRentid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "delete from Carstbl where RentId=" + RRentid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
                    db.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (RRentid.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "delete from Rentaltbl where RentId='" + RRentid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental Deleted Successfully");
                    db.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
}
