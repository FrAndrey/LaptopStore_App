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
/* Andrey Fr
 * 301038409
 * This is an application for purchasing computers
 * 08/08/19
 * */
namespace Store_App
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SelectFormButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            Program.producInfoForm.LoadProduct(sender, e);
            this.Hide();
            Program.producInfoForm.Show();
        }
    }
}
