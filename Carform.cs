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
    public partial class Carform : Form
    {
        public Carform()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Web Development\Final year project\d2 rentals\d2 rentals\d2db.mdf;Integrated Security=True");
        private void populate()
        {

            string query = "Select * from Carstbl";
            SqlDataAdapter da = new SqlDataAdapter(query, db);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ADDuser_Click(object sender, EventArgs e)
        {
            if (RegNum.Text == "" || Brand.Text == "" || Model.Text == "" || Price.Text == "" || Available.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "insert into Carstbl Values(" + RegNum.Text + ",'" + Brand.Text + "','" + Model.Text + "','" + Price.Text + "','" + Available.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Added");
                    db.Close();
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
            
        }

        private void DELETEuser_Click(object sender, EventArgs e)
        {
            if (RegNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "delete from Carstbl where regnum='" + RegNum.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Deleted Successfully");
                    db.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void EDITuser_Click(object sender, EventArgs e)
        {
            if (RegNum.Text == "" || Brand.Text == "" || Model.Text == "" || Price.Text == "" || Available.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    db.Open();
                    string query = "update Carstbl set brand='" + Brand.Text + "',model='" + Model.Text + "',available='" +Available.SelectedItem.ToString()+"',price="+Price.Text+" where regnum ='" + RegNum.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, db);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Successfully Updated");
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

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carform_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
