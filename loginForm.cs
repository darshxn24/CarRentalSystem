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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        SqlConnection db = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Documents\Web Development\Final year project\d2 rentals\d2 rentals\d2db.mdf;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void d2_Click(object sender, EventArgs e)
        {

        }

        private void Rentals_Click(object sender, EventArgs e)
        {

        }

        private void drive_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from Usertbl where Uname= '" + Usertb.Text + "' and Upass='" + pswtb.Text + "'";
            db.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable table = new DataTable();
            sda.Fill(table);
            if(table.Rows[0][0].ToString()== "1")
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            db.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clearlbl_Click(object sender, EventArgs e)
        {
            Usertb.Text= "";
            pswtb.Text = "";
        }
    }
}
