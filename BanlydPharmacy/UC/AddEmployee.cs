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
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        //private void Submit_btn_Click(object sender, EventArgs e)
        //{
        //    if (Firstname_txt.Text == "" || Surname_txt.Text == "" || Contact_txt.Text == "" || Address_txt.Text == ""
        //        || Residence_txt.Text == "" || Nationality_combo.Text == "" || Portfolio_combo.Text == "" || EducationLevel_combo.Text == "")
        //    {
        //        MessageBox.Show("Please fill all the areas provided to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("AddWorker", conn);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            // set parameters to add text in textboxes to the database
        //            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = numericUpDown1.Text.Trim();
        //            cmd.Parameters.Add("@Firstname", SqlDbType.NVarChar, 50).Value = Firstname_txt.Text.Trim();
        //            cmd.Parameters.Add("@Surname", SqlDbType.NVarChar, 50).Value = Surname_txt.Text.Trim();
        //            cmd.Parameters.Add("@Residency", SqlDbType.NVarChar, 50).Value = Residence_txt.Text.Trim();
        //            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = Address_txt.Text.Trim();
        //            cmd.Parameters.Add("@Contact", SqlDbType.NVarChar, 50).Value = code_combo.Text.Trim() + Contact_txt.Text.Trim();
        //            cmd.Parameters.Add("@Nationality", SqlDbType.NVarChar, 50).Value = Nationality_combo.Text.Trim();
        //            cmd.Parameters.Add("@Portfolio", SqlDbType.NVarChar, 50).Value = Portfolio_combo.Text.Trim();
        //            cmd.Parameters.Add("@LevelOfEducation", SqlDbType.NVarChar, 50).Value = EducationLevel_combo.Text.Trim();
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Employee addded successfully", "Success", MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //            // clear the all the textboxes with the clear function
        //            Clear();
        //            numericUpDown1.Value += 1;
        //        }
        //        catch
        //        {
        //            MessageBox.Show("ID already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        //// a clear function
        //private void Clear()
        //{
        //    Firstname_txt.Text = Surname_txt.Text = Contact_txt.Text = Address_txt.Text = Residence_txt.Text =
        //    Nationality_combo.Text = Portfolio_combo.Text = EducationLevel_combo.Text = " ";
        //}

        //private void ToggleTools_KeyDown(object sender, KeyEventArgs e)
        //{
        //    ctrl = (Control)sender;
        //    if (ctrl is TextBox)
        //    {
        //        if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
        //        {
        //            this.SelectNextControl(ctrl, true, true, true, true);
        //        }
        //        else if (e.KeyCode == Keys.Up)
        //        {
        //            this.SelectNextControl(ctrl, false, true, true, true);
        //        }
        //    }
        //    else if (ctrl is Button)
        //    {
        //        if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
        //        {
        //            this.SelectNextControl(ctrl, true, true, true, true);
        //        }
        //        else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
        //        {
        //            this.SelectNextControl(ctrl, false, true, true, true);
        //        }
        //    }
        //    else if (ctrl is ComboBox)
        //    {
        //        if (e.KeyCode == Keys.Enter)
        //        {
        //            this.SelectNextControl(ctrl, true, true, true, true);
        //        }
        //    }
        //}

        //private void Cancel_btn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void ClosePic_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void MinimizePic_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}
        ////
        //private void lOadID()
        //{
        //    try
        //    {
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = " SELECT TOP (1) ID FROM WorkersInfo ORDER BY ID Desc";
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        //
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            numericUpDown1.Value = Convert.ToInt32(dr["ID"]) + 1;
        //        }
        //    }
        //    catch (Exception EX)
        //    {
        //        MessageBox.Show(null + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        ////
        //private void AddEmployee_Form_Load(object sender, EventArgs e)
        //{
        //    // Open and close connection
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //    conn.Open();
        //    //
        //    FillNationalityCombo();
        //    //
        //    lOadID();
        //}
        //private void FillNationalityCombo()
        //{
        //    SqlCommand cmd2 = new SqlCommand("Select * From CountriesList", conn);
        //    SqlDataReader read;
        //    try
        //    {
        //        read = cmd2.ExecuteReader();
        //        while (read.Read())
        //        {
        //            string Countries = read.GetString(1);
        //            Nationality_combo.Items.Add(Countries);
        //        }
        //        read.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Exception");
        //    }
        //}

        //private void Contact_txt_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void Contact_txt_Leave(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select Contact from WorkersInfo where Contact = '" + Contact_txt.Text + "'";
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows.Count == 1)
        //    {
        //        Regex reg = new Regex("[0-9]{`10,10}");
        //        MessageBox.Show("Please contact already exist", "Message", MessageBoxButtons.OK,
        //        MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        //        Contact_txt.Text = "";
        //    }
        //}
    }
}
