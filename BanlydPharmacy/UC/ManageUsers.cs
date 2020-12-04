using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BanlydPharmacy.UC
{
    public partial class ManageUsers : UserControl
    {
        // GLOBAL VARIABLES
        Main main = new Main();
        string command = "";
        DataGridViewRow dgvRow;
        List<int> checkedList;
        // DEFAULT CONSTRUCTOR
        public ManageUsers()
        {
            InitializeComponent();
            checkedList = new List<int>();
        }
        //
        // USER-DEFINED FUNCTION
        //
        private void FillGridView()
        {
            command = "SELECT * FROM [dbo].[Users] ORDER BY UserID";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            SqlDataAdapter da = new SqlDataAdapter(main.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ManageUser_dgv.DataSource = dt;
        }
        //
        private void SearchUser()
        {
            command = "SELECT * FROM [dbo].[Users] WHERE Username LIKE '%" + Search_txt.Text + "%'";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            ManageUser_dgv.DataSource = main.dt;
        }
        //
        public void DeleteUser(int id)
        {
            dgvRow = ManageUser_dgv.CurrentRow;
            using (main.con = new SqlConnection(main.conString))
            {
                main.cmd = new SqlCommand("sp_DeleteUser", main.con) { CommandType = CommandType.StoredProcedure};
                main.cmd.Parameters.AddWithValue("@UserID", id);
                main.con.Open();
                main.cmd.ExecuteNonQuery();
            }
        }
        //
        //
        private void SelectRow()
        {
            DataGridViewRow dgvRow = ManageUser_dgv.CurrentRow;
            int userId = 0;
            bool check = Convert.ToBoolean(dgvRow.Cells["check"].Value);
            if (check == false)
            {
                check = true;
                // Get the PartNo of the selected row and add it to the List
                userId = Convert.ToInt32(dgvRow.Cells["txtID"].Value);
                checkedList.Add(userId);
                // Change the color of the row
                ManageUser_dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Red;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            else
            {
                check = false;
                // Get the PartNo of the selected row and remove it from the List
                userId = Convert.ToInt32(dgvRow.Cells["txtID"].Value);
                checkedList.Remove(userId);
                // Change the color of the row
                ManageUser_dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                ManageUser_dgv.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            dgvRow.Cells["check"].Value = check;
        }
        //
        // EVENT HANLERS
        //
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                FillGridView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void DeletesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgr = MessageBox.Show("Click on Yes to permanently remove seected user", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dlgr == DialogResult.Yes)
                {
                    foreach (var item in checkedList)
                        DeleteUser(item);
                    FillGridView();
                }
                else if (dlgr == DialogResult.No)
                    SearchUser();
                checkedList.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search_txt.Text == "search" || string.IsNullOrWhiteSpace(Search_txt.Text))
                {
                    Search_txt.Text = "search";
                    Search_txt.ForeColor = Color.Gray;
                    Search_txt.TextAlign = HorizontalAlignment.Center;
                    search_picbox.Location = new Point(266, 25);
                    FillGridView();
                }
                else
                    SearchUser();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                    SearchUser();
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
                    FillGridView();
                }
                else
                    SearchUser();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Search_txt.Text) || Search_txt.Text == "search")
                    FillGridView();
                else
                    SearchUser();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void RecentUsers_btn_Click(object sender, EventArgs e)
        {
            try
            {
                RecentUsers user = new RecentUsers();
                Controls.Add(user);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void ManageUser_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectRow();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
