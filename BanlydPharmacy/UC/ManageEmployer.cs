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
    public partial class ManageEmployer : UserControl
    {
        public ManageEmployer()
        {
            InitializeComponent();
        }

        private void ManageEmployer_Load(object sender, EventArgs e)
        {
            //FillGridView();
        }
    }


    //private void DeleteEmployee()
    //{
    //    try
    //    {
    //        if (MessageBox.Show("Doy you really want to delete the selected row?", "Delete", MessageBoxButtons.YesNo,
    //                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
    //        {
    //            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
    //            SqlCommand Cmd = conn.CreateCommand();
    //            Cmd.CommandType = CommandType.Text;
    //            Cmd.CommandText = "delete from WorkersInfo where ID = '" + id + "'";
    //            Cmd.ExecuteNonQuery();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(null + ex.Message);
    //    }
    //}

    //private void SearchText()
    //{
    //    try
    //    {
    //        SqlCommand Cmd = conn.CreateCommand();
    //        Cmd.CommandType = CommandType.Text;
    //        Cmd.CommandText = "SELECT * FROM WorkersInfo WHERE Firstname LIKE '%" + Search_txt.Text + "%' OR Surname LIKE '%" + Search_txt.Text + "%' ";
    //        SqlDataAdapter da = new SqlDataAdapter(Cmd);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        dataGridView1.DataSource = dt;
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(null + ex.Message);
    //    }
    //}

    //private void FillGridView()
    //{
    //    SqlCommand Cmd = conn.CreateCommand();
    //    Cmd.CommandType = CommandType.Text;
    //    Cmd.CommandText = "SELECT * FROM WorkersInfo ORDER BY ID";
    //    SqlDataAdapter da = new SqlDataAdapter(Cmd);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    dataGridView1.DataSource = dt;
    //}

    //event handlers


    //private void ManageEmployee_Load(object sender, EventArgs e)
    //{
    //    if (conn.State == ConnectionState.Open)
    //    {
    //        conn.Close();
    //    }
    //    conn.Open();
    //}

    //private void ClosePic_Click(object sender, EventArgs e)
    //{
    //    if (MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    //        == DialogResult.Yes)
    //    {
    //        this.Close();
    //    }
    //}

    //private void MinimizePic_Click_1(object sender, EventArgs e)
    //{
    //    Main MainformObject = new Main();
    //    WindowState = FormWindowState.Minimized;
    //}

    //private void RefreshContextMenu_Click(object sender, EventArgs e)
    //{
    //    if (Search_txt.Text == "search" || string.IsNullOrWhiteSpace(Search_txt.Text))
    //    {
    //        Search_txt.Text = "search";
    //        Search_txt.ForeColor = Color.Gray;
    //        Search_txt.TextAlign = HorizontalAlignment.Center;
    //        Search_pictureBox.Location = new Point(420, 54);
    //        FillGridView();
    //    }
    //    else
    //        SearchText();
    //}

    //private void NewEmployee_btn_Click(object sender, EventArgs e)
    //{
    //    AddEmployee_Form AddEmployeeObject = new AddEmployee_Form();
    //    AddEmployeeObject.ShowDialog();
    //}



    //private void UpdateEmplyee_btn_Click(object sender, EventArgs e)
    //{
    //    UpdateEmployee_Form uef = new UpdateEmployee_Form();
    //    uef.Show();
    //}

    //private void RefreshPicBox_Click(object sender, EventArgs e)
    //{
    //    FillGridView();
    //}

    //private void RemoveEmployee_btn_Click(object sender, EventArgs e)
    //{
    //    DeleteEmployee();
    //}

    //private void AddToolStripMenuItem_Click_1(object sender, EventArgs e)
    //{
    //    AddEmployee_Form newForm = new AddEmployee_Form();
    //    newForm.Show();
    //}

    //private void UpdateToolStripMenuItem_Click_1(object sender, EventArgs e)
    //{
    //    UpdateEmployee_Form newForm = new UpdateEmployee_Form();
    //    newForm.Show();
    //}

    //private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    //{
    //    DeleteEmployee();
    //}

    //private void Search_txt_Enter(object sender, EventArgs e)
    //{
    //    if (Search_txt.Text == "search")
    //    {
    //        Search_txt.Text = "";
    //        Search_txt.ForeColor = Color.Black;
    //        Search_txt.TextAlign = HorizontalAlignment.Center;
    //        Search_pictureBox.Location = new Point(4, 54);
    //    }
    //    else
    //    {
    //        SearchText();
    //    }
    //}

    //private void Search_txt_Leave(object sender, EventArgs e)
    //{
    //    if (string.IsNullOrWhiteSpace(Search_txt.Text) || Search_txt.Text == "search")
    //    {
    //        SearchClose_label.Visible = false;
    //        Search_txt.Text = "search";
    //        Search_txt.ForeColor = Color.Gray;
    //        Search_txt.TextAlign = HorizontalAlignment.Center;
    //        Search_pictureBox.Location = new Point(420, 54);
    //        FillGridView();
    //    }
    //    else
    //    {
    //        SearchText();
    //    }
    //}

    //private void Search_txt_TextChanged(object sender, EventArgs e)
    //{
    //    if (string.IsNullOrWhiteSpace(Search_txt.Text) || Search_txt.Text == "search")
    //    {
    //        FillGridView();
    //        SearchClose_label.Visible = false;
    //    }
    //    else
    //    {
    //        SearchClose_label.Visible = true;
    //        SearchText();
    //    }
    //}

    //private void SearchClose_label_Click(object sender, EventArgs e)
    //{
    //    Search_txt.Text = "search";
    //    Search_txt.ForeColor = Color.Gray;
    //    Search_txt.TextAlign = HorizontalAlignment.Center;
    //    Search_pictureBox.Location = new Point(420, 54);
    //    FillGridView();
    //    SearchClose_label.Visible = false;
    //}
}
