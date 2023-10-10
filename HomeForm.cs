using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d2_rentals
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carform car = new Carform();
            car.Show();
        }

        private void Customerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customerform customer = new Customerform();
            customer.Show();
        }

        private void Rentalbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rentalform rental = new Rentalform();
            rental.Show();
        }

        private void Usersbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm loginform = new loginForm();
            loginform.Show();
        }
    }
}
