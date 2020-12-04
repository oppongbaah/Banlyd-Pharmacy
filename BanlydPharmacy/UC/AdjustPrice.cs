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
    public partial class AdjustPrice : UserControl
    {
        public AdjustPrice()
        {
            InitializeComponent();
        }

        private void SearchPrices_txt_TextChanged(object sender, EventArgs e)
        {

        }

        ////
        //private void FillPricesGrid()
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = conn.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "SELECT PartNo, PartDescription, CostPrice, SellingPrice, Discount, TaxVart, UnitPrice, " +
        //            " WholesalePrice FROM stock.vStockPrices Where PartDescription Like '%" + SearchPrices_txt.Text.Trim() +
        //            "%' ORDER BY PartDescription ";
        //        da = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        da.Fill(dt);
        //        StockPrices_dgv.DataSource = dt;
        //    }
        //}
        //private void UpdatePrices()
        //{
        //    DataGridViewRow dgvRow = StockPrices_dgv.CurrentRow;
        //    int PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo_StockPrices"].Value);
        //    string PartDescription = dgvRow.Cells["txtPartDescription_StockPrices"].Value.ToString();
        //    decimal Discount = Convert.ToDecimal(dgvRow.Cells["txtDiscount_StockPrices"].Value);
        //    decimal CostPrice = Convert.ToDecimal(dgvRow.Cells["txtCostPrice_StockPrices"].Value);
        //    decimal SellingPrice = Convert.ToDecimal(dgvRow.Cells["txtSellingPrice_StockPrices"].Value);
        //    decimal TaxVart = Convert.ToDecimal(dgvRow.Cells["txtTaxVart_StockPrices"].Value);
        //    decimal WholeSalePrice = Convert.ToDecimal(dgvRow.Cells["txtWholeSalePrice_StockPrices"].Value);
        //    decimal calcUnitPrice = SellingPrice - (Discount + TaxVart);
        //    decimal UnitPrice = calcUnitPrice;
        //    //
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_UpdatePrices]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDescription);
        //        cmd.Parameters.AddWithValue("@UnitPrice", UnitPrice);
        //        cmd.Parameters.AddWithValue("@CostPrice", CostPrice);
        //        cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice);
        //        cmd.Parameters.AddWithValue("@WholeSalePrice", WholeSalePrice);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        ////
        //private void UpdateDiscount()
        //{
        //    DataGridViewRow dgvRow = StockPrices_dgv.CurrentRow;
        //    int PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo_StockPrices"].Value);
        //    string PartDescription = dgvRow.Cells["txtPartDescription_StockPrices"].Value.ToString();
        //    decimal Discount = Convert.ToDecimal(dgvRow.Cells["txtDiscount_StockPrices"].Value);
        //    string DiscountDesc = "";
        //    //
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_UpdateDiscount]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDescription);
        //        cmd.Parameters.AddWithValue("@Discount", Discount);
        //        cmd.Parameters.AddWithValue("@DiscountDesc", DiscountDesc);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        ////
        //private void UpdateTaxVart()
        //{
        //    DataGridViewRow dgvRow = StockPrices_dgv.CurrentRow;
        //    int PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo_StockPrices"].Value);
        //    string PartDescription = dgvRow.Cells["txtPartDescription_StockPrices"].Value.ToString();
        //    decimal TaxVart = Convert.ToDecimal(dgvRow.Cells["txtTaxVart_StockPrices"].Value);
        //    string TaxVartDesc = "";
        //    //
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_UpdateTaxVart]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", PartNo);
        //        cmd.Parameters.AddWithValue("@PartDescription", PartDescription);
        //        cmd.Parameters.AddWithValue("@TaxVart", TaxVart);
        //        cmd.Parameters.AddWithValue("@TaxVartDesc", TaxVartDesc);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        ////
        //private void DeleteItemFromStock(int partNo)
        //{
        //    using (SqlConnection conn = new SqlConnection(ConnectionString))
        //    {
        //        conn.Open();
        //        cmd = new SqlCommand("[stock].[sp_DeleteStockItem]", conn)
        //        { CommandType = CommandType.StoredProcedure };
        //        cmd.Parameters.AddWithValue("@PartNo", partNo);
        //        cmd.ExecuteNonQuery();
        //    }
        //}




        //private void StockPrices_dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewCell dgvCell = StockPrices_dgv.CurrentCell;
        //        // get the position of the cursor in the gridview
        //        int y = dgvCell.ColumnIndex, x = dgvCell.RowIndex;
        //        UpdateDiscount();
        //        UpdateTaxVart();
        //        UpdatePrices();
        //        // maintain the cursor position
        //        StockPrices_dgv.CurrentCell = StockPrices_dgv.Rows[x].Cells[y];
        //        FillPricesGrid();
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        //}
        ////
        //private void SearchPrices_txt_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FillPricesGrid();
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
    }
}
