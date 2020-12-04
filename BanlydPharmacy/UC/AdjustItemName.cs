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
    public partial class AdjustItemName : UserControl
    {
        public AdjustItemName()
        {
            InitializeComponent();
        }
        ////
        //private void FillModifyItemGrid()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT PartNo, PartDescription, GroupDescription FROM [stock].[Groups]" +
        //            " ORDER BY PartDescription ";
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        ModifyName_dgv.DataSource = dt;
        //    }
        //}
        ////
        //private void SearchItemModifyName()
        //{
        //    string searchText = "";
        //    if (SearchItemName_txt.Text == "search item")
        //        searchText = "";
        //    else
        //        searchText = SearchItemName_txt.Text;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT * FROM stock.Groups Where PartDescription Like '%"
        //            + searchText + "%' Order by PartDescription";
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        ModifyName_dgv.DataSource = dt;
        //    }
        //}
        ////
        //private void SaveItemName()
        //{
        //    int x = ModifyName_dgv.CurrentCell.RowIndex;
        //    int y = ModifyName_dgv.CurrentCell.ColumnIndex;
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_UpdateItemDescription]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo);
        //        cmd.Parameters.AddWithValue("@PartDescription", NewName_txt.Text);
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    if (performed == 7 || performed == 8)
        //    {
        //        InitialName_txt.Text = NewName_txt.Text = "";
        //        FillModifyItemGrid();
        //        ModifyName_dgv.CurrentCell = ModifyName_dgv.Rows[x].Cells[y];
        //    }
        //    else
        //        MessageBox.Show("Oops! We had a problem updating " + InitialName_txt.Text + ". Please make sure you avoid using " +
        //        "inverted commas and kindly try again try again", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void SearchItemName_txt_Leave(object sender, EventArgs e)
        //{
        //    if (Search_txt.Text == "")
        //    {
        //        SearchItemName_txt.Text = "search item";
        //        SearchItemName_txt.ForeColor = Color.Silver;
        //        SearchItemName_txt.TextAlign = HorizontalAlignment.Center;
        //        searchitem_picb.Visible = true;
        //    }
        //}
        ////
        //private void SearchItemName_txt_Enter(object sender, EventArgs e)
        //{
        //    if (Search_txt.Text == "search item")
        //    {
        //        SearchItemName_txt.Text = "";
        //        SearchItemName_txt.ForeColor = Color.Black;
        //        SearchItemName_txt.TextAlign = HorizontalAlignment.Left;
        //        searchitem_picb.Visible = false;
        //    }
        //}
        ////
        //private void SearchItemName_txt_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SearchItemModifyName();
        //    }
        //    catch { }
        //}
        ////
        //private void ModifyName_dgv_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow dgvRow = ModifyName_dgv.CurrentRow;
        //        ItemName = dgvRow.Cells["txtItemDesc_ModName"].Value.ToString();
        //        PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo_ModName"].Value);
        //        InitialName_txt.Text = ItemName;
        //        NewName_txt.Text = ItemName;
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        //}
        ////
        //private void ApplyChanges_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SaveItemName();
        //        ModifyName_dgv.Focus();
        //        FillPricesGrid();
        //        FillItemNameRemovalGrid();
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        //}
    }
}
