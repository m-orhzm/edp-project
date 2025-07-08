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
            // TODO: This line of code loads data into the 'eDP_DatabaseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.eDP_DatabaseDataSet.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
