using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanlydPharmacy.Forms.Tools
{
    public partial class ReportSales : Form
    {
        public ReportSales()
        {
            InitializeComponent();
        }
        //
        private void ReportSales_Load(object sender, EventArgs e)
        {

        }
        //
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exist?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
    }
}
