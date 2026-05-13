using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please enter a file name.", "Missing Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            SetFileName = txtFileName.Text.Trim() + ".txt";
            this.Close();
        }

        private void lblEnterFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
