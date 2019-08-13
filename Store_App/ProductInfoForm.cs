using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_App
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        private void ProductInfoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void ProductInfoCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            using (StreamReader inputStream = new StreamReader(
                 File.Open("Product.txt", FileMode.Open)))
            {
                Program.product.productID = short.Parse(inputStream.ReadLine());
                Program.product.cost = decimal.Parse(inputStream.ReadLine());
                Program.product.manufacturer = inputStream.ReadLine();
                Program.product.model = inputStream.ReadLine();
                Program.product.RAM_type = inputStream.ReadLine();
                Program.product.RAM_size = inputStream.ReadLine();
                Program.product.displaytype = inputStream.ReadLine();
                Program.product.screensize = inputStream.ReadLine();
                Program.product.resolution = inputStream.ReadLine();
                Program.product.CPU_Class = inputStream.ReadLine();
                Program.product.CPU_brand = inputStream.ReadLine();
                Program.product.CPU_type = inputStream.ReadLine();
                Program.product.CPU_speed = inputStream.ReadLine();
                Program.product.CPU_number = inputStream.ReadLine();
                Program.product.condition = inputStream.ReadLine();
                Program.product.OS = inputStream.ReadLine();
                Program.product.platform = inputStream.ReadLine();
                Program.product.HDD_size = inputStream.ReadLine();
                Program.product.HDD_speed = inputStream.ReadLine();
                Program.product.GPU_Type = inputStream.ReadLine();
                Program.product.optical_drive = inputStream.ReadLine();
                Program.product.Audio_type = inputStream.ReadLine();
                Program.product.LAN = inputStream.ReadLine();

                inputStream.Close();
                inputStream.Dispose();
            }

            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition.ToString();
            CostDataLabel.Text = Program.product.cost.ToString();

        }
    }
}
