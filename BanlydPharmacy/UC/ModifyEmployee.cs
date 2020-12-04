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
    public partial class ModifyEmployee : UserControl
    {
        public ModifyEmployee()
        {
            InitializeComponent();
        }

        //private void UpdateEmployee_Form_Load(object sender, EventArgs e)
        //{
        //    if (conn.State == ConnectionState.Open)
        //    {
        //        conn.Close();
        //    }
        //    conn.Open();
        //    //
        //    FillFirstNameCombo();
        //    FillNationalityCombo();
        //}

        //private void Cancel_btn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void Next_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string i = "";
        //        i = (Convert.ToInt32(Id_txt.Text) + 1).ToString();
        //        FirstName_combo.Text = "";
        //        Id_txt.Enabled = false;
        //        SqlCommand Cmd5 = conn.CreateCommand();
        //        Cmd5.CommandType = CommandType.Text;
        //        Cmd5.CommandText = "SELECT * FROM WorkersInfo WHERE ID = '" + i + "'";
        //        // * means select all the rows in the table. WHERE can be used for sorting out cells
        //        Cmd5.ExecuteNonQuery();
        //        DataTable Dtb5 = new DataTable();
        //        SqlDataAdapter Da5 = new SqlDataAdapter(Cmd5);
        //        Da5.Fill(Dtb5);
        //        foreach (DataRow dr in Dtb5.Rows)
        //        {
        //            Id_txt.Text = dr["ID"].ToString();
        //            FirstName_txt.Text = dr["Firstname"].ToString();
        //            Surname_txt.Text = dr["Surname"].ToString();
        //            Residence_txt.Text = dr["Residency"].ToString();
        //            Address_txt.Text = dr["Address"].ToString();
        //            Contact_txt.Text = dr["Contact"].ToString();
        //            Nationality_combo.Text = dr["Nationality"].ToString();
        //            Portfolio_combo.Text = dr["Portfolio"].ToString();
        //            EducationLevel_combo.Text = dr["LevelOfEducation"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
        //}

        //private void FillFirstNameCombo()
        //{
        //    SqlCommand cmd = new SqlCommand("Select * From WorkersInfo", conn);
        //    SqlDataReader ReadMyData;
        //    try
        //    {
        //        ReadMyData = cmd.ExecuteReader();
        //        while (ReadMyData.Read())
        //        {
        //            string FirstName = ReadMyData.GetString(1);
        //            FirstName_combo.Items.Add(FirstName);
        //        }
        //        ReadMyData.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
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

        //private void Navigate_KeyDown(object sender, KeyEventArgs e)
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

        //private void FirstName_combo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlCommand Cmd3 = conn.CreateCommand();
        //        Cmd3.CommandType = CommandType.Text;
        //        Cmd3.CommandText = "SELECT * FROM WorkersInfo WHERE FirstName = '" + FirstName_combo.SelectedItem + "'";
        //        // * means select all the rows in the table. WHERE can be used for sorting out cells
        //        Cmd3.ExecuteNonQuery();
        //        DataTable Dtb = new DataTable();
        //        SqlDataAdapter Da = new SqlDataAdapter(Cmd3);
        //        Da.Fill(Dtb);
        //        foreach (DataRow dr in Dtb.Rows)
        //        {
        //            Id_txt.Text = dr["ID"].ToString();
        //            FirstName_txt.Text = dr["Firstname"].ToString();
        //            Surname_txt.Text = dr["Surname"].ToString();
        //            Residence_txt.Text = dr["Residency"].ToString();
        //            Address_txt.Text = dr["Address"].ToString();
        //            Contact_txt.Text = dr["Contact"].ToString();
        //            Nationality_combo.Text = dr["Nationality"].ToString();
        //            Portfolio_combo.Text = dr["Portfolio"].ToString();
        //            EducationLevel_combo.Text = dr["LevelOfEducation"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
        //}

        //private void Update_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlCommand Cmd4 = conn.CreateCommand();
        //        Cmd4.CommandType = CommandType.Text;
        //        Cmd4.CommandText = "Update WorkersInfo Set ID = '" + Id_txt.Text + "', Firstname = '" + FirstName_txt.Text + "', Surname = '" + Surname_txt.Text + "'" +
        //        ", Residency = '" + Residence_txt.Text + "', Address = '" + Address_txt.Text + "', Contact = '" + Contact_txt.Text + "'" +
        //        ", Nationality = '" + Nationality_combo.Text + "', Portfolio = '" + Portfolio_combo.Text + "', LevelOfEducation = " +
        //        "'" + EducationLevel_combo.Text + "' where ID = '" + Id_txt.Text + "'";
        //        Cmd4.ExecuteNonQuery();
        //        if (Id_txt.Text == "0")
        //        {
        //            MessageBox.Show("Please select an employee to update employee's info.\nYou can search by firstname or navigate through" +
        //                " the list of employees available in our database ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            Clear();
        //        }
        //        else
        //            MessageBox.Show("Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
        //}

        //private void Previous_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string i = "";
        //        i = (Convert.ToInt32(Id_txt.Text) - 1).ToString();
        //        FirstName_combo.Text = "";
        //        Id_txt.Enabled = false;
        //        SqlCommand Cmd5 = conn.CreateCommand();
        //        Cmd5.CommandType = CommandType.Text;
        //        Cmd5.CommandText = "SELECT * FROM WorkersInfo WHERE ID = '" + i + "'";
        //        // * means select all the rows in the table. WHERE can be used for sorting out cells
        //        Cmd5.ExecuteNonQuery();
        //        DataTable Dtb5 = new DataTable();
        //        SqlDataAdapter Da5 = new SqlDataAdapter(Cmd5);
        //        Da5.Fill(Dtb5);
        //        foreach (DataRow dr in Dtb5.Rows)
        //        {
        //            Id_txt.Text = dr["ID"].ToString();
        //            FirstName_txt.Text = dr["Firstname"].ToString();
        //            Surname_txt.Text = dr["Surname"].ToString();
        //            Residence_txt.Text = dr["Residency"].ToString();
        //            Address_txt.Text = dr["Address"].ToString();
        //            Contact_txt.Text = dr["Contact"].ToString();
        //            Nationality_combo.Text = dr["Nationality"].ToString();
        //            Portfolio_combo.Text = dr["Portfolio"].ToString();
        //            EducationLevel_combo.Text = dr["LevelOfEducation"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
        //}

        //private void ModifyID_lable_Click(object sender, EventArgs e)
        //{
        //    Id_txt.Enabled = true;
        //}

        //private void Id_txt_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlCommand Cmd7 = conn.CreateCommand();
        //        Cmd7.CommandType = CommandType.Text;
        //        Cmd7.CommandText = "SELECT * FROM WorkersInfo WHERE ID = '" + Id_txt.Text + "'";
        //        // * means select all the rows in the table. WHERE can be used for sorting out cells
        //        Cmd7.ExecuteNonQuery();
        //        DataTable Dtb = new DataTable();
        //        SqlDataAdapter Da = new SqlDataAdapter(Cmd7);
        //        Da.Fill(Dtb);
        //        foreach (DataRow dr in Dtb.Rows)
        //        {
        //            Id_txt.Text = dr["ID"].ToString();
        //            FirstName_txt.Text = dr["Firstname"].ToString();
        //            Surname_txt.Text = dr["Surname"].ToString();
        //            Residence_txt.Text = dr["Residency"].ToString();
        //            Address_txt.Text = dr["Address"].ToString();
        //            Contact_txt.Text = dr["Contact"].ToString();
        //            Nationality_combo.Text = dr["Nationality"].ToString();
        //            Portfolio_combo.Text = dr["Portfolio"].ToString();
        //            EducationLevel_combo.Text = dr["LevelOfEducation"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(null + ex.Message, "Error");
        //    }
        //}
        ////
        //private void Clear()
        //{
        //    FirstName_txt.Text = Surname_txt.Text = Contact_txt.Text = Address_txt.Text = Residence_txt.Text =
        //    Nationality_combo.Text = Portfolio_combo.Text = EducationLevel_combo.Text = " ";
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
        //        MessageBox.Show("Please contact already exist", "Message", MessageBoxButtons.OK,
        //        MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        //        Contact_txt.Text = "";
        //    }
        //}

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

        }


    }
}
