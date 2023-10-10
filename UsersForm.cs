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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Web Development\Final year project\d2 rentals\d2 rentals\d2db.mdf;Integrated Security=True");
        private void populate()
        {
           
            string query = "Select * from Usertbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDatagrid.DataSource = ds.Tables[0];
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADDuser_Click(object sender, EventArgs e)
        {
            if(Uid.Text == "" || Uname.Text == "" || Upassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Usertbl Values(" + Uid.Text + ",'" + Uname.Text + "','" + Upassword.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added");
                   Con.Close();
                    populate();

                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void EDITuser_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upassword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Usertbl set Uname='" + Uname.Text + "',Upass='" + Upassword.Text + "' where Id =" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated");
                    Con.Close();
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

        private void UserPanel_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void DELETEuser_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "") 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Usertbl where id=" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
