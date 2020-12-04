using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BanlydPharmacy
{
    public partial class Employee : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ISAAC\ISAACSQLSERVER;Initial Catalog=BanlydPharmacy;Integrated Security=True");
        //
        public Employee()
        {
            InitializeComponent();
        }
        //
        // USER-DEFINED FUNCTIONS
        //

        //
        // EVENT HANDLERS
        //
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            
        }
        //
        private void Home_menu_Click(object sender, EventArgs e)
        {

        }
        //
        private void NewEmployee_menu_Click(object sender, EventArgs e)
        {

        }
        //
        private void ModifyEmployee_menu_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
