using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// This is a Splash Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            Program.startForm.Show();

        }
    }
}
