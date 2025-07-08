using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblAurora_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            if (username == UserData.RegisteredUsername && password == UserData.RegisteredPassword)
            {
                MessageBox.Show("Login Successful! Welcome");

                Homepage homepageForm = new Homepage();
                homepageForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void bttnAdmin_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter Admin Password:", "Admin Access", "");

            if (input == "admin123")
            {
                MessageBox.Show("Admin Login Is Successful");
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Admin Password.");
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            FormSign_Up formSignUp = new FormSign_Up();
            formSignUp.Show();
        }
    }
}

