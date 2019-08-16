using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_App
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void OrderFormBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.producInfoForm.Show();
        }

        private void OrderFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            priceDataLabel.Text = Program.product.cost.ToString();
            var tax = Program.product.cost * (decimal)0.13;
            taxDataLabel.Text = tax.ToString();
            var total = tax + Program.product.cost;
            totalDataLabel.Text = total.ToString();
        }
    }
}
