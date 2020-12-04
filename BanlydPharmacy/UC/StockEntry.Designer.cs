using System;
using System.Drawing;
using System.Windows.Forms;

namespace BanlydPharmacy.UC
{
    partial class StockEntry
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

        #region Initialise function
        // Call the user-defined components
        private void InitialiseMyComponents()
        {
            Initialise_StockTaken_dgv();
            Initialise_StockList_uc();
            Initialise_OtherControls();
        }
        #endregion Initialise function

        #region USER-DEFINED FUNCTIONS
        private void Initialise_StockTaken_dgv()
        {
            DataGridViewColumnHeaderStyle_dgv();
            DataGridViewDefaultSyle_dgv();
            // Intantiate the StockTaken_dgv class annd set the necessary properties
            StockTaken_dgv = new DataGridView()
            {
                Name = "StockTaken_dgv",
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
            SetQuantityColumn();
            SetExpiryDatesColumn();
            SetSuppliersColumn();
            // Add the defined columns to the StockTaken_dgv
            this.StockTaken_dgv.Columns.AddRange(new DataGridViewColumn[]
            {
                this.cbCheck,
                this.txtPartDescription,
                this.txtQuantity,
                this.txtExpiryDates,
                this.txtSuppliers
            });
            // Add the SalesTaken_dgv to the Dgv_pnl panel
            Main_pnl.Controls.Add(StockTaken_dgv);
            StockTaken_dgv.Dock = DockStyle.Fill;
            // Add the necessary Event Handlers
            this.StockTaken_dgv.CellClick += new DataGridViewCellEventHandler(this.StockTaken_dgv_CellClick);
           // this.StockTaken_dgv.UserDeletingRow += new DataGridViewRowCancelEventHandler(this.StockTaken_dgv_UserDeletingRow);
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
            Main_pnl.Controls.Add(StockList_uc);
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
            StockTaken_cmstrip = new ContextMenuStrip()
            {
                Name = "StockTaken_cmstrip",
                Size = new Size(173, 158)
            };
            // Initialise the menu items of the StockTaken_dgv Context Menu Strip
            SetRefresh_toolStrip();
            SetNewStock_toolStrip();
            SetPreviousStock_toolStrip();
            SetDelete_toolStrip();
            // Add them to the StockTaken_cmstrip
            this.StockTaken_cmstrip.Items.AddRange(new ToolStripItem[]
            {
               Refresh_tstrp, NewStock_tstrip, PreviousStock_tstrip, Delete_tstrip
            });
            // Add the controls to the layout
            this.Main_tlp.Controls.Add(StockList_lbl, 1, 2);
            this.Main_tlp.SetColumnSpan(StockList_lbl, 3);
            this.StockTaken_dgv.ContextMenuStrip = StockTaken_cmstrip;
        }
        #endregion USER-DEFINED FUNCTIONS

        #region USER-DEFINED CONTROLS FUNCTIONS
        private void SetCheckColumn()
        {
            cbCheck = new DataGridViewCheckBoxColumn()
            {
                Name = "cbCheck_sales",
                HeaderText = "",
                DataPropertyName = "",
                ReadOnly = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            };
        }
        //
        private void SetPartNoColumn()
        {
            txtPartNo = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PartNo",
                HeaderText = "Part No",
                Name = "txtPartNo_StockTaken",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void SetPartDescColumn()
        {
            txtPartDescription = new DataGridViewTextBoxColumn()
            {
                Name = "txtPartDescription",
                HeaderText = "Description",
                DataPropertyName = "PartDescription",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
        }
        //
        private void SetQuantityColumn()
        {
            txtQuantity = new DataGridViewTextBoxColumn()
            {
                Name = "txtQuantity",
                HeaderText = "Quantity",
                DataPropertyName = "QtyToAdd",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void SetExpiryDatesColumn()
        {
            txtExpiryDates = new DataGridViewTextBoxColumn()
            {
                Name = "txtExpiryDates",
                HeaderText = "Expiry Date",
                DataPropertyName = "ExpiryDates",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
        }
        //
        private void SetSuppliersColumn()
        {
            txtSuppliers = new DataGridViewTextBoxColumn()
            {
                Name = "txtSuppliers",
                HeaderText = "Suppliers",
                DataPropertyName = "Supplier",
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
        //
        private void SetRefresh_toolStrip()
        {
            Refresh_tstrp = new ToolStripMenuItem()
            {
                Name = "Refresh_tstrp",
                Text = "Refresh Stock List",
                ShortcutKeys = Keys.F5,
                Size = new Size(185, 22),
                Image = global::BanlydPharmacy.Properties.Resources.refresh_40634
            };
            this.Refresh_tstrp.Click += new System.EventHandler(this.Refresh_tstrp_Clicked);
        }
        //
        private void SetNewStock_toolStrip()
        {
            NewStock_tstrip = new ToolStripMenuItem()
            {
                Name = "NewStock_tstrip",
                Text = "New Stock",
                ShortcutKeys = Keys.F2,
                Size = new Size(185, 22),
                Image = global::BanlydPharmacy.Properties.Resources.ic_arrow_forward_128_28222
            };
            this.NewStock_tstrip.Click += new System.EventHandler(this.NewStock_tstrip_Click);
        }
        //
        private void SetPreviousStock_toolStrip()
        {
            PreviousStock_tstrip = new ToolStripMenuItem()
            {
                Name = "PreviousStock_tstrip",
                Text = "Previous Stock",
                ShortcutKeys = Keys.F1,
                Size = new Size(185, 22),
                Image = global::BanlydPharmacy.Properties.Resources.ic_arrow_back_128_28226
            };
            this.PreviousStock_tstrip.Click += new System.EventHandler(this.PreviousStock_tstrip_Click);
        }
        //
        private void SetDelete_toolStrip()
        {
            Delete_tstrip = new ToolStripMenuItem()
            {
                Name = "Delete_tstrip",
                Text = "Delete Row",
                ShortcutKeys = Keys.Delete,
                Size = new Size(185, 22),
                Image = global::BanlydPharmacy.Properties.Resources.erase_delete_remove_wipe_out_512
            };
        }
        #endregion USER-DEFINED CONTROLS FUNCTIONS

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StockEntry_tabctrl = new System.Windows.Forms.TabControl();
            this.Quantity_page = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.OldQuantity_txt = new System.Windows.Forms.TextBox();
            this.NewQuantity_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackExpiry_page = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveExpiry_btn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.OldExpiryDate_txt = new System.Windows.Forms.TextBox();
            this.NewExpiryDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.Supplier_page = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.NewSupplier_cmb = new System.Windows.Forms.ComboBox();
            this.OldSupplier_txt = new System.Windows.Forms.TextBox();
            this.SaveSupplier_btn = new System.Windows.Forms.Button();
            this.PartNo_txt = new System.Windows.Forms.TextBox();
            this.PartDescription_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StockDescription_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StockNo_txt = new System.Windows.Forms.TextBox();
            this.Main_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.StockEntry_tabctrl.SuspendLayout();
            this.Quantity_page.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TrackExpiry_page.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Supplier_page.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.Main_tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockEntry_tabctrl
            // 
            this.StockEntry_tabctrl.Controls.Add(this.Quantity_page);
            this.StockEntry_tabctrl.Controls.Add(this.TrackExpiry_page);
            this.StockEntry_tabctrl.Controls.Add(this.Supplier_page);
            this.StockEntry_tabctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockEntry_tabctrl.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockEntry_tabctrl.Location = new System.Drawing.Point(0, 94);
            this.StockEntry_tabctrl.Margin = new System.Windows.Forms.Padding(0);
            this.StockEntry_tabctrl.Name = "StockEntry_tabctrl";
            this.Main_tlp.SetRowSpan(this.StockEntry_tabctrl, 2);
            this.StockEntry_tabctrl.SelectedIndex = 0;
            this.StockEntry_tabctrl.Size = new System.Drawing.Size(274, 333);
            this.StockEntry_tabctrl.TabIndex = 4;
            // 
            // Quantity_page
            // 
            this.Quantity_page.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Quantity_page.Controls.Add(this.tableLayoutPanel4);
            this.Quantity_page.Location = new System.Drawing.Point(4, 32);
            this.Quantity_page.Margin = new System.Windows.Forms.Padding(0);
            this.Quantity_page.Name = "Quantity_page";
            this.Quantity_page.Size = new System.Drawing.Size(266, 297);
            this.Quantity_page.TabIndex = 0;
            this.Quantity_page.Text = "Quantity";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.OldQuantity_txt, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.NewQuantity_txt, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 297);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 21);
            this.label16.TabIndex = 16;
            this.label16.Text = "In Stock";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // OldQuantity_txt
            // 
            this.OldQuantity_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldQuantity_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldQuantity_txt.Enabled = false;
            this.OldQuantity_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldQuantity_txt.Location = new System.Drawing.Point(3, 77);
            this.OldQuantity_txt.Name = "OldQuantity_txt";
            this.OldQuantity_txt.Size = new System.Drawing.Size(260, 27);
            this.OldQuantity_txt.TabIndex = 5;
            this.OldQuantity_txt.TabStop = false;
            // 
            // NewQuantity_txt
            // 
            this.NewQuantity_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewQuantity_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewQuantity_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuantity_txt.Location = new System.Drawing.Point(3, 225);
            this.NewQuantity_txt.Name = "NewQuantity_txt";
            this.NewQuantity_txt.Size = new System.Drawing.Size(260, 27);
            this.NewQuantity_txt.TabIndex = 5;
            this.NewQuantity_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQuantity_Qty_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "To Add";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TrackExpiry_page
            // 
            this.TrackExpiry_page.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TrackExpiry_page.Controls.Add(this.tableLayoutPanel3);
            this.TrackExpiry_page.Location = new System.Drawing.Point(4, 32);
            this.TrackExpiry_page.Name = "TrackExpiry_page";
            this.TrackExpiry_page.Size = new System.Drawing.Size(266, 297);
            this.TrackExpiry_page.TabIndex = 2;
            this.TrackExpiry_page.Text = "Track Expiry";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.SaveExpiry_btn, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.OldExpiryDate_txt, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.NewExpiryDate_dtp, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(266, 297);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // SaveExpiry_btn
            // 
            this.SaveExpiry_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveExpiry_btn.FlatAppearance.BorderSize = 0;
            this.SaveExpiry_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.SaveExpiry_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SaveExpiry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveExpiry_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveExpiry_btn.ForeColor = System.Drawing.Color.Indigo;
            this.SaveExpiry_btn.Location = new System.Drawing.Point(3, 239);
            this.SaveExpiry_btn.Name = "SaveExpiry_btn";
            this.SaveExpiry_btn.Size = new System.Drawing.Size(260, 55);
            this.SaveExpiry_btn.TabIndex = 21;
            this.SaveExpiry_btn.Text = "Save";
            this.SaveExpiry_btn.UseVisualStyleBackColor = false;
            this.SaveExpiry_btn.Click += new System.EventHandler(this.SaveExpiry_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(260, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "Set your expiry date here";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // OldExpiryDate_txt
            // 
            this.OldExpiryDate_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldExpiryDate_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldExpiryDate_txt.Enabled = false;
            this.OldExpiryDate_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldExpiryDate_txt.Location = new System.Drawing.Point(3, 62);
            this.OldExpiryDate_txt.Name = "OldExpiryDate_txt";
            this.OldExpiryDate_txt.Size = new System.Drawing.Size(260, 29);
            this.OldExpiryDate_txt.TabIndex = 15;
            // 
            // NewExpiryDate_dtp
            // 
            this.NewExpiryDate_dtp.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewExpiryDate_dtp.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewExpiryDate_dtp.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewExpiryDate_dtp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewExpiryDate_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NewExpiryDate_dtp.Location = new System.Drawing.Point(3, 180);
            this.NewExpiryDate_dtp.Name = "NewExpiryDate_dtp";
            this.NewExpiryDate_dtp.Size = new System.Drawing.Size(260, 29);
            this.NewExpiryDate_dtp.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(260, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "Expiry Date";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Supplier_page
            // 
            this.Supplier_page.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Supplier_page.Controls.Add(this.tableLayoutPanel7);
            this.Supplier_page.ForeColor = System.Drawing.Color.Black;
            this.Supplier_page.Location = new System.Drawing.Point(4, 32);
            this.Supplier_page.Name = "Supplier_page";
            this.Supplier_page.Size = new System.Drawing.Size(266, 297);
            this.Supplier_page.TabIndex = 3;
            this.Supplier_page.Text = "Supplier";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.NewSupplier_cmb, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.OldSupplier_txt, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.SaveSupplier_btn, 0, 4);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(266, 297);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 21);
            this.label20.TabIndex = 15;
            this.label20.Text = "Change supplier here";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(260, 21);
            this.label21.TabIndex = 16;
            this.label21.Text = "Supplier";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // NewSupplier_cmb
            // 
            this.NewSupplier_cmb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewSupplier_cmb.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewSupplier_cmb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSupplier_cmb.FormattingEnabled = true;
            this.NewSupplier_cmb.Location = new System.Drawing.Point(3, 180);
            this.NewSupplier_cmb.Name = "NewSupplier_cmb";
            this.NewSupplier_cmb.Size = new System.Drawing.Size(260, 29);
            this.NewSupplier_cmb.TabIndex = 19;
            this.NewSupplier_cmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockNoPartNo_KeyPress);
            // 
            // OldSupplier_txt
            // 
            this.OldSupplier_txt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldSupplier_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldSupplier_txt.Enabled = false;
            this.OldSupplier_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldSupplier_txt.Location = new System.Drawing.Point(3, 62);
            this.OldSupplier_txt.Name = "OldSupplier_txt";
            this.OldSupplier_txt.Size = new System.Drawing.Size(260, 29);
            this.OldSupplier_txt.TabIndex = 17;
            // 
            // SaveSupplier_btn
            // 
            this.SaveSupplier_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveSupplier_btn.FlatAppearance.BorderSize = 0;
            this.SaveSupplier_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.SaveSupplier_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.SaveSupplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveSupplier_btn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSupplier_btn.ForeColor = System.Drawing.Color.Crimson;
            this.SaveSupplier_btn.Location = new System.Drawing.Point(3, 239);
            this.SaveSupplier_btn.Name = "SaveSupplier_btn";
            this.SaveSupplier_btn.Size = new System.Drawing.Size(260, 55);
            this.SaveSupplier_btn.TabIndex = 20;
            this.SaveSupplier_btn.Text = "Save";
            this.SaveSupplier_btn.UseVisualStyleBackColor = false;
            this.SaveSupplier_btn.Click += new System.EventHandler(this.SaveSupplier_btn_Click);
            // 
            // PartNo_txt
            // 
            this.PartNo_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PartNo_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartNo_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNo_txt.Location = new System.Drawing.Point(779, 50);
            this.PartNo_txt.Name = "PartNo_txt";
            this.PartNo_txt.Size = new System.Drawing.Size(132, 27);
            this.PartNo_txt.TabIndex = 24;
            this.PartNo_txt.TabStop = false;
            this.PartNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockNoPartNo_KeyPress);
            // 
            // PartDescription_txt
            // 
            this.PartDescription_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PartDescription_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.PartDescription_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartDescription_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescription_txt.Location = new System.Drawing.Point(277, 50);
            this.PartDescription_txt.Name = "PartDescription_txt";
            this.PartDescription_txt.Size = new System.Drawing.Size(359, 27);
            this.PartDescription_txt.TabIndex = 2;
            this.PartDescription_txt.Enter += new System.EventHandler(this.PartDescription_txt_Enter);
            this.PartDescription_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescription_Qty_KeyDown);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 47);
            this.label8.TabIndex = 12;
            this.label8.Text = "Product Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StockDescription_txt
            // 
            this.StockDescription_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StockDescription_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockDescription_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.StockDescription_txt.Location = new System.Drawing.Point(277, 3);
            this.StockDescription_txt.Name = "StockDescription_txt";
            this.StockDescription_txt.Size = new System.Drawing.Size(359, 29);
            this.StockDescription_txt.TabIndex = 26;
            this.StockDescription_txt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "Stock Description";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(642, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 47);
            this.label24.TabIndex = 18;
            this.label24.Text = "Part No";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(642, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 47);
            this.label13.TabIndex = 19;
            this.label13.Text = "Stock No";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StockNo_txt
            // 
            this.StockNo_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StockNo_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockNo_txt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockNo_txt.Location = new System.Drawing.Point(779, 3);
            this.StockNo_txt.Name = "StockNo_txt";
            this.StockNo_txt.Size = new System.Drawing.Size(132, 27);
            this.StockNo_txt.TabIndex = 1;
            this.StockNo_txt.TabStop = false;
            this.StockNo_txt.Text = "1";
            this.StockNo_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockNoPartNo_KeyPress);
            // 
            // Main_tlp
            // 
            this.Main_tlp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Main_tlp.ColumnCount = 4;
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Main_tlp.Controls.Add(this.StockEntry_tabctrl, 0, 2);
            this.Main_tlp.Controls.Add(this.label8, 0, 1);
            this.Main_tlp.Controls.Add(this.label1, 0, 0);
            this.Main_tlp.Controls.Add(this.label13, 2, 0);
            this.Main_tlp.Controls.Add(this.StockDescription_txt, 1, 0);
            this.Main_tlp.Controls.Add(this.StockNo_txt, 3, 0);
            this.Main_tlp.Controls.Add(this.PartNo_txt, 3, 1);
            this.Main_tlp.Controls.Add(this.label24, 2, 1);
            this.Main_tlp.Controls.Add(this.PartDescription_txt, 1, 1);
            this.Main_tlp.Controls.Add(this.Main_pnl, 1, 3);
            this.Main_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tlp.Location = new System.Drawing.Point(0, 0);
            this.Main_tlp.Name = "Main_tlp";
            this.Main_tlp.RowCount = 5;
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tlp.Size = new System.Drawing.Size(914, 477);
            this.Main_tlp.TabIndex = 35;
            // 
            // Main_pnl
            // 
            this.Main_tlp.SetColumnSpan(this.Main_pnl, 3);
            this.Main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_pnl.Location = new System.Drawing.Point(277, 144);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_tlp.SetRowSpan(this.Main_pnl, 2);
            this.Main_pnl.Size = new System.Drawing.Size(634, 330);
            this.Main_pnl.TabIndex = 27;
            // 
            // StockEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Main_tlp);
            this.Name = "StockEntry";
            this.Size = new System.Drawing.Size(914, 477);
            this.Load += new System.EventHandler(this.StockEntry_Load);
            this.StockEntry_tabctrl.ResumeLayout(false);
            this.Quantity_page.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TrackExpiry_page.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Supplier_page.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.Main_tlp.ResumeLayout(false);
            this.Main_tlp.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.TabControl StockEntry_tabctrl;
        private System.Windows.Forms.TabPage Quantity_page;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox OldQuantity_txt;
        public System.Windows.Forms.TextBox NewQuantity_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TrackExpiry_page;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox OldExpiryDate_txt;
        private System.Windows.Forms.DateTimePicker NewExpiryDate_dtp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage Supplier_page;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox NewSupplier_cmb;
        private System.Windows.Forms.TextBox OldSupplier_txt;
        private System.Windows.Forms.TextBox PartNo_txt;
        public System.Windows.Forms.TextBox PartDescription_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StockDescription_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StockNo_txt;
        private System.Windows.Forms.TableLayoutPanel Main_tlp;
        // OPTIONAL CONTROLS
        private DataGridView StockTaken_dgv;
        private DataGridViewCellStyle style1;
        private DataGridViewCellStyle style2;
        private DataGridViewCheckBoxColumn cbCheck;
        private DataGridViewTextBoxColumn txtPartNo, txtPartDescription, txtQuantity, txtExpiryDates, txtSuppliers;
        // ADD THE STOCKLIST USERCONTROL
        private UC.StockList StockList_uc;
        private Label StockList_lbl;
        private Panel Main_pnl;
        private ContextMenuStrip StockTaken_cmstrip;
        private ToolStripMenuItem Refresh_tstrp, NewStock_tstrip, PreviousStock_tstrip, Delete_tstrip;
        private Button SaveExpiry_btn;
        private Button SaveSupplier_btn;
    }
}
