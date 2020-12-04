using System.Drawing;
using System.Windows.Forms;

namespace BanlydPharmacy
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.SalesDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.PartDescription_txt = new System.Windows.Forms.TextBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sales_cmstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label33 = new System.Windows.Forms.Label();
            this.Change_txt = new System.Windows.Forms.TextBox();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TotalPrice_lbl = new System.Windows.Forms.Label();
            this.UnitPrice_txt = new System.Windows.Forms.TextBox();
            this.ClientsID_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TaxVART_txt = new System.Windows.Forms.TextBox();
            this.Discount_txt = new System.Windows.Forms.TextBox();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientsName_txt = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InvoiceNo_txt = new System.Windows.Forms.TextBox();
            this.StationID_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CashPaid_txt = new System.Windows.Forms.TextBox();
            this.Print_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintReceipt = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Sales_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Dgv_pnl = new System.Windows.Forms.Panel();
            this.Sales_cmstrip.SuspendLayout();
            this.Sales_tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesDate_dtp
            // 
            this.SalesDate_dtp.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.SalesDate_dtp, 2);
            this.SalesDate_dtp.Cursor = System.Windows.Forms.Cursors.No;
            this.SalesDate_dtp.CustomFormat = "yyyy-MM-dd";
            this.SalesDate_dtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesDate_dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SalesDate_dtp.Location = new System.Drawing.Point(778, 23);
            this.SalesDate_dtp.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.SalesDate_dtp.Name = "SalesDate_dtp";
            this.Sales_tlp.SetRowSpan(this.SalesDate_dtp, 2);
            this.SalesDate_dtp.ShowUpDown = true;
            this.SalesDate_dtp.Size = new System.Drawing.Size(191, 26);
            this.SalesDate_dtp.TabIndex = 77;
            this.SalesDate_dtp.TabStop = false;
            // 
            // PartDescription_txt
            // 
            this.PartDescription_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.PartDescription_txt, 4);
            this.PartDescription_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartDescription_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescription_txt.Location = new System.Drawing.Point(3, 103);
            this.PartDescription_txt.Name = "PartDescription_txt";
            this.Sales_tlp.SetRowSpan(this.PartDescription_txt, 2);
            this.PartDescription_txt.Size = new System.Drawing.Size(284, 26);
            this.PartDescription_txt.TabIndex = 1;
            this.PartDescription_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemName_txt_KeyDown);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.refresh_40634;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.refreshToolStripMenuItem.Text = "Refresh Sales";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.apps_printer_15747;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.images__1_1;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // Sales_cmstrip
            // 
            this.Sales_cmstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.newClientToolStripMenuItem,
            this.nextClientToolStripMenuItem,
            this.previousClientToolStripMenuItem,
            this.printToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.Sales_cmstrip.Name = "contextMenuStrip1";
            this.Sales_cmstrip.Size = new System.Drawing.Size(173, 158);
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.shopping_basket_add256_24909_1_;
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newClientToolStripMenuItem.Text = "New Client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.NewClientToolStripMenuItem_Click);
            // 
            // nextClientToolStripMenuItem
            // 
            this.nextClientToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.ic_arrow_forward_128_28222;
            this.nextClientToolStripMenuItem.Name = "nextClientToolStripMenuItem";
            this.nextClientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.nextClientToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nextClientToolStripMenuItem.Text = "Next Client";
            this.nextClientToolStripMenuItem.Click += new System.EventHandler(this.NextClientToolStripMenuItem_Click);
            // 
            // previousClientToolStripMenuItem
            // 
            this.previousClientToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.ic_arrow_back_128_28226;
            this.previousClientToolStripMenuItem.Name = "previousClientToolStripMenuItem";
            this.previousClientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.previousClientToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.previousClientToolStripMenuItem.Text = "Previous Client";
            this.previousClientToolStripMenuItem.Click += new System.EventHandler(this.PreviousClientToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.erase_delete_remove_wipe_out_512;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label33.Location = new System.Drawing.Point(487, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 20);
            this.label33.TabIndex = 109;
            this.label33.Text = "User";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Change_txt
            // 
            this.Change_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.Change_txt, 2);
            this.Change_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Change_txt.Enabled = false;
            this.Change_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_txt.Location = new System.Drawing.Point(148, 283);
            this.Change_txt.Name = "Change_txt";
            this.Sales_tlp.SetRowSpan(this.Change_txt, 2);
            this.Change_txt.Size = new System.Drawing.Size(139, 26);
            this.Change_txt.TabIndex = 91;
            this.Change_txt.TabStop = false;
            // 
            // User_txt
            // 
            this.User_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.User_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_txt.Enabled = false;
            this.User_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_txt.Location = new System.Drawing.Point(487, 23);
            this.User_txt.Name = "User_txt";
            this.Sales_tlp.SetRowSpan(this.User_txt, 2);
            this.User_txt.Size = new System.Drawing.Size(91, 19);
            this.User_txt.TabIndex = 81;
            this.User_txt.TabStop = false;
            this.User_txt.Text = "username";
            this.User_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(148, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 106;
            this.label13.Text = "Change (GHc)";
            // 
            // TotalPrice_lbl
            // 
            this.TotalPrice_lbl.AutoSize = true;
            this.TotalPrice_lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.TotalPrice_lbl, 3);
            this.TotalPrice_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalPrice_lbl.Font = new System.Drawing.Font("Franklin Gothic Heavy", 42F);
            this.TotalPrice_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalPrice_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TotalPrice_lbl.Location = new System.Drawing.Point(100, 320);
            this.TotalPrice_lbl.Name = "TotalPrice_lbl";
            this.Sales_tlp.SetRowSpan(this.TotalPrice_lbl, 4);
            this.TotalPrice_lbl.Size = new System.Drawing.Size(187, 96);
            this.TotalPrice_lbl.TabIndex = 104;
            this.TotalPrice_lbl.Text = "0.00";
            this.TotalPrice_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitPrice_txt
            // 
            this.UnitPrice_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.UnitPrice_txt, 2);
            this.UnitPrice_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPrice_txt.Enabled = false;
            this.UnitPrice_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice_txt.Location = new System.Drawing.Point(148, 163);
            this.UnitPrice_txt.Name = "UnitPrice_txt";
            this.Sales_tlp.SetRowSpan(this.UnitPrice_txt, 2);
            this.UnitPrice_txt.Size = new System.Drawing.Size(139, 26);
            this.UnitPrice_txt.TabIndex = 5;
            this.UnitPrice_txt.TabStop = false;
            // 
            // ClientsID_txt
            // 
            this.ClientsID_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientsID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sales_tlp.SetColumnSpan(this.ClientsID_txt, 2);
            this.ClientsID_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsID_txt.Enabled = false;
            this.ClientsID_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.ClientsID_txt.ForeColor = System.Drawing.Color.Black;
            this.ClientsID_txt.Location = new System.Drawing.Point(322, 23);
            this.ClientsID_txt.Name = "ClientsID_txt";
            this.Sales_tlp.SetRowSpan(this.ClientsID_txt, 2);
            this.ClientsID_txt.Size = new System.Drawing.Size(159, 20);
            this.ClientsID_txt.TabIndex = 86;
            this.ClientsID_txt.TabStop = false;
            this.ClientsID_txt.Text = "1";
            this.ClientsID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(148, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Unit Price (GHc)";
            // 
            // TaxVART_txt
            // 
            this.TaxVART_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.TaxVART_txt, 2);
            this.TaxVART_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaxVART_txt.Enabled = false;
            this.TaxVART_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxVART_txt.Location = new System.Drawing.Point(148, 223);
            this.TaxVART_txt.Name = "TaxVART_txt";
            this.Sales_tlp.SetRowSpan(this.TaxVART_txt, 2);
            this.TaxVART_txt.Size = new System.Drawing.Size(139, 26);
            this.TaxVART_txt.TabIndex = 84;
            this.TaxVART_txt.TabStop = false;
            // 
            // Discount_txt
            // 
            this.Discount_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.Discount_txt, 2);
            this.Discount_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Discount_txt.Enabled = false;
            this.Discount_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_txt.Location = new System.Drawing.Point(3, 223);
            this.Discount_txt.Name = "Discount_txt";
            this.Sales_tlp.SetRowSpan(this.Discount_txt, 2);
            this.Discount_txt.Size = new System.Drawing.Size(139, 26);
            this.Discount_txt.TabIndex = 85;
            this.Discount_txt.TabStop = false;
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.Quantity_txt, 2);
            this.Quantity_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Quantity_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_txt.Location = new System.Drawing.Point(3, 163);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Sales_tlp.SetRowSpan(this.Quantity_txt, 2);
            this.Quantity_txt.Size = new System.Drawing.Size(139, 26);
            this.Quantity_txt.TabIndex = 4;
            this.Quantity_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quantity_txt_KeyDown);
            this.Quantity_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_txt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(148, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 101;
            this.label10.Text = "Tax / Vat (GHc)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "Discount (GHc)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 103;
            this.label3.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 320);
            this.label5.Name = "label5";
            this.Sales_tlp.SetRowSpan(this.label5, 4);
            this.label5.Size = new System.Drawing.Size(91, 96);
            this.label5.TabIndex = 105;
            this.label5.Text = "Total Cash (GHc)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(778, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Today\'s  Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label6, 4);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Client\'s Name";
            // 
            // ClientsName_txt
            // 
            this.ClientsName_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.ClientsName_txt, 4);
            this.ClientsName_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsName_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsName_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsName_txt.ForeColor = System.Drawing.Color.Black;
            this.ClientsName_txt.FormattingEnabled = true;
            this.ClientsName_txt.Location = new System.Drawing.Point(3, 23);
            this.ClientsName_txt.Name = "ClientsName_txt";
            this.Sales_tlp.SetRowSpan(this.ClientsName_txt, 2);
            this.ClientsName_txt.Size = new System.Drawing.Size(284, 27);
            this.ClientsName_txt.TabIndex = 112;
            this.ClientsName_txt.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(681, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 20);
            this.label35.TabIndex = 108;
            this.label35.Text = "Station No.";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(584, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(91, 20);
            this.label28.TabIndex = 112;
            this.label28.Text = "Invoice";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(322, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Client\'s ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvoiceNo_txt
            // 
            this.InvoiceNo_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InvoiceNo_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceNo_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceNo_txt.Enabled = false;
            this.InvoiceNo_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNo_txt.Location = new System.Drawing.Point(584, 23);
            this.InvoiceNo_txt.Name = "InvoiceNo_txt";
            this.Sales_tlp.SetRowSpan(this.InvoiceNo_txt, 2);
            this.InvoiceNo_txt.Size = new System.Drawing.Size(91, 19);
            this.InvoiceNo_txt.TabIndex = 78;
            this.InvoiceNo_txt.TabStop = false;
            this.InvoiceNo_txt.Text = "1";
            this.InvoiceNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StationID_txt
            // 
            this.StationID_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StationID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StationID_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StationID_txt.Enabled = false;
            this.StationID_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationID_txt.Location = new System.Drawing.Point(681, 23);
            this.StationID_txt.Name = "StationID_txt";
            this.Sales_tlp.SetRowSpan(this.StationID_txt, 2);
            this.StationID_txt.Size = new System.Drawing.Size(91, 19);
            this.StationID_txt.TabIndex = 82;
            this.StationID_txt.TabStop = false;
            this.StationID_txt.Text = "1";
            this.StationID_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(3, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 107;
            this.label12.Text = "Cash Paid (GHc)";
            // 
            // CashPaid_txt
            // 
            this.CashPaid_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sales_tlp.SetColumnSpan(this.CashPaid_txt, 2);
            this.CashPaid_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CashPaid_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaid_txt.Location = new System.Drawing.Point(3, 283);
            this.CashPaid_txt.Name = "CashPaid_txt";
            this.Sales_tlp.SetRowSpan(this.CashPaid_txt, 2);
            this.CashPaid_txt.Size = new System.Drawing.Size(139, 26);
            this.CashPaid_txt.TabIndex = 90;
            this.CashPaid_txt.TabStop = false;
            this.CashPaid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashPaid_txt_KeyDown);
            // 
            // Print_btn
            // 
            this.Print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Print_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sales_tlp.SetColumnSpan(this.Print_btn, 2);
            this.Print_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Print_btn.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.Print_btn.ForeColor = System.Drawing.Color.White;
            this.Print_btn.Location = new System.Drawing.Point(778, 375);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(191, 38);
            this.Print_btn.TabIndex = 93;
            this.Print_btn.TabStop = false;
            this.Print_btn.Text = "Print (Ctrl+P)";
            this.Print_btn.UseVisualStyleBackColor = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.Color.Maroon;
            this.Delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sales_tlp.SetColumnSpan(this.Delete_btn, 2);
            this.Delete_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_btn.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Delete_btn.Location = new System.Drawing.Point(487, 375);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(188, 38);
            this.Delete_btn.TabIndex = 93;
            this.Delete_btn.TabStop = false;
            this.Delete_btn.Text = "&Delete (Del)";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.save_21411;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // PrintReceipt
            // 
            this.PrintReceipt.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintReceipt_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Sales_tlp
            // 
            this.Sales_tlp.ColumnCount = 12;
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Sales_tlp.Controls.Add(this.label6, 0, 0);
            this.Sales_tlp.Controls.Add(this.ClientsName_txt, 0, 1);
            this.Sales_tlp.Controls.Add(this.SalesDate_dtp, 9, 1);
            this.Sales_tlp.Controls.Add(this.label4, 9, 0);
            this.Sales_tlp.Controls.Add(this.label35, 8, 0);
            this.Sales_tlp.Controls.Add(this.StationID_txt, 8, 1);
            this.Sales_tlp.Controls.Add(this.label28, 7, 0);
            this.Sales_tlp.Controls.Add(this.InvoiceNo_txt, 7, 1);
            this.Sales_tlp.Controls.Add(this.label33, 6, 0);
            this.Sales_tlp.Controls.Add(this.User_txt, 6, 1);
            this.Sales_tlp.Controls.Add(this.label7, 5, 0);
            this.Sales_tlp.Controls.Add(this.ClientsID_txt, 5, 1);
            this.Sales_tlp.Controls.Add(this.label3, 0, 7);
            this.Sales_tlp.Controls.Add(this.Quantity_txt, 0, 8);
            this.Sales_tlp.Controls.Add(this.label9, 0, 10);
            this.Sales_tlp.Controls.Add(this.Discount_txt, 0, 11);
            this.Sales_tlp.Controls.Add(this.label12, 0, 13);
            this.Sales_tlp.Controls.Add(this.CashPaid_txt, 0, 14);
            this.Sales_tlp.Controls.Add(this.label13, 2, 13);
            this.Sales_tlp.Controls.Add(this.Change_txt, 2, 14);
            this.Sales_tlp.Controls.Add(this.TaxVART_txt, 2, 11);
            this.Sales_tlp.Controls.Add(this.label10, 2, 10);
            this.Sales_tlp.Controls.Add(this.UnitPrice_txt, 2, 8);
            this.Sales_tlp.Controls.Add(this.label8, 2, 7);
            this.Sales_tlp.Controls.Add(this.TotalPrice_lbl, 1, 16);
            this.Sales_tlp.Controls.Add(this.label5, 0, 16);
            this.Sales_tlp.Controls.Add(this.PartDescription_txt, 0, 5);
            this.Sales_tlp.Controls.Add(this.label1, 0, 4);
            this.Sales_tlp.Controls.Add(this.Delete_btn, 7, 19);
            this.Sales_tlp.Controls.Add(this.Print_btn, 10, 19);
            this.Sales_tlp.Controls.Add(this.Dgv_pnl, 5, 4);
            this.Sales_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sales_tlp.Location = new System.Drawing.Point(10, 10);
            this.Sales_tlp.Name = "Sales_tlp";
            this.Sales_tlp.RowCount = 20;
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Sales_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Sales_tlp.Size = new System.Drawing.Size(972, 416);
            this.Sales_tlp.TabIndex = 118;
            // 
            // Dgv_pnl
            // 
            this.Sales_tlp.SetColumnSpan(this.Dgv_pnl, 7);
            this.Dgv_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_pnl.Location = new System.Drawing.Point(322, 83);
            this.Dgv_pnl.Name = "Dgv_pnl";
            this.Sales_tlp.SetRowSpan(this.Dgv_pnl, 15);
            this.Dgv_pnl.Size = new System.Drawing.Size(647, 286);
            this.Dgv_pnl.TabIndex = 113;
            // 
            // Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 436);
            this.ContextMenuStrip = this.Sales_cmstrip;
            this.ControlBox = false;
            this.Controls.Add(this.Sales_tlp);
            this.Name = "Sales";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Point of Sales";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.Sales_cmstrip.ResumeLayout(false);
            this.Sales_tlp.ResumeLayout(false);
            this.Sales_tlp.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region User defined functions
        // Call the user-defined components
        private void InitialiseMyComponents()
        {
            Initialise_SalesTaken_dgv();
            Initialise_StockList_uc();
            Initialise_OtherControls();
        }
        //
        private void Initialise_SalesTaken_dgv()
        {
            DataGridViewColumnHeaderStyle_dgv();
            DataGridViewDefaultSyle_dgv();
            // Intantiate the StockTaken_dgv class annd set the necessary properties
            SalesTaken_dgv = new DataGridView()
            {
                Name = "SalesTaken_dgv",
                Size = new Size(676, 294),
                Location = new Point(293, 63),
                Dock = DockStyle.Fill,
                GridColor = Color.Lime,
                AllowUserToAddRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                BackgroundColor = SystemColors.ActiveCaption,
                BorderStyle = BorderStyle.None,
                ColumnHeadersDefaultCellStyle = style1,
                DefaultCellStyle = style2,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single,
                RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing,
                TabStop = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            // Define the datagridview columns
            SetCheckColumn();
            SetPartDescColumn();
            SetUnitPriceColumn();
            SetQuantityColumn();
            SetTotalPriceColumn();
            // Add the defined columns to the StockTaken_dgv
            this.SalesTaken_dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                this.cbCheck_sales,
                this.txtPartDescription_sales,
                this.txtUnitPrice_sales,
                this.txtQuantity_sales,
                this.txtTotalPrice_sales
            });
            // Add the SalesTaken_dgv to the Dgv_pnl panel
            Dgv_pnl.Controls.Add(SalesTaken_dgv);
            SalesTaken_dgv.Dock = DockStyle.Fill;
            // Add the necessary Event Handlers
            this.SalesTaken_dgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(this.SalesTaken_dgv_UserDeletingRow);
        }
        //
        private void Initialise_StockList_uc()
        {
            StockList_uc = new UC.StockList()
            {
                Name = "StockList_uc",
                Dock = DockStyle.Fill
            };
            // Add the StockList_uc to the Dgv_pnl panel
            Dgv_pnl.Controls.Add(StockList_uc);
            StockList_uc.Dock = DockStyle.Fill;
            // ADD EVENT HANDLERS
            StockList_uc.VisibleChanged += new System.EventHandler(this.StockList_uc_VisibleChanged);
        }
        //
        private void Initialise_OtherControls()
        {
            StockList_lbl = new Label()
            {
                Name = "StockList_lbl",
                Text = "Stock List",
                ForeColor = Color.Crimson,
                Font = new Font("Franklin Gothic Heavy", 16F, FontStyle.Bold),
                AutoSize = false,
                Visible = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            // Add the lable to the table layout panel
            Sales_tlp.Controls.Add(StockList_lbl, 5, 3);
            Sales_tlp.SetColumnSpan(StockList_lbl, 7);
        }
        #endregion User defined functions

        #region user defined controls
        private void SetCheckColumn()
        {
            cbCheck_sales = new DataGridViewCheckBoxColumn()
            {
                Name = "cbCheck_sales",
                HeaderText = "",
                DataPropertyName = "",
                ReadOnly = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
        }
        //
        private void SetPartDescColumn()
        {
            txtPartDescription_sales = new DataGridViewTextBoxColumn()
            {
                Name = "txtPartDescription_sales",
                HeaderText = "Description",
                DataPropertyName = "PartDescription",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }
        //
        private void SetUnitPriceColumn()
        {
            txtUnitPrice_sales = new DataGridViewTextBoxColumn()
            {
                Name = "txtUntPrice_sales",
                HeaderText = "Unit Price",
                DataPropertyName = "UnitPrice",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void SetQuantityColumn()
        {
            txtQuantity_sales = new DataGridViewTextBoxColumn()
            {
                Name = "txtQuantity_sales",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void SetTotalPriceColumn()
        {
            txtTotalPrice_sales = new DataGridViewTextBoxColumn()
            {
                Name = "txtTotalPrice_sales",
                HeaderText = "Total Price",
                DataPropertyName = "TotalPrice",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void DataGridViewColumnHeaderStyle_dgv()
        {
            style1 = new System.Windows.Forms.DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Control,
                Font = new Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };
        }
        //
        private void DataGridViewDefaultSyle_dgv()
        {
            style2 = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = SystemColors.Window,
                Font = new Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular),
                ForeColor = SystemColors.ControlText,
                SelectionBackColor = Color.Coral,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.False
            };
        }
        #endregion

        private System.Windows.Forms.DateTimePicker SalesDate_dtp;
        private System.Windows.Forms.TextBox PartDescription_txt;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Sales_cmstrip;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox Change_txt;
        private System.Windows.Forms.TextBox User_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label TotalPrice_lbl;
        private System.Windows.Forms.TextBox UnitPrice_txt;
        private System.Windows.Forms.TextBox ClientsID_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TaxVART_txt;
        private System.Windows.Forms.TextBox Discount_txt;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox InvoiceNo_txt;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox StationID_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CashPaid_txt;
        private System.Windows.Forms.ComboBox ClientsName_txt;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button Print_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousClientToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument PrintReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem nextClientToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel Sales_tlp;
        // OPTIONAL CONTROLS
        private DataGridView SalesTaken_dgv;
        private DataGridViewCellStyle style1;
        private DataGridViewCellStyle style2;
        private DataGridViewCheckBoxColumn cbCheck_sales;
        private DataGridViewTextBoxColumn txtPartDescription_sales;
        private DataGridViewTextBoxColumn txtUnitPrice_sales;
        private DataGridViewTextBoxColumn txtQuantity_sales;
        private DataGridViewTextBoxColumn txtTotalPrice_sales;
        // ADD THE STOCKLIST USERCONTROL
        private UC.StockList StockList_uc;
        private Panel Dgv_pnl;
        private Label StockList_lbl;
    }
}