namespace BanlydPharmacy.Forms
{
    partial class Stock
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

        //
        private void InitialiseMyComponents()
        {
            Highlight_pnl = new System.Windows.Forms.Panel()
            {
                BackColor = System.Drawing.Color.Crimson,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(0, 0, 0, 0)
            };
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.RefreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Navigate_picb = new System.Windows.Forms.PictureBox();
            this.Main_pnl = new System.Windows.Forms.Panel();
            this.Navigate_lbl = new System.Windows.Forms.Label();
            this.Navigate_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.StockEntry_btn = new System.Windows.Forms.Button();
            this.AdjustPrices_btn = new System.Windows.Forms.Button();
            this.ModifyNames_btn = new System.Windows.Forms.Button();
            this.AddItem_btn = new System.Windows.Forms.Button();
            this.GroupMaintenace_btn = new System.Windows.Forms.Button();
            this.Free_pnl = new System.Windows.Forms.Panel();
            this.ExpiryDates_btn = new System.Windows.Forms.Button();
            this.Suppliers_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Navigate_picb)).BeginInit();
            this.Navigate_tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshToolStripMenuItem1
            // 
            this.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1";
            this.RefreshToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // DeselectAllToolStripMenuItem
            // 
            this.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem";
            this.DeselectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Main_tlp
            // 
            this.Main_tlp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Main_tlp.ColumnCount = 4;
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Main_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_tlp.Controls.Add(this.Navigate_picb, 0, 0);
            this.Main_tlp.Controls.Add(this.Main_pnl, 2, 1);
            this.Main_tlp.Controls.Add(this.Navigate_lbl, 1, 0);
            this.Main_tlp.Controls.Add(this.Navigate_tlp, 1, 1);
            this.Main_tlp.Controls.Add(this.Free_pnl, 0, 1);
            this.Main_tlp.Controls.Add(this.label1, 2, 0);
            this.Main_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tlp.Location = new System.Drawing.Point(3, 3);
            this.Main_tlp.Name = "Main_tlp";
            this.Main_tlp.RowCount = 2;
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Main_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_tlp.Size = new System.Drawing.Size(859, 433);
            this.Main_tlp.TabIndex = 2;
            // 
            // Navigate_picb
            // 
            this.Navigate_picb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Navigate_picb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigate_picb.Image = global::BanlydPharmacy.Properties.Resources._2931181___checklist_lines_list_menu_navigation;
            this.Navigate_picb.Location = new System.Drawing.Point(0, 0);
            this.Navigate_picb.Margin = new System.Windows.Forms.Padding(0);
            this.Navigate_picb.Name = "Navigate_picb";
            this.Navigate_picb.Size = new System.Drawing.Size(42, 43);
            this.Navigate_picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Navigate_picb.TabIndex = 0;
            this.Navigate_picb.TabStop = false;
            this.Navigate_picb.Click += new System.EventHandler(this.Navigate_picb_Click);
            // 
            // Main_pnl
            // 
            this.Main_pnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Main_tlp.SetColumnSpan(this.Main_pnl, 2);
            this.Main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_pnl.Location = new System.Drawing.Point(216, 46);
            this.Main_pnl.Name = "Main_pnl";
            this.Main_pnl.Size = new System.Drawing.Size(640, 384);
            this.Main_pnl.TabIndex = 1;
            // 
            // Navigate_lbl
            // 
            this.Navigate_lbl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Navigate_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigate_lbl.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navigate_lbl.Location = new System.Drawing.Point(42, 0);
            this.Navigate_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Navigate_lbl.Name = "Navigate_lbl";
            this.Navigate_lbl.Size = new System.Drawing.Size(171, 43);
            this.Navigate_lbl.TabIndex = 2;
            this.Navigate_lbl.Text = "Navigate";
            this.Navigate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Navigate_tlp
            // 
            this.Navigate_tlp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Navigate_tlp.ColumnCount = 2;
            this.Navigate_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Navigate_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98F));
            this.Navigate_tlp.Controls.Add(this.StockEntry_btn, 1, 0);
            this.Navigate_tlp.Controls.Add(this.AdjustPrices_btn, 1, 1);
            this.Navigate_tlp.Controls.Add(this.ModifyNames_btn, 1, 2);
            this.Navigate_tlp.Controls.Add(this.AddItem_btn, 1, 3);
            this.Navigate_tlp.Controls.Add(this.GroupMaintenace_btn, 1, 4);
            this.Navigate_tlp.Controls.Add(this.ExpiryDates_btn, 1, 5);
            this.Navigate_tlp.Controls.Add(this.Suppliers_btn, 1, 6);
            this.Navigate_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navigate_tlp.Location = new System.Drawing.Point(42, 43);
            this.Navigate_tlp.Margin = new System.Windows.Forms.Padding(0);
            this.Navigate_tlp.Name = "Navigate_tlp";
            this.Navigate_tlp.RowCount = 10;
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Navigate_tlp.Size = new System.Drawing.Size(171, 390);
            this.Navigate_tlp.TabIndex = 0;
            // 
            // StockEntry_btn
            // 
            this.StockEntry_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockEntry_btn.FlatAppearance.BorderSize = 0;
            this.StockEntry_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.StockEntry_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.StockEntry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockEntry_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockEntry_btn.ForeColor = System.Drawing.Color.Black;
            this.StockEntry_btn.Location = new System.Drawing.Point(3, 0);
            this.StockEntry_btn.Margin = new System.Windows.Forms.Padding(0);
            this.StockEntry_btn.Name = "StockEntry_btn";
            this.StockEntry_btn.Size = new System.Drawing.Size(168, 39);
            this.StockEntry_btn.TabIndex = 0;
            this.StockEntry_btn.TabStop = false;
            this.StockEntry_btn.Text = "💊 Stock Entry";
            this.StockEntry_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockEntry_btn.UseVisualStyleBackColor = false;
            this.StockEntry_btn.Click += new System.EventHandler(this.StockEntry_btn_Click);
            // 
            // AdjustPrices_btn
            // 
            this.AdjustPrices_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjustPrices_btn.FlatAppearance.BorderSize = 0;
            this.AdjustPrices_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.AdjustPrices_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.AdjustPrices_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdjustPrices_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjustPrices_btn.ForeColor = System.Drawing.Color.Black;
            this.AdjustPrices_btn.Location = new System.Drawing.Point(3, 39);
            this.AdjustPrices_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AdjustPrices_btn.Name = "AdjustPrices_btn";
            this.AdjustPrices_btn.Size = new System.Drawing.Size(168, 39);
            this.AdjustPrices_btn.TabIndex = 0;
            this.AdjustPrices_btn.TabStop = false;
            this.AdjustPrices_btn.Text = "💰 Adjust Prices";
            this.AdjustPrices_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdjustPrices_btn.UseVisualStyleBackColor = false;
            this.AdjustPrices_btn.Click += new System.EventHandler(this.AjustPrices_btn_Click);
            // 
            // ModifyNames_btn
            // 
            this.ModifyNames_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyNames_btn.FlatAppearance.BorderSize = 0;
            this.ModifyNames_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.ModifyNames_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ModifyNames_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyNames_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyNames_btn.ForeColor = System.Drawing.Color.Black;
            this.ModifyNames_btn.Location = new System.Drawing.Point(3, 78);
            this.ModifyNames_btn.Margin = new System.Windows.Forms.Padding(0);
            this.ModifyNames_btn.Name = "ModifyNames_btn";
            this.ModifyNames_btn.Size = new System.Drawing.Size(168, 39);
            this.ModifyNames_btn.TabIndex = 0;
            this.ModifyNames_btn.TabStop = false;
            this.ModifyNames_btn.Text = "✍ Modify Item Name";
            this.ModifyNames_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifyNames_btn.UseVisualStyleBackColor = false;
            this.ModifyNames_btn.Click += new System.EventHandler(this.ModifyNames_btn_Click);
            // 
            // AddItem_btn
            // 
            this.AddItem_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItem_btn.FlatAppearance.BorderSize = 0;
            this.AddItem_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.AddItem_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.AddItem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_btn.ForeColor = System.Drawing.Color.Black;
            this.AddItem_btn.Location = new System.Drawing.Point(3, 117);
            this.AddItem_btn.Margin = new System.Windows.Forms.Padding(0);
            this.AddItem_btn.Name = "AddItem_btn";
            this.AddItem_btn.Size = new System.Drawing.Size(168, 39);
            this.AddItem_btn.TabIndex = 0;
            this.AddItem_btn.TabStop = false;
            this.AddItem_btn.Text = "➕ Add/Remove Item";
            this.AddItem_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItem_btn.UseVisualStyleBackColor = false;
            this.AddItem_btn.Click += new System.EventHandler(this.AddItem_btn_Click);
            // 
            // GroupMaintenace_btn
            // 
            this.GroupMaintenace_btn.FlatAppearance.BorderSize = 0;
            this.GroupMaintenace_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.GroupMaintenace_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.GroupMaintenace_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupMaintenace_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMaintenace_btn.ForeColor = System.Drawing.Color.Black;
            this.GroupMaintenace_btn.Location = new System.Drawing.Point(3, 156);
            this.GroupMaintenace_btn.Margin = new System.Windows.Forms.Padding(0);
            this.GroupMaintenace_btn.Name = "GroupMaintenace_btn";
            this.GroupMaintenace_btn.Size = new System.Drawing.Size(163, 39);
            this.GroupMaintenace_btn.TabIndex = 0;
            this.GroupMaintenace_btn.TabStop = false;
            this.GroupMaintenace_btn.Text = "⚙ Group maintenance";
            this.GroupMaintenace_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupMaintenace_btn.UseVisualStyleBackColor = false;
            this.GroupMaintenace_btn.Click += new System.EventHandler(this.GroupMaintenace_btn_Click);
            // 
            // Free_pnl
            // 
            this.Free_pnl.BackColor = System.Drawing.Color.Gray;
            this.Free_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Free_pnl.Location = new System.Drawing.Point(0, 43);
            this.Free_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.Free_pnl.Name = "Free_pnl";
            this.Free_pnl.Size = new System.Drawing.Size(42, 390);
            this.Free_pnl.TabIndex = 3;
            // 
            // ExpiryDates_btn
            // 
            this.ExpiryDates_btn.FlatAppearance.BorderSize = 0;
            this.ExpiryDates_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.ExpiryDates_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.ExpiryDates_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpiryDates_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDates_btn.ForeColor = System.Drawing.Color.Black;
            this.ExpiryDates_btn.Location = new System.Drawing.Point(3, 195);
            this.ExpiryDates_btn.Margin = new System.Windows.Forms.Padding(0);
            this.ExpiryDates_btn.Name = "ExpiryDates_btn";
            this.ExpiryDates_btn.Size = new System.Drawing.Size(163, 39);
            this.ExpiryDates_btn.TabIndex = 0;
            this.ExpiryDates_btn.TabStop = false;
            this.ExpiryDates_btn.Text = "📆 Expiry Dates";
            this.ExpiryDates_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpiryDates_btn.UseVisualStyleBackColor = false;
            this.ExpiryDates_btn.Click += new System.EventHandler(this.ExpiryDates_btn_Click);
            // 
            // Suppliers_btn
            // 
            this.Suppliers_btn.FlatAppearance.BorderSize = 0;
            this.Suppliers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.Suppliers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Suppliers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suppliers_btn.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliers_btn.ForeColor = System.Drawing.Color.Black;
            this.Suppliers_btn.Location = new System.Drawing.Point(3, 234);
            this.Suppliers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Suppliers_btn.Name = "Suppliers_btn";
            this.Suppliers_btn.Size = new System.Drawing.Size(163, 39);
            this.Suppliers_btn.TabIndex = 0;
            this.Suppliers_btn.TabStop = false;
            this.Suppliers_btn.Text = "🛒 Suppliers";
            this.Suppliers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Suppliers_btn.UseVisualStyleBackColor = false;
            this.Suppliers_btn.Click += new System.EventHandler(this.Suppliers_btn_Click);
            // 
            // label1
            // 
            this.Main_tlp.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "👔🥼🧥🧦👗🥻👘👕🎒👞👟🥾🥿👠👢👓👖🩳";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 439);
            this.ControlBox = false;
            this.Controls.Add(this.Main_tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Activities";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Load);
            this.Main_tlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Navigate_picb)).EndInit();
            this.Navigate_tlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel Main_tlp;
        private System.Windows.Forms.PictureBox Navigate_picb;
        private System.Windows.Forms.Panel Main_pnl;
        private System.Windows.Forms.TableLayoutPanel Navigate_tlp;
        private System.Windows.Forms.Button StockEntry_btn;
        private System.Windows.Forms.Button AdjustPrices_btn;
        private System.Windows.Forms.Button ModifyNames_btn;
        private System.Windows.Forms.Button AddItem_btn;
        private System.Windows.Forms.Button GroupMaintenace_btn;
        private System.Windows.Forms.Label Navigate_lbl;
        private System.Windows.Forms.Panel Free_pnl;
        // User defined controls
        private System.Windows.Forms.Panel Highlight_pnl;
        private System.Windows.Forms.Button ExpiryDates_btn;
        private System.Windows.Forms.Button Suppliers_btn;
        private System.Windows.Forms.Label label1;
    }
}