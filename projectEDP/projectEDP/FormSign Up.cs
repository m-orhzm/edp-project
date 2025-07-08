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
    public partial class FormSign_Up : Form
    {
        public FormSign_Up()
        {
            InitializeComponent();
        }

        private void bttnRegister_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string email = txtBoxEmail.Text;
            string phone = txtBoxPhone.Text;
            string DOB = dtpDOB.Text;
            string gender = cmBoxGender.Text;
            string username = txtBoxUsername2.Text;
            string password = txtBoxPassword2.Text;
            string confirm = txtBoxConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(DOB))
            {
                MessageBox.Show("Date Of Birth field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Gender field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username field is required");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password field is required");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Confirm Password field is required");
                return;
            }

            if (confirm != password)
            {
                MessageBox.Show("Password does not match. PLEASE TRY AGAIN");
                return;
            }

            // Save to DataStorage.cs
            UserData.RegisteredUsername = username;
            UserData.RegisteredPassword = password;

            MessageBox.Show("You successfully registered. THANK YOU");
            this.Close();
        }

    }
}

