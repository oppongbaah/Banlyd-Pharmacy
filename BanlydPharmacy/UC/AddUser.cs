using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanlydPharmacy.UC
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            ClearAll_lbl.Visible = false;
        }
    }
}
