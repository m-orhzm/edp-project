using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class AdminHistory : Form
    {
        public AdminHistory()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            this.Hide();
        }

        private void AdminHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDP_DatabaseDataSet2.Package' table. You can move, or remove it, as needed.
            this.packageTableAdapter.Fill(this.eDP_DatabaseDataSet2.Package);
            // TODO: This line of code loads data into the 'eDP_DatabaseDataSet1.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.eDP_DatabaseDataSet1.Discount);
            // TODO: This line of code loads data into the 'eDP_DatabaseDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.eDP_DatabaseDataSet.History);
        }

        private void ApplyFilters()
{
    string query = "SELECT * FROM History WHERE 1=1"; // Always true, allows dynamic appending

    if (!string.IsNullOrWhiteSpace(discountName.Text))
    {
        query += " AND Discount_Name LIKE @DiscountName";
    }

    if (pkgName.SelectedIndex != -1)
    {
        query += " AND pkg_name = @PkgName";
    }

    if (!string.IsNullOrWhiteSpace(userName.Text))
    {
        query += " AND Name LIKE @Username";
    }

    if (dateFilter.Checked) // Add a checkbox if you want to allow date filtering optionally
    {
        query += " AND CAST(date AS DATE) = @BookingDate";
    }

    using (SqlConnection conn = new SqlConnection("your_connection_string"))
    using (SqlCommand cmd = new SqlCommand(query, conn))
    {
        if (!string.IsNullOrWhiteSpace(discountName.Text))
        {
            cmd.Parameters.AddWithValue("@DiscountName", "%" + discountName.Text + "%");
        }

        if (pkgName.SelectedIndex != -1)
        {
            cmd.Parameters.AddWithValue("@PkgName", pkgName.SelectedItem.ToString());
        }

        if (!string.IsNullOrWhiteSpace(userName.Text))
        {
            cmd.Parameters.AddWithValue("@Username", "%" + userName.Text + "%");
        }

        if (dateFilter.Checked)
        {
            cmd.Parameters.AddWithValue("@BookingDate", dateFilter.Value.Date);
        }

        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        adapter.Fill(dt);
        dataGridView1.DataSource = dt;
    }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void discountName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyFilterBtn_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void clrFilterBtn_Click(object sender, EventArgs e)
        {
            discountName.SelectedIndex = -1;
            pkgName.SelectedIndex = -1;
            userName.Clear();
            dateFilter.Checked = false; // If you use it
        }
    }
}
