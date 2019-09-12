using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PNY.Batch18.WinUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form countryForm = new frmCountry();
            countryForm.MdiParent = this;
            countryForm.Show();
        }

        private void AddCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cityForm = new frmCity();
            cityForm.MdiParent = this;
            cityForm.Show();
        }
    }
}
