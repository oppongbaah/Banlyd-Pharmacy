namespace BanlydPharmacy.UC
{
    partial class AdjustPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StockPrices_dgv = new System.Windows.Forms.DataGridView();
            this.txtPartNo_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPartDescription_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSellingPrice_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiscount_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxVart_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitPrice_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCostPrice_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtWholeSalePrice_StockPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchPrices_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPrices_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SearchPrices_txt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StockPrices_dgv, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.09238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.90762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StockPrices_dgv
            // 
            this.StockPrices_dgv.AllowUserToAddRows = false;
            this.StockPrices_dgv.AllowUserToDeleteRows = false;
            this.StockPrices_dgv.AllowUserToResizeColumns = false;
            this.StockPrices_dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            this.StockPrices_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockPrices_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.StockPrices_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.StockPrices_dgv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.StockPrices_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StockPrices_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.StockPrices_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockPrices_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPartNo_StockPrices,
            this.txtPartDescription_StockPrices,
            this.txtSellingPrice_StockPrices,
            this.txtDiscount_StockPrices,
            this.txtTaxVart_StockPrices,
            this.txtUnitPrice_StockPrices,
            this.txtCostPrice_StockPrices,
            this.txtWholeSalePrice_StockPrices});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockPrices_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockPrices_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.StockPrices_dgv.GridColor = System.Drawing.Color.Lime;
            this.StockPrices_dgv.Location = new System.Drawing.Point(3, 89);
            this.StockPrices_dgv.Name = "StockPrices_dgv";
            this.StockPrices_dgv.RowHeadersVisible = false;
            this.StockPrices_dgv.RowTemplate.DividerHeight = 10;
            this.StockPrices_dgv.RowTemplate.Height = 40;
            this.StockPrices_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StockPrices_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StockPrices_dgv.Size = new System.Drawing.Size(387, 325);
            this.StockPrices_dgv.TabIndex = 30;
            this.StockPrices_dgv.TabStop = false;
            // 
            // txtPartNo_StockPrices
            // 
            this.txtPartNo_StockPrices.DataPropertyName = "PartNo";
            this.txtPartNo_StockPrices.HeaderText = "Part No";
            this.txtPartNo_StockPrices.Name = "txtPartNo_StockPrices";
            this.txtPartNo_StockPrices.ReadOnly = true;
            this.txtPartNo_StockPrices.Width = 68;
            // 
            // txtPartDescription_StockPrices
            // 
            this.txtPartDescription_StockPrices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPartDescription_StockPrices.DataPropertyName = "PartDescription";
            this.txtPartDescription_StockPrices.HeaderText = "Description";
            this.txtPartDescription_StockPrices.Name = "txtPartDescription_StockPrices";
            this.txtPartDescription_StockPrices.ReadOnly = true;
            // 
            // txtSellingPrice_StockPrices
            // 
            this.txtSellingPrice_StockPrices.DataPropertyName = "SellingPrice";
            this.txtSellingPrice_StockPrices.HeaderText = "Selling Price";
            this.txtSellingPrice_StockPrices.Name = "txtSellingPrice_StockPrices";
            this.txtSellingPrice_StockPrices.Width = 90;
            // 
            // txtDiscount_StockPrices
            // 
            this.txtDiscount_StockPrices.DataPropertyName = "Discount";
            this.txtDiscount_StockPrices.HeaderText = "Discount";
            this.txtDiscount_StockPrices.Name = "txtDiscount_StockPrices";
            this.txtDiscount_StockPrices.Width = 74;
            // 
            // txtTaxVart_StockPrices
            // 
            this.txtTaxVart_StockPrices.DataPropertyName = "TaxVart";
            this.txtTaxVart_StockPrices.HeaderText = "Tax/Vart";
            this.txtTaxVart_StockPrices.Name = "txtTaxVart_StockPrices";
            this.txtTaxVart_StockPrices.Width = 74;
            // 
            // txtUnitPrice_StockPrices
            // 
            this.txtUnitPrice_StockPrices.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice_StockPrices.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtUnitPrice_StockPrices.HeaderText = "Unit Price";
            this.txtUnitPrice_StockPrices.Name = "txtUnitPrice_StockPrices";
            this.txtUnitPrice_StockPrices.ReadOnly = true;
            this.txtUnitPrice_StockPrices.Width = 78;
            // 
            // txtCostPrice_StockPrices
            // 
            this.txtCostPrice_StockPrices.DataPropertyName = "CostPrice";
            this.txtCostPrice_StockPrices.HeaderText = "Cost Price";
            this.txtCostPrice_StockPrices.Name = "txtCostPrice_StockPrices";
            this.txtCostPrice_StockPrices.Width = 80;
            // 
            // txtWholeSalePrice_StockPrices
            // 
            this.txtWholeSalePrice_StockPrices.DataPropertyName = "WholesalePrice";
            this.txtWholeSalePrice_StockPrices.HeaderText = "Wholesale";
            this.txtWholeSalePrice_StockPrices.Name = "txtWholeSalePrice_StockPrices";
            this.txtWholeSalePrice_StockPrices.Width = 82;
            // 
            // SearchPrices_txt
            // 
            this.SearchPrices_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPrices_txt.ForeColor = System.Drawing.Color.Black;
            this.SearchPrices_txt.Location = new System.Drawing.Point(3, 3);
            this.SearchPrices_txt.Name = "SearchPrices_txt";
            this.SearchPrices_txt.Size = new System.Drawing.Size(387, 29);
            this.SearchPrices_txt.TabIndex = 35;
            // 
            // AdjustPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdjustPrice";
            this.Size = new System.Drawing.Size(787, 433);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockPrices_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView StockPrices_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartNo_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPartDescription_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSellingPrice_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiscount_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTaxVart_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUnitPrice_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCostPrice_StockPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtWholeSalePrice_StockPrices;
        private System.Windows.Forms.TextBox SearchPrices_txt;
    }
}
