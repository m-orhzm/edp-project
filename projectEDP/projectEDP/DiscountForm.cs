using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class DiscountForm : Form
    {
        private DataGridView dataGridView1;

        public DiscountForm()
        {
            InitializeComponent();
            InitializeCustomComponents(); // panggil method manual
        }

        private void InitializeCustomComponents()
        {
            this.dataGridView1 = new DataGridView();
            this.dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(this.dataGridView1);
            this.Load += new EventHandler(DiscountForm_Load); // trigger load form
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Database_edp;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Discount", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(); 
            homepage.Show();
        }
    }
}
