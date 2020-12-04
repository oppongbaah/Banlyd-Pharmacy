using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BanlydPharmacy.UC
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }
        //
        //private int UpdateProfile()
        //{
        //    int success;
        //    using (con = new SqlConnection(conString))
        //    {
        //        cmd = new SqlCommand("sp_UpdatePassword", con) { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@UserID", userId);
        //        cmd.Parameters.AddWithValue("@Username", Username);
        //        cmd.Parameters.AddWithValue("@Password", Password_txt.Text);
        //        con.Open();
        //        success = cmd.ExecuteNonQuery();
        //    }
        //    return success;
        //}

        private void Profile_Load(object sender, EventArgs e)
        {
            Username_txt.Text = Username_lbl.Text;
        }
        //
        //
        private void Update_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Regex regPass = new Regex("(?!^[0-9]*$)(?!^[a-zA-Z]*$)(?=.*[A-Z])(?=.*[a-z])^([a-zA-Z0-9]{6,16})$");
            //    if (regPass.IsMatch(Password_txt.Text.ToString()))
            //    {
            //        if (UpdateProfile() == 1)
            //            MessageBox.Show("Password successfully updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Process is aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //        MessageBox.Show("1. Password must be alphanumeric of at 6-16 characters and \n2. Must contain at least an upper" +
            //            "case letter \n3. Must contain at least one number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
