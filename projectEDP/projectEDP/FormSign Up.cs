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

            //if (string.IsNullOrWhiteSpace(email))
            //{
            //    MessageBox.Show("Email field is required");
            //    return;
            //}

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }


            //if (string.IsNullOrWhiteSpace(phone))
            //{
            //    MessageBox.Show("Phone field is required");
            //    return;
            //}

            if (!phone.All(char.IsDigit) || phone.Length < 10)
            {
                MessageBox.Show("Please insert 10 digit for number. THANK YOU!!");
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

            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\USER\SOURCE\REPOS\EDP-PROJECT.GIT\PROJECTEDP\PROJECTEDP\EDP_DATABASE.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Users (Name, Email, Phone, DOB, Gender, Username, Password) " +
                                   "VALUES (@Name, @Email, @Phone, @DOB, @Gender, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(DOB));
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("You successfully registered. THANK YOU");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();  
            loginForm.Show(); 

            this.Hide();
        }
    }
}

