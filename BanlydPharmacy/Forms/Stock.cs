using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace BanlydPharmacy.Forms
{
    public partial class Stock : Form
    {
        // GLOBAL VARIABLES
        public Main main;
        string command, ItemName;
        int PartNo;
        string navigateText;
        bool navigateClicked;
        // DEFAULT CONSTRUCTOOR
        public Stock()
        {
            InitializeComponent();
            InitialiseMyComponents();
            navigateText = "Stock Entry";
            navigateClicked = false;
            main = new Main();
        }
        // OVERLOADED CONSTRUCTOR
        public Stock(int PartNo, string ItemName)
        {
            this.PartNo = PartNo;
            this.ItemName = ItemName;
            main = new Main();
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        public int Quantity()
        {
            int quantity = 0;
            command = "SELECT * FROM stock.Quantity WHERE PartNo = '" + PartNo + "'";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            foreach (DataRow dr in main.dt.Rows)
                quantity = Convert.ToInt32(dr["TotalQty"]);
            return quantity;
        }
        //
        public decimal UpdateQuantity(int partNo, int qtnAtHand, int qtnToAdd)
        {
            using (main.con = new SqlConnection(main.conString))
            {
                main.cmd = new SqlCommand("[stock].[sp_UpdateQuantities]", main.con)
                { CommandType = CommandType.StoredProcedure };
                main.cmd.Parameters.AddWithValue("@PartNo", partNo);
                main.cmd.Parameters.AddWithValue("@QtyAtHand", qtnAtHand);
                main.cmd.Parameters.AddWithValue("@QtyToAdd", qtnToAdd);
                main.con.Open();
                main.cmd.ExecuteNonQuery();
            }
            return qtnAtHand + qtnToAdd;
        }
        //
        public int GetPartNumber(string description)
        {
            int PartNo = 0;
            command = " SELECT PartNo FROM [stock].[Groups] WHERE PartDescription = '"+ description + "'";
            main.cmd = new SqlCommand(command, main.con);
            main.da = new SqlDataAdapter(main.cmd);
            main.dt = new DataTable();
            main.da.Fill(main.dt);
            foreach (DataRow dr in main.dt.Rows)
                PartNo = Convert.ToInt32(dr["PartNo"]);
            return PartNo;
        }
        //
        // EVENT HANDLERS
        //
        private void Stock_Load(object sender, EventArgs e)
        {
            try
            {
                Navigate_lbl.Text = "Hide 🤦‍♂️";
                Navigate_tlp.Controls.Add(Highlight_pnl, 0, 0);
                UC.StockEntry stockEntry = new UC.StockEntry();
                Main_pnl.Controls.Add(stockEntry);
                stockEntry.Dock = DockStyle.Fill;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error"); }
        }
        //
        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exist?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }
        //
        private void Navigate_picb_Click(object sender, EventArgs e)
        {
            if (navigateClicked)
            {
                Main_tlp.Controls.Add(Free_pnl, 0, 1);
                Main_tlp.SetColumn(Navigate_tlp, 1);
                Main_tlp.SetColumn(Main_pnl, 2);
                Navigate_tlp.BackColor = SystemColors.InactiveCaption;
                Navigate_picb.BackColor = SystemColors.InactiveCaption;
                Navigate_lbl.Text = "Hide 🤦‍♂️";
                Navigate_lbl.BackColor = SystemColors.InactiveCaption;
                navigateClicked = false;
                //
                StockEntry_btn.TextAlign = ContentAlignment.MiddleLeft;
                AdjustPrices_btn.TextAlign = ContentAlignment.MiddleLeft;
                ModifyNames_btn.TextAlign = ContentAlignment.MiddleLeft;
                AddItem_btn.TextAlign = ContentAlignment.MiddleLeft;
                GroupMaintenace_btn.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                Main_tlp.Controls.Remove(Free_pnl);
                Main_tlp.SetColumn(Navigate_tlp, 0);
                Main_tlp.SetColumn(Main_pnl, 1);
                Navigate_tlp.BackColor = SystemColors.ActiveCaption;
                Navigate_picb.BackColor = SystemColors.ActiveCaption;
                Navigate_lbl.Text = navigateText;
                Navigate_lbl.BackColor = SystemColors.ActiveCaption;
                navigateClicked = true;
                //
                StockEntry_btn.TextAlign = ContentAlignment.MiddleCenter;
                AdjustPrices_btn.TextAlign = ContentAlignment.MiddleCenter;
                ModifyNames_btn.TextAlign = ContentAlignment.MiddleCenter;
                AddItem_btn.TextAlign = ContentAlignment.MiddleCenter;
                GroupMaintenace_btn.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
        //
        private void StockEntry_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Stock Entry";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 0);
            UC.StockEntry stockEntry = new UC.StockEntry();
            Main_pnl.Controls.Add(stockEntry);
            stockEntry.Dock = DockStyle.Fill;
        }
        //
        private void AjustPrices_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Adjust Prices";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 1);
        }
        //
        private void ModifyNames_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Modify Item Names";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 2);
        }
        //
        private void AddItem_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Add or Remove Items";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 3);
        }
        //
        private void GroupMaintenace_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Group Maintenance";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 4);
        }
        //
        private void ExpiryDates_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Expiry Dates";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 5);
        }
        //
        private void Suppliers_btn_Click(object sender, EventArgs e)
        {
            navigateText = "Suppliers";
            Navigate_lbl.Text = navigateText;
            Navigate_tlp.Controls.Add(Highlight_pnl, 0, 6);
        }
    }
}
