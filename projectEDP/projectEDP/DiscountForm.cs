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
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDP_DatabaseDataSet1.Discount' table. You can move, or remove it, as needed.
            this.discountTableAdapter.Fill(this.eDP_DatabaseDataSet1.Discount);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();

            this.Hide();
        }
    }
}
