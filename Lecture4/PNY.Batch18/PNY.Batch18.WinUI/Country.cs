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
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtName.Text;
        }
    }
}
