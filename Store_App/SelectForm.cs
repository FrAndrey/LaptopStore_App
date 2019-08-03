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
using System.Diagnostics;

namespace Store_App
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            SqlConnection con = new SqlConnection();
           // con.ConnectionString = 
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.producInfoForm.Show();
        }

        private void DataGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  CurrentSelectionBox.Text = 

            var productList =
                from selectedProduct in dollarComputersDataSet.products
                select selectedProduct;

            foreach (var selectedProduct in productList.ToList())
            {
                CurrentSelectionBox.Text = ("Product Id: " + selectedProduct.productID 
                    + ", Product: " + selectedProduct.manufacturer + " " + selectedProduct.model
                    );
            }

        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
