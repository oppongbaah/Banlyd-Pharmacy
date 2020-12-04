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
    public partial class AddorRemoveStock : UserControl
    {

        List<int> checkedList = new List<int>();


        public AddorRemoveStock()
        {
            InitializeComponent();
        }

        ////
        //private void FillItemNameRemovalGrid()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT PartNo, PartDescription FROM stock.Groups ORDER BY PartDescription ";
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        ItemRemoval_dgv.DataSource = dt;
        //    }
        //}

        ////
        //private void SearchItemName()
        //{
        //    string searchText = "";
        //    if (Search_txt.Text == "search item")
        //        searchText = "";
        //    else
        //        searchText = Search_txt.Text;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT PartNo, PartDescription FROM stock.Groups " +
        //            " Where PartDescription Like '%" + searchText + "%' Order by PartDescription";
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        ItemRemoval_dgv.DataSource = dt;
        //    }
        //}
        //private void FillGroupCombo()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string commandText = "Select GroupDesc From stock.GroupList";
        //        cmd = new SqlCommand(commandText, conn);
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string item = row["GroupDesc"].ToString();
        //            GroupList_cmb.Items.Add(item);
        //        }
        //    }
        //}
        ////
        //private void FillSuppliersCombo(ComboBox cmb)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string commandText = "Select Suppliers From stock.SuppliersList";
        //        cmd = new SqlCommand(commandText, conn);
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string item = row["Suppliers"].ToString();
        //            cmb.Items.Add(item);
        //        }
        //    }
        //}
        ////
        //private void FillDiscountCombo()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string commandText = "Select DiscountType From stock.DiscountList";
        //        cmd = new SqlCommand(commandText, conn);
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string item = row["DiscountType"].ToString();
        //            Discount_cmb.Items.Add(item);
        //        }
        //    }
        //}
        ////
        //private void FillTaxVartCombo()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        string commandText = "Select TaxVartType From stock.TaxVartList";
        //        cmd = new SqlCommand(commandText, conn);
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            string item = row["TaxVartType"].ToString();
        //            TaxVart_cmb.Items.Add(item);
        //        }
        //    }
        //}
        ////
        //private void SelectRow()
        //{
        //    DataGridViewRow dgvRow = ItemRemoval_dgv.CurrentRow;
        //    bool check = Convert.ToBoolean(dgvRow.Cells["txtCheck_Stock"].Value);
        //    int PartNumber = 0;
        //    if (check == false)
        //    {
        //        check = true;
        //        // Get the PartNo of the selected row and add it to the List
        //        PartNumber = Convert.ToInt32(dgvRow.Cells["txtPartNo_Stock"].Value);
        //        checkedList.Add(PartNumber);
        //        // Change the color of the row
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Red;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        //    }
        //    else
        //    {
        //        check = false;
        //        // Get the PartNo of the selected row and remove it from the List
        //        PartNumber = Convert.ToInt32(dgvRow.Cells["txtPartNo_Stock"].Value);
        //        checkedList.Remove(PartNumber);
        //        // Change the color of the row
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.BackColor = Color.White;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
        //        ItemRemoval_dgv.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.White;
        //    }
        //    dgvRow.Cells["txtCheck_Stock"].Value = check;
        //}
        ////
        //private int InsertExpiryDate()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertExpiryDate]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate_dtp.Value.ToShortDateString());
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private int InsertGroups()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertGroups]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@GroupDesc", GroupList_cmb.Text);
        //        cmd.Parameters.AddWithValue("@GroupNo", GetGroupID(GroupList_cmb.Text));
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private int InsertQuantity()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertQuantity]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@QtnAtHand", Quantity_nud.Value);
        //        cmd.Parameters.AddWithValue("@QtnToAdd", 0);
        //        cmd.Parameters.AddWithValue("@TotalQtn", Quantity_nud.Value);
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private int InsertSupplier()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertSuppliers]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@Supplier", Supplier_cmb.Text);
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private int InsertTaxVart()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertTaxVart]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@TaxVart", Convert.ToDecimal(TaxVart_txt.Text));
        //        cmd.Parameters.AddWithValue("@TaxVartDesc", TaxVart_cmb.Text);
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private int InsertPrices()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_InsertPrices]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(UnitPrice_txt.Text));
        //        cmd.Parameters.AddWithValue("@CostPrice", Convert.ToDecimal(CostPrice_txt.Text));
        //        cmd.Parameters.AddWithValue("@SellingPrice", Convert.ToDecimal(SellingPrice_txt.Text));
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private bool SaveItem()
        //{
        //    bool isDone;
        //    if (InsertGroups() == 1 && InsertDiscount() == 1 && InsertExpiryDate() == 1 && InsertPrices() == 1
        //        && InsertQuantity() == 1 && InsertSupplier() == 1 && InsertTaxVart() == 1)
        //        isDone = true;
        //    else
        //        isDone = false;
        //    return isDone;
        //}
        ////
        //private void ClearToolBoxes()
        //{
        //    PartNo_nud.Value = GetPartNumber();
        //    PartDesStock_txt.Text = GroupList_cmb.Text = Discount_cmb.Text = TaxVart_cmb.Text = Supplier_cmb.Text = "";
        //    Quantity_nud.Value = 1;
        //    ExpiryDate_dtp.Text = date1.ToShortDateString();
        //    CostPrice_txt.Text = SellingPrice_txt.Text = UnitPrice_txt.Text = WholesalePrice_txt.Text =
        //        Discount_txt.Text = TaxVart_txt.Text = "0.00";
        //}



        //private void Add_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        bool successful;
        //        if (PartDesStock_txt.Text != "")
        //        {
        //            if (GroupList_cmb.Text == "")
        //                GroupList_cmb.Text = "Drugs";
        //            successful = SaveItem();
        //            if (successful)
        //            {
        //                MessageBox.Show("Item is saved sucessfully. You can search for it in the table", "Info",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                ClearToolBoxes();
        //                FillPricesGrid();
        //                FillModifyItemGrid();
        //                FillItemNameRemovalGrid();
        //            }
        //            else
        //            {
        //                MessageBox.Show("The process is aborted. You can try again", "Info", MessageBoxButtons.OK,
        //                MessageBoxIcon.Information);
        //            }
        //        }
        //        else
        //            MessageBox.Show("Please enter the item name to proceed", "Info", MessageBoxButtons.OK,
        //                MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        //}
        ////
        //private void Remove_btn_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult dlgr = new DialogResult();
        //        if (checkedList.Any())
        //        {
        //            dlgr = MessageBox.Show("All selected rows wil be permanently deleted from the system. Do you wish to proceed?" +
        //                " ", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
        //            if (dlgr == DialogResult.Yes)
        //            {
        //                foreach (var item in checkedList)
        //                    DeleteItemFromStock(item);
        //                SearchItemName();
        //                FillPricesGrid();
        //                FillModifyItemGrid();
        //                PartNo_nud.Value = GetPartNumber();
        //            }
        //            else if (dlgr == DialogResult.No)
        //                SearchItemName();
        //            checkedList.Clear();
        //        }
        //        else
        //            MessageBox.Show("Please select at least one row to perform this function \n " +
        //                "Double click on a row to select", "Info", MessageBoxButtons.OK,
        //                   MessageBoxIcon.Information);
        //    }
        //    catch { }
        //}
        //private void ItemRemoval_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        SelectRow();
        //    }
        //    catch { }
        //}


        //private void Search_txt_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Search_txt.Text == "search item")
        //        {
        //            Search_txt.Text = "";
        //            Search_txt.ForeColor = Color.Black;
        //            Search_txt.TextAlign = HorizontalAlignment.Left;
        //            Search_picb.Visible = false;
        //        }
        //    }
        //    catch { }
        //}
        ////
        //private void Search_txt_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Search_txt.Text == "")
        //        {
        //            Search_txt.Text = "search item";
        //            Search_txt.ForeColor = Color.Silver;
        //            Search_txt.TextAlign = HorizontalAlignment.Center;
        //            Search_picb.Visible = true;
        //        }
        //    }
        //    catch { }
        //}
        ////
        //private void Search_txt_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SearchItemName();
        //    }
        //    catch { }
        //}
        ////
        //private void SellingPrice_txt_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        UnitPrice_txt.Text = ((Convert.ToDecimal(SellingPrice_txt.Text) + Convert.ToDecimal(TaxVart_txt.Text)) -
        //                    Convert.ToDecimal(Discount_txt.Text)).ToString();
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //}
        ////
        //private int InsertDiscount()
        //{
        //    int performed;
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        cmd = new SqlCommand("[stock].[sp_InsertDiscount]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo_nud.Value);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDesStock_txt.Text);
        //        cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(Discount_txt.Text));
        //        cmd.Parameters.AddWithValue("@DiscountDescription", Discount_cmb.Text);
        //        conn.Open();
        //        performed = cmd.ExecuteNonQuery();
        //    }
        //    return performed;
        //}
        ////
        //private string GetGroupID(string GroupDescription)
        //{
        //    string GroupID = "";
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {
        //        con.Open();
        //        cmd1 = con.CreateCommand();
        //        cmd1.CommandType = CommandType.Text;
        //        cmd1.CommandText = " SELECT GroupID FROM [stock].[GroupList] Where GroupDesc = '" + GroupDescription + "'";
        //        da = new SqlDataAdapter(cmd1);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        foreach (DataRow dr in dt.Rows)
        //            GroupID = dr["GroupID"].ToString();
        //    }
        //    return GroupID;
        //}
    }
}
