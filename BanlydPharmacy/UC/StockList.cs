using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanlydPharmacy.UC
{
    public partial class StockList : UserControl
    {
        // GLOBAL VARIABLES
        Main main = new Main();
        string command;
        // DEFAULT CONSTRUCTOR
        public StockList()
        {
            InitializeComponent();
            EnterPressed = false;
        }
        //
        // USER-DEFINED PROPERTIES
        //
        public int PartNo { get; private set; }
        public string PartDescription { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TaxVart { get; private set; }
        public int Quantity { get; private set; }
        public bool EnterPressed { get; private set; }
        public string ExpiryDates { get; private set; }
        public string Suppliers { get; private set; }
        //
        // USER DEFINED FUCTIONS
        //
        public void FillStockList(string ItemName)
        {
            command = "Select PartNo, PartDescription, TotalQty, UnitPrice, Supplier, ExpiryDates from [stock].[vStockList]" +
                " WHERE PartDescription LIKE '" + ItemName + "%' ORDER BY PartDescription ";
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            StockList_dgv.DataSource = main.dt;
        }
        //
        private (decimal, decimal) GetDiscountAndTax(int partNo)
        {
            decimal discount = 0, tax = 0;
            command = "Select Discount, TaxVart from [stock].[vStockList] WHERE PartNo = '" + partNo + "' ";
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            foreach (DataRow dr in main.dt.Rows)
            {
                discount = Convert.ToDecimal(dr["Discount"]);
                tax = Convert.ToDecimal(dr["TaxVart"]);
            }
            return (discount, tax);
        }
        private void GetCurrentRowData()
        {
            DataGridViewRow dgvRow = StockList_dgv.CurrentRow;
            PartNo = Convert.ToInt32(dgvRow.Cells["txtPartNo"].Value);
            PartDescription = dgvRow.Cells["txtPartDescription"].Value.ToString();
            UnitPrice = Convert.ToDecimal(dgvRow.Cells["txtUnitPrice"].Value);
            Discount = GetDiscountAndTax(PartNo).Item1;
            TaxVart = GetDiscountAndTax(PartNo).Item2;
            Quantity = Convert.ToInt32(dgvRow.Cells["txtQuantity"].Value);
            ExpiryDates = dgvRow.Cells["txtExpiryDate"].Value.ToString();
            Suppliers = dgvRow.Cells["txtSupplier"].Value.ToString();
        }
        //
        // EVENT HANDLERS
        //
        private void StockList_Load(object sender, EventArgs e)
        {
            try
            {
                StockList_dgv.Focus();
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        //
        private void StockList_dgv_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Get the current row data and set the visibility and the enter flags
                // Visibility is always true untill the Enter or Escape keys are pressed on the dgv
                if (e.KeyCode == Keys.Enter)
                {
                    GetCurrentRowData();
                    EnterPressed = true;
                    this.Visible = false;
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    EnterPressed = false;
                    this.Visible = false;
                }
                else
                    this.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(null + ex.Message+ex.StackTrace, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
