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
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductInfoBackButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide(); 
        }

        private void ProductInfoCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void LoadProduct(object sender, EventArgs e)
        {
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";


            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputStream = new StreamReader(
                    File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
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
                    Program.product.weight = inputStream.ReadLine();

                    inputStream.Close();
                    inputStream.Dispose();
                   
                }
                ProductInfoForm_Activated(sender, e);
            }
        }
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition.ToString();
            CostDataLabel.Text = $"{Program.product.cost:C2}";

            PlatformDataLabel.Text = Program.product.platform.ToString();
            OsDataLabel.Text = Program.product.OS.ToString();
            ModelDataLabel.Text = Program.product.model.ToString();
            ManufacturerDataLabel.Text = Program.product.manufacturer.ToString();

            MemoryDataLabel.Text = Program.product.RAM_size.ToString();
            CpuBrandDataLabel.Text = Program.product.CPU_brand.ToString();
            CpuTypeDataLabel.Text = Program.product.CPU_type.ToString();
            LcdSizeDataLabel.Text = Program.product.displaytype.ToString();
            CpuNumberDataLabel.Text = Program.product.CPU_number.ToString();
            CpuSpeedDataLabel.Text = Program.product.CPU_speed.ToString();
            HddDataLabel.Text = Program.product.HDD_size.ToString();
            GpuTypeDataLabel.Text = Program.product.GPU_Type.ToString();
            WeightDataLabel.Text = Program.product.weight.ToString();


        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";


            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamWriter outputString = new StreamWriter(
            File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {

                    outputString.WriteLine(Program.product.productID);
                    outputString.WriteLine(Program.product.cost);
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.RAM_type);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.displaytype);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.resolution);
                    outputString.WriteLine(Program.product.CPU_Class);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);
                    outputString.WriteLine(Program.product.CPU_speed);
                    outputString.WriteLine(Program.product.CPU_number);
                    outputString.WriteLine(Program.product.condition);
                    outputString.WriteLine(Program.product.OS);
                    outputString.WriteLine(Program.product.platform);
                    outputString.WriteLine(Program.product.HDD_size);
                    outputString.WriteLine(Program.product.HDD_speed);
                    outputString.WriteLine(Program.product.GPU_Type);
                    outputString.WriteLine(Program.product.optical_drive);
                    outputString.WriteLine(Program.product.Audio_type);
                    outputString.WriteLine(Program.product.LAN);
                    outputString.WriteLine(Program.product.weight);

                    outputString.Close();
                    outputString.Dispose();
                }
                MessageBox.Show("File saved succesfully", "Saving", MessageBoxButtons.OK);
            }
        }
    }
}
