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
using System.IO;

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

        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.producInfoForm.Show();
        }

        private void DataGridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridTable_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = dataGridTable.CurrentCell.RowIndex;
            var rows = dataGridTable.Rows;
            var columnCount = dataGridTable.ColumnCount;
            var cells = rows[rowIndex].Cells;
            // rows[rowIndex].Selected = true; 
            CurrentSelectionBox.Text = " ";

            CurrentSelectionBox.Text = cells[2].Value.ToString() + " " + cells[3].Value.ToString()
               + "  Price: " + cells[1].Value.ToString() + "$";

            // Program.product.productID = int.Parse( cells[1].Value.ToString() );

            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.RAM_type = cells[4].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.displaytype = cells[6].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.resolution = cells[8].Value.ToString();
            Program.product.CPU_Class = cells[9].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.CPU_speed = cells[12].Value.ToString();
            Program.product.CPU_number = cells[13].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.HDD_speed = cells[18].Value.ToString();
            Program.product.GPU_Type = cells[19].Value.ToString();
            Program.product.optical_drive = cells[20].Value.ToString();
            Program.product.Audio_type = cells[21].Value.ToString();
            Program.product.LAN = cells[22].Value.ToString();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          using (  StreamWriter outputString = new StreamWriter(
              File.Open("Product.txt",FileMode.Create)))
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

                outputString.Close();
                outputString.Dispose();
            }

}
}
}
