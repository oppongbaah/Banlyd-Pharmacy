using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace BanlydPharmacy
{
    public partial class Sales : Form
    {
        Main main = new Main();
        Forms.Stock stock;
        string command;
        int PartNo;
        // DEFAULT CONSTRUCTOR
        public Sales()
        {
            InitializeComponent();
            InitialiseMyComponents();
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        public void Fill_SalesTaken_dgv()
        {
            command = "SELECT PartDescription, UnitPrice, Quantity, TotalPrice  FROM sales.SalesTaken" +
                " WHERE SalesDate = '" + SalesDate_dtp.Value + "'" +
                " AND ClientNo = '" + Convert.ToInt32(ClientsID_txt.Text) + "' ORDER BY InvoiceNo ";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            SalesTaken_dgv.DataSource = main.dt;
        }
        //
        public int SalesNo()
        {
            int No = 1;
            command = "SELECT TOP (1) InvoiceNo FROM sales.SalesTaken Where SalesDate = '" + SalesDate_dtp.Value +
                "' ORDER BY SalesDate DESC, InvoiceNo DESC ";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            if (main.dt.Rows.Count == 1)
            {
                foreach (DataRow dr in main.dt.Rows)
                    No = Convert.ToInt32(dr["InvoiceNo"].ToString());
                No++;
            }
            else
                No = 1;
            return No;
        }
        //
        public int ClientNo()
        {
            int clientNo = 1;
            command = "SELECT TOP (1) ClientNo, SalesDate FROM sales.SalesTaken Where SalesDate = " +
                "'" + SalesDate_dtp.Value + "' ORDER BY SalesDate DESC, ClientNo DESC ";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            if (main.dt.Rows.Count == 1)
            {
                foreach (DataRow dr in main.dt.Rows)
                    clientNo = int.Parse(dr["ClientNo"].ToString());
            }
            else
                clientNo = 1;
            return clientNo;
        }
        //
        public void DeleteFromSalesGridView()
        {
            DataGridViewRow dgvRow = SalesTaken_dgv.CurrentRow;
            int stockQuantity;
            int deletedQuantity = Convert.ToInt32(dgvRow.Cells["txtQuantity_sales"].Value);
            int PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo_sales"].Value);
            string ItemName = dgvRow.Cells["txtPartDescription_sales"].Value.ToString();
            // 
            using (main.con = new SqlConnection(main.conString))
            {
                main.cmd = new SqlCommand("[sales].[sp_DeleteSalesTaken]", main.con)
                { CommandType = CommandType.StoredProcedure };
                // pass the following parameter to the stored proceedure and execute there after
                main.cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(SalesTaken_dgv.CurrentRow.Cells
                    ["txtSN_sales"].Value.ToString()));
                main.con.Open();
                main.cmd.ExecuteNonQuery();
                // get stock quantity
                stock = new Forms.Stock(PartNo, ItemName);
                stockQuantity = stock.Quantity();
                // update stock after deleting quantity
                stock.UpdateQuantity(PartNo, stockQuantity, deletedQuantity);
            }
        }
        //
        private void AddDailySales()
        {
            decimal unitPrice = Convert.ToDecimal(UnitPrice_txt.Text);
            int quantity = Convert.ToInt32(Quantity_txt.Text.Trim());
            decimal totalPrice = unitPrice * quantity;
            int stockQuantity, salesQuantity;
            //
            using (main.con = new SqlConnection(main.conString))
            {
                main.cmd = new SqlCommand("[sales].[sp_InsertSales]", main.con)
                { CommandType = CommandType.StoredProcedure };
                main.cmd.Parameters.AddWithValue("@PartDesc", PartDescription_txt.Text);
                main.cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                main.cmd.Parameters.AddWithValue("@Quantity", quantity);
                main.cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                main.cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(InvoiceNo_txt.Text));
                main.cmd.Parameters.AddWithValue("@Date", SalesDate_dtp.Value);
                main.cmd.Parameters.AddWithValue("@Time", SalesDate_dtp.Value);
                main.cmd.Parameters.AddWithValue("@User", User_txt.Text);
                main.cmd.Parameters.AddWithValue("@ClientNo", Convert.ToInt32(ClientsID_txt.Text));
                main.cmd.Parameters.AddWithValue("@ClientName", ClientsName_txt.Text);
                main.cmd.Parameters.AddWithValue("@StationNo", Convert.ToInt32(StationID_txt.Text));
                main.con.Open();
                main.cmd.ExecuteNonQuery();
            }
            // update stock quantity
            stock = new Forms.Stock(PartNo, PartDescription_txt.Text);
            stockQuantity = stock.Quantity();
            salesQuantity = quantity * -1;
            stock.UpdateQuantity(PartNo, stockQuantity, salesQuantity);
        }
        //
        public string TotalPrice()
        {
            decimal total = 0, price = 0;
            foreach (DataGridViewRow dgvRow in SalesTaken_dgv.Rows)
            {
                price = Convert.ToDecimal(dgvRow.Cells["txtTotalPrice_sales"].Value);
                total += price;
            }
            if (total == 0)
                return "0.00";
            else
                return total.ToString();
        }
        //
        private void PrintCommand()
        {
            PaperSize ps = new PaperSize("custom", 580, 830); // A5 size
            PageSettings pa = new PageSettings
            { Margins = new Margins(0, 0, 0, 0) };
            PrintReceipt.DefaultPageSettings.PaperSize = ps;
            PrintReceipt.DefaultPageSettings.Margins = pa.Margins;
            printPreviewDialog1.Document = PrintReceipt;
            printPreviewDialog1.ShowDialog();
            PartDescription_txt.Focus();
        }
        //
        private void CalculatePrices()
        {
            TotalPrice_lbl.Text = TotalPrice();
            CashPaid_txt.Text = TotalPrice_lbl.Text;
            Change_txt.Text = (Convert.ToDecimal(TotalPrice_lbl.Text) - Convert.ToDecimal(CashPaid_txt.Text)).ToString();
        }
        //
        // EVENT HANDLERS
        //
        private void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                // Show the SalesTaken_dgv over the StockList_uc
                SalesTaken_dgv.BringToFront();
                // Set the sales parameters
                StationID_txt.Text = "1";
                User_txt.Text = main.Username;
                SalesDate_dtp.Value = main.TodaysDate;
                InvoiceNo_txt.Text = SalesNo().ToString();
                ClientsID_txt.Text = ClientNo().ToString();
                Fill_SalesTaken_dgv();
                CalculatePrices();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message+"\n"+ex.StackTrace, "Message", MessageBoxButtons.OK,
                MessageBoxIcon.Warning); }
        }
        //
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    DeleteFromSalesGridView();
                Fill_SalesTaken_dgv();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void Print_btn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintCommand();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void SalesTaken_dgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    Delete_btn.PerformClick();
                else
                    e.Cancel = true;
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Delete_btn.PerformClick();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to exist?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    Application.Exit();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Fill_SalesTaken_dgv();
                InvoiceNo_txt.Text = SalesNo().ToString();
                CalculatePrices();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void NewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PartDescription_txt.Enabled = true;
                PartDescription_txt.Focus();
                int topClientNo = ClientNo();
                int num = Convert.ToInt32(ClientsID_txt.Text);
                if (num < topClientNo + 1)
                {
                    int sum = topClientNo + 1;
                    ClientsID_txt.Text = sum.ToString();
                    Fill_SalesTaken_dgv();
                    CalculatePrices();
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void PreviousClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(ClientsID_txt.Text);
                if (num > 1)
                {
                    int sum = num - 1;
                    ClientsID_txt.Text = sum.ToString();
                    Fill_SalesTaken_dgv();
                    CalculatePrices();
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void NextClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int topClientNo = ClientNo();
                int num = Convert.ToInt32(ClientsID_txt.Text);
                if (num < topClientNo)
                {
                    int sum = num + 1;
                    ClientsID_txt.Text = sum.ToString();
                    Fill_SalesTaken_dgv();
                    CalculatePrices();
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PrintCommand();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                        PartNo = StockList_uc.PartNo;
                        PartDescription_txt.Text = StockList_uc.PartDescription;
                        UnitPrice_txt.Text = StockList_uc.UnitPrice.ToString();
                        Discount_txt.Text = StockList_uc.Discount.ToString();
                        TaxVART_txt.Text = StockList_uc.TaxVart.ToString();
                        SalesTaken_dgv.BringToFront();
                        Quantity_txt.Focus();
                    }
                    else
                    {
                        Quantity_txt.Text = UnitPrice_txt.Text = Discount_txt.Text = TaxVART_txt.Text = "";
                        PartDescription_txt.Focus();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void ItemName_txt_KeyDown(object sender, KeyEventArgs e)
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
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        PartDescription_txt.Text = Quantity_txt.Text = UnitPrice_txt.Text = Discount_txt.Text =
                            TaxVART_txt.Text = Change_txt.Text = CashPaid_txt.Text = "";
                        CalculatePrices();
                        PartDescription_txt.Focus();
                        StockList_lbl.Visible = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void Quantity_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddDailySales();
                    Fill_SalesTaken_dgv();
                    CalculatePrices();
                    InvoiceNo_txt.Text = SalesNo().ToString();
                    PartDescription_txt.Text = Quantity_txt.Text = UnitPrice_txt.Text = Discount_txt.Text =
                        TaxVART_txt.Text = Change_txt.Text = CashPaid_txt.Text = "";
                    PartDescription_txt.Focus();
                }
                else if(e.KeyCode == Keys.Escape)
                {
                    if (MessageBox.Show("Do you want to abort the process?", "Abort", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                         MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        PartDescription_txt.Text = Quantity_txt.Text = UnitPrice_txt.Text = Discount_txt.Text =
                            TaxVART_txt.Text = Change_txt.Text = CashPaid_txt.Text = "";
                        CalculatePrices();
                        PartDescription_txt.Focus();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message+"\n"+ex.StackTrace, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char ch = e.KeyChar;
                if (char.IsLetter(ch))
                {
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void CashPaid_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Change_txt.Text = (Convert.ToDecimal(TotalPrice_lbl.Text) - Convert.ToDecimal(CashPaid_txt.Text)).ToString();
                    TotalPrice_lbl.Text = (Convert.ToDecimal(Change_txt.Text) + Convert.ToDecimal(CashPaid_txt.Text)).ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void PrintReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Main mainForm = new Main();
                string title = mainForm.Company_Name;
                string tel = "+233506869924/+233248625101";
                string location = mainForm.Branch;
                string invoiceNo = ClientsID_txt.Text;
                string header1 = "Item", header2 = "Qtn", header3 = "Price (¢)";
                string byeMessage = "THANK YOU FOR SHOPPING WITH US";
                string slogan = "The value of life";
                string cautionMessage = "*** Items sold are NOT RETURNABLE";
                string lastMessage = "You were served by " + User_txt.Text;
                //
                e.Graphics.DrawString(title, new Font("Arial", 20, FontStyle.Bold),
                    Brushes.Black, new Point(100, 10));
                e.Graphics.DrawString(location, new Font("Arial", 10, FontStyle.Regular),
                    Brushes.Black, new Point(150, 50));
                e.Graphics.DrawString(tel, new Font("Arial", 12, FontStyle.Regular),
                    Brushes.Black, new Point(105, 70));
                //
                e.Graphics.DrawString("INVOICE: " + invoiceNo, new Font("Times New Roman", 12, FontStyle.Regular),
                    Brushes.Black, new Point(10, 120));
                e.Graphics.DrawString("DATE: " + SalesDate_dtp.Value, new Font("Times New Roman", 12, FontStyle.Regular),
                    Brushes.Black, new Point(200, 120));
                //
                e.Graphics.DrawString("--------------------------------------------------------------------------------------------",
                    new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, 150));
                e.Graphics.DrawString(header1, new Font("Times New Roman", 12, FontStyle.Bold),
                    Brushes.Black, new Point(10, 175));
                e.Graphics.DrawString(header2, new Font("Times New Roman", 12, FontStyle.Bold),
                    Brushes.Black, new Point(410, 175));
                e.Graphics.DrawString(header3, new Font("Times New Roman", 12, FontStyle.Bold),
                    Brushes.Black, new Point(450, 175));
                //
                int i = 1, colInd = 200;
                foreach (DataGridViewRow dgvRow in SalesTaken_dgv.Rows)
                {
                    e.Graphics.DrawString(dgvRow.Cells[3].Value.ToString(), new Font("Times New Roman", 12,
                        FontStyle.Regular), Brushes.Black, new Point(10, colInd));
                    e.Graphics.DrawString(dgvRow.Cells[4].Value.ToString(), new Font("Times New Roman", 12,
                        FontStyle.Regular), Brushes.Black, new Point(410, colInd));
                    e.Graphics.DrawString(dgvRow.Cells[8].Value.ToString(), new Font("Times New Roman", 12,
                        FontStyle.Regular), Brushes.Black, new Point(450, colInd));
                    i++;
                    colInd += 30;
                }
                //
                e.Graphics.DrawString("--------------------------------------------------------------------------------------------",
                    new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, colInd));
                e.Graphics.DrawString("TOTAL (GH¢)", new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(250, colInd + 20));
                e.Graphics.DrawString(TotalPrice_lbl.Text, new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(450, colInd + 20));
                e.Graphics.DrawString("CASH PAID (GH¢)", new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(250, colInd + 50));
                e.Graphics.DrawString(CashPaid_txt.Text, new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(450, colInd + 50));
                e.Graphics.DrawString("CHANGE (GH¢)", new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(250, colInd + 80));
                e.Graphics.DrawString(Change_txt.Text, new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(450, colInd + 80));
                //
                e.Graphics.DrawString("--------------------------------------------------------------------------------------------",
                    new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, colInd + 110));
                e.Graphics.DrawString(byeMessage, new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(50, colInd + 140));
                e.Graphics.DrawString(cautionMessage, new Font("Times New Roman", 12,
                    FontStyle.Bold), Brushes.Black, new Point(50, colInd + 170));
                e.Graphics.DrawString(lastMessage, new Font("Times New Roman", 12,
                    FontStyle.Regular), Brushes.Black, new Point(50, colInd + 200));
                e.Graphics.DrawString("--------------------------------------------------------------------------------------------",
                    new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, colInd + 230));
                e.Graphics.DrawString(slogan, new Font("Times New Roman", 12,
                    FontStyle.Italic), Brushes.Black, new Point(100, colInd + 250));
                e.HasMorePages = false;
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
