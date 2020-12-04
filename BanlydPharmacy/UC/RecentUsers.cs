using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanlydPharmacy.UC
{
    public partial class RecentUsers : UserControl
    {
        // GLOBAL VARIABLES
        Main main = new Main();
        string command;
        // DEFAULT CONSTRUCTOR
        public RecentUsers()
        {
            InitializeComponent();
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void Search(string commandT)
        {            
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(commandT, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            RecentUsers_dgv.DataSource = main.dt;
        }
        //
        //
        // EVENT HANDLERS
        //
        private void RecentUsers_Load(object sender, EventArgs e)
        {
            command = "SELECT * FROM vViewUsers ORDER BY LoginTime DESC";
            Search(command);
            RecentUsers_dgv.Focus();
        }
        //
        private void Search_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Search_txt.Text == "search")
                {
                    Search_txt.Text = "";
                    Search_txt.ForeColor = Color.Black;
                    Search_txt.TextAlign = HorizontalAlignment.Left;
                }
                else
                {
                    command = "SELECT * FROM vViewUsers WHERE Username LIKE '%" + Search_txt.Text + "%' ORDER BY LoginTime DESC";
                    Search(command);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Search_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Search_txt.Text) || Search_txt.Text == "search")
                {
                    Search_txt.Text = "search";
                    Search_txt.ForeColor = Color.Gray;
                    Search_txt.TextAlign = HorizontalAlignment.Center;
                    command = "SELECT * FROM vViewUsers ORDER BY LoginTime DESC";
                    Search(command);
                }
                else
                {
                    command = "SELECT * FROM vViewUsers WHERE Username LIKE '%" + Search_txt.Text + "%' ORDER BY LoginTime DESC";
                    Search(command);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search_txt.Text) || Search_txt.Text == "search")
            {
                command = "SELECT * FROM vViewUsers ORDER BY LoginTime DESC";
                Search(command);
            }
            else
            {
                command = "SELECT * FROM vViewUsers WHERE Username LIKE '%" + Search_txt.Text + "%' ORDER BY LoginTime DESC";
                Search(command);
            }
        }
    }
}
