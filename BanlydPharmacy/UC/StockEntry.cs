using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanlydPharmacy.UC
{
    public partial class StockEntry : UserControl
    {
        // GLOBAL VARIABLES
        Forms.Stock stock;
        string command;
        // DEFAULT CONSTRUCTOR
        public StockEntry()
        {
            InitializeComponent();
            InitialiseMyComponents();
            stock = new Forms.Stock();
            command = "";
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void FillStockGrid()
        {
            stock.main.con = new SqlConnection(stock.main.conString);
            command = "SELECT PartDescription, QtyToAdd, Supplier, ExpiryDates FROM" +
                " stock.vStockTaken where StockNo = '" + StockNo_txt.Text + "' ";
            stock.main.cmd = new SqlCommand(command, stock.main.con);
            stock.main.da = new SqlDataAdapter(stock.main.cmd);
            stock.main.dt = new DataTable();
            stock.main.da.Fill(stock.main.dt);
            StockTaken_dgv.DataSource = stock.main.dt;
        }
        //
        private void FillSuppliersCombo(ComboBox cmb)
        {
            stock.main.con = new SqlConnection(stock.main.conString);
            command = "Select Suppliers From stock.SuppliersList";
            stock.main.cmd = new SqlCommand(command, stock.main.con);
            stock.main.da = new SqlDataAdapter(stock.main.cmd);
            stock.main.dt = new DataTable();
            stock.main.da.Fill(stock.main.dt);
            foreach (DataRow row in stock.main.dt.Rows)
            {
                string item = row["Suppliers"].ToString();
                cmb.Items.Add(item);
            }
        }
        //
        private void FillToolBoxesWithStockTaken()
        {
            DataGridViewRow dgvRow = StockTaken_dgv.CurrentRow;
            PartDescription_txt.Text = dgvRow.Cells["txtPartDescription"].Value.ToString();
            PartNo_txt.Text = stock.GetPartNumber(PartDescription_txt.Text).ToString();
            OldQuantity_txt.Text = dgvRow.Cells["txtQuantity"].Value.ToString();
            OldSupplier_txt.Text = dgvRow.Cells["txtSuppliers"].Value.ToString();
            OldExpiryDate_txt.Text = dgvRow.Cells["txtExpiryDates"].Value.ToString();
        }
        //
        private int GetStockNo()
        {
            int StockNo = 0;
            stock.main.con = new SqlConnection(stock.main.conString);
            command = " SELECT TOP (1) StockNo FROM stock.vStockTaken ORDER BY StockNo Desc";
            stock.main.cmd = new SqlCommand(command, stock.main.con);
            stock.main.da = new SqlDataAdapter(stock.main.cmd);
            stock.main.dt = new DataTable();
            stock.main.da.Fill(stock.main.dt);
            if (stock.main.dt.Rows.Count == 1)
            {
                foreach (DataRow dr in stock.main.dt.Rows)
                    StockNo = Convert.ToInt32(dr["StockNo"]);
            }
            else
                StockNo = 1;
            return StockNo;
        }
        //
        private void InsertStockDetails()
        {
            using (stock.main.con = new SqlConnection(stock.main.conString))
            {
                stock.main.cmd = new SqlCommand("[stock].[sp_InsertOrUpdateDetails]", stock.main.con)
                { CommandType = CommandType.StoredProcedure };
                stock.main.cmd.Parameters.AddWithValue("@PartNo", PartNo_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@PartDescription", PartDescription_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@StockNo", Convert.ToInt32(StockNo_txt.Text));
                stock.main.cmd.Parameters.AddWithValue("@StockDesc", StockDescription_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@StockDate", stock.main.TodaysDate.ToShortDateString());
                stock.main.cmd.Parameters.AddWithValue("@StockTime", stock.main.TodaysDate.ToShortTimeString());
                if (StockAlreadyExist())
                    stock.main.cmd.Parameters.AddWithValue("@Exist", 1);
                else
                    stock.main.cmd.Parameters.AddWithValue("@Exist", 0);
                stock.main.con.Open();
                stock.main.cmd.ExecuteNonQuery();
            }
        }
        //
        private bool StockAlreadyExist()
        {
            bool exist = false;
            string command = "SELECT * FROM [stock].[Details] WHERE PartNo = '" + PartNo_txt.Text + "'";
            SqlConnection con = new SqlConnection(stock.main.conString);
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
                exist = true;
            else
                exist = false;
            return exist;
        }
        //
        public decimal UpdateQuantity(int partNo, int qtnAtHand, int qtnToAdd)
        {
            using (stock.main.con = new SqlConnection(stock.main.conString))
            {
                stock.main.cmd = new SqlCommand("[stock].[sp_UpdateQuantities]", stock.main.con)
                { CommandType = CommandType.StoredProcedure };
                stock.main.cmd.Parameters.AddWithValue("@PartNo", partNo);
                stock.main.cmd.Parameters.AddWithValue("@QtyAtHand", qtnAtHand);
                stock.main.cmd.Parameters.AddWithValue("@QtyToAdd", qtnToAdd);
                stock.main.con.Open();
                stock.main.cmd.ExecuteNonQuery();
            }
            return qtnAtHand + qtnToAdd;
        }
        //
        private void UpdateExpiryDates()
        {
            using (stock.main.con = new SqlConnection(stock.main.conString))
            {
                stock.main.cmd = new SqlCommand("[stock].[sp_UpdateExpiryDates]", stock.main.con)
                { CommandType = CommandType.StoredProcedure };
                stock.main.cmd.Parameters.AddWithValue("@PartNo", PartNo_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@PartDescription", PartDescription_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@ExpiryDates", NewExpiryDate_dtp.Value);
                stock.main.con.Open();
                stock.main.cmd.ExecuteNonQuery();
            }
        }
        //
        private void UpdateSuppliers()
        {
            using (stock.main.con = new SqlConnection(stock.main.conString))
            {
                stock.main.cmd = new SqlCommand("[stock].[sp_UpdateSuppliers]", stock.main.con)
                { CommandType = CommandType.StoredProcedure };
                stock.main.cmd.Parameters.AddWithValue("@PartNo", PartNo_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@PartDescription", PartDescription_txt.Text);
                stock.main.cmd.Parameters.AddWithValue("@Suppliers", NewSupplier_cmb.Text);
                stock.main.con.Open();
                stock.main.cmd.ExecuteNonQuery();
            }
        }
        //
        // EVENT HANDLERS
        //
        private void StockEntry_Load(object sender, EventArgs e)
        {
            FillSuppliersCombo(NewSupplier_cmb);
            StockNo_txt.Text = GetStockNo().ToString();
            FillStockGrid();
            PartDescription_txt.Focus();
        }
        //
        private void TxtDescription_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    StockList_lbl.Visible = StockList_uc.Visible = true;
                    StockList_uc.FillStockList(PartDescription_txt.Text);
                    StockList_uc.BringToFront();
                    StockList_uc.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    if (MessageBox.Show("Do you want to abort the process?", "Abort", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        PartDescription_txt.Text = NewQuantity_txt.Text = PartNo_txt.Text = "";
                        PartDescription_txt.Focus();
                        StockList_lbl.Visible = false;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void StockList_uc_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (!StockList_uc.Visible)
                {
                    StockList_lbl.Visible = false;
                    // Get the selected row values in the StockList datagridview
                    if (StockList_uc.EnterPressed)
                    {

                        PartNo_txt.Text = StockList_uc.PartNo.ToString();
                        PartDescription_txt.Text = StockList_uc.PartDescription;
                        OldQuantity_txt.Text = StockList_uc.Quantity.ToString();
                        OldExpiryDate_txt.Text = StockList_uc.ExpiryDates.ToString();
                        OldSupplier_txt.Text = StockList_uc.Suppliers.ToString();
                        StockTaken_dgv.BringToFront();
                        NewQuantity_txt.Focus();
                    }
                    else
                    {
                        PartDescription_txt.Text = NewQuantity_txt.Text = PartNo_txt.Text = "";
                        PartDescription_txt.Focus();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message+ex.StackTrace, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void TxtQuantity_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (PartDescription_txt.Text != "" && NewQuantity_txt.Text != "")
                    {
                        int partNo = Convert.ToInt32(PartNo_txt.Text);
                        int qtyAtHand = Convert.ToInt32(OldQuantity_txt.Text);
                        int QtyToAdd = Convert.ToInt32(NewQuantity_txt.Text);
                        InsertStockDetails();
                        OldQuantity_txt.Text = UpdateQuantity(partNo, qtyAtHand, QtyToAdd).ToString();
                        FillStockGrid();
                    }
                    else
                    {
                        MessageBox.Show("Quantity or description textbox is empty", "Save Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    NewQuantity_txt.Text = OldQuantity_txt.Text = OldSupplier_txt.Text = NewSupplier_cmb.Text =
                        OldExpiryDate_txt.Text = NewExpiryDate_dtp.Text = PartDescription_txt.Text = PartNo_txt.Text = "";
                    PartDescription_txt.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    if (MessageBox.Show("Do you want to abort the process?", "Abort", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        NewQuantity_txt.Text = OldQuantity_txt.Text = OldSupplier_txt.Text = NewSupplier_cmb.Text =
                        OldExpiryDate_txt.Text = NewExpiryDate_dtp.Text = PartDescription_txt.Text = PartNo_txt.Text = "";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        }
        //     
        private void StockNoPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //
        private void PartDescription_txt_Enter(object sender, EventArgs e)
        {
            NewQuantity_txt.Text = OldQuantity_txt.Text = OldSupplier_txt.Text = NewSupplier_cmb.Text = PartNo_txt.Text =
               OldExpiryDate_txt.Text = NewExpiryDate_dtp.Text = PartDescription_txt.Text = "";
        }
        //
        private void StockTaken_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FillToolBoxesWithStockTaken();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        }
        //
        private void SaveSupplier_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewSupplier_cmb.Text != "")
                {
                    UpdateSuppliers();
                    InsertStockDetails();
                }
                else
                    MessageBox.Show("Please select a valid supplier", "Invalid Supplier", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                OldSupplier_txt.Text = NewSupplier_cmb.Text;
                NewSupplier_cmb.Text = "";
                FillStockGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        }
        //
        private void SaveExpiry_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewExpiryDate_dtp.Text != "")
                {
                    UpdateExpiryDates();
                    InsertStockDetails();
                }
                else
                    MessageBox.Show("Please select a valid date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OldExpiryDate_txt.Text = NewExpiryDate_dtp.Text;
                NewExpiryDate_dtp.Text = "";
                FillStockGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "\n" + ex.StackTrace); }
        }
        //
        private void Refresh_tstrp_Clicked(object sender, EventArgs e)
        {
            try
            {
                FillStockGrid();
            }
            catch { }
        }
        //
        private void NewStock_tstrip_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(StockNo_txt.Text);
                id += 1;
                StockNo_txt.Text = id.ToString();
                PartDescription_txt.Text = OldQuantity_txt.Text = OldSupplier_txt.Text = NewSupplier_cmb.Text =
                    OldExpiryDate_txt.Text = NewQuantity_txt.Text = PartNo_txt.Text = "";
                FillStockGrid();
            }
            catch { }
        }
        //
        private void PreviousStock_tstrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(StockNo_txt.Text) > 1)
                {
                    int id = Convert.ToInt32(StockNo_txt.Text);
                    id -= 1;
                    StockNo_txt.Text = id.ToString();
                    PartDescription_txt.Text = OldQuantity_txt.Text = OldSupplier_txt.Text = NewSupplier_cmb.Text =
                        OldExpiryDate_txt.Text = NewQuantity_txt.Text = PartNo_txt.Text = "";
                    FillStockGrid();
                }
            }
            catch { }
        }
    }
}
