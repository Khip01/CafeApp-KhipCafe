using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Cafe_UKK
{
    public partial class ShowImage : Form
    {
        public ShowImage(string path)
        {
            InitializeComponent();

            pbImage.ImageLocation = path;
        }

        //// FORM CONTROL
        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
