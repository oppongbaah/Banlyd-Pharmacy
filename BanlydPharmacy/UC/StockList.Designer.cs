namespace BanlydPharmacy.UC
{
    partial class StockList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StockList_dgv = new System.Windows.Forms.DataGridView();
            this.txtPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StockList_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // StockList_dgv
            // 
            this.StockList_dgv.AllowUserToAddRows = false;
            this.StockList_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.StockList_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StockList_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StockList_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StockList_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockList_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockList_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPartNo,
            this.txtPartDescription,
            this.txtQuantity,
            this.txtUnitPrice,
            this.txtSupplier,
            this.txtExpiryDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockList_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockList_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockList_dgv.Location = new System.Drawing.Point(0, 0);
            this.StockList_dgv.Name = "StockList_dgv";
            this.StockList_dgv.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockList_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockList_dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockList_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StockList_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockList_dgv.Size = new System.Drawing.Size(739, 482);
            this.StockList_dgv.TabIndex = 3;
            this.StockList_dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StockList_dgv_KeyDown);
            // 
            // txtPartNo
            // 
            this.txtPartNo.DataPropertyName = "PartNo";
            this.txtPartNo.FillWeight = 66.68428F;
            this.txtPartNo.HeaderText = "Part No";
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Width = 80;
            // 
            // txtPartDescription
            // 
            this.txtPartDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPartDescription.DataPropertyName = "PartDescription";
            this.txtPartDescription.FillWeight = 169.8022F;
            this.txtPartDescription.HeaderText = "Description";
            this.txtPartDescription.Name = "txtPartDescription";
            this.txtPartDescription.ReadOnly = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataPropertyName = "TotalQty";
            this.txtQuantity.FillWeight = 72.5487F;
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Width = 92;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.DataPropertyName = "UnitPrice";
            this.txtUnitPrice.FillWeight = 92.25372F;
            this.txtUnitPrice.HeaderText = "Unit Price (GHc)";
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Width = 140;
            // 
            // txtSupplier
            // 
            this.txtSupplier.DataPropertyName = "Supplier";
            this.txtSupplier.HeaderText = "Supplier";
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Width = 91;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.DataPropertyName = "ExpiryDates";
            this.txtExpiryDate.FillWeight = 87.11823F;
            this.txtExpiryDate.HeaderText = "Expiry Date";
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ReadOnly = true;
            this.txtExpiryDate.Width = 105;
            // 
            // StockList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.StockList_dgv);
            this.Name = "StockList";
            this.Size = new System.Drawing.Size(739, 482);
            this.Load += new System.EventHandler(this.StockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockList_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockList_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExpiryDate;
    }
}
