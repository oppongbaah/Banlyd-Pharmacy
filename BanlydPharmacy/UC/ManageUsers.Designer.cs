namespace BanlydPharmacy.UC
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManageUser_dgv = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageUser_cmstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.search_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_dgv)).BeginInit();
            this.ManageUser_cmstrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageUser_dgv
            // 
            this.ManageUser_dgv.AllowUserToAddRows = false;
            this.ManageUser_dgv.AllowUserToResizeColumns = false;
            this.ManageUser_dgv.AllowUserToResizeRows = false;
            this.ManageUser_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ManageUser_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ManageUser_dgv.BackgroundColor = System.Drawing.Color.White;
            this.ManageUser_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageUser_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ManageUser_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ManageUser_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ManageUser_dgv.ColumnHeadersHeight = 40;
            this.ManageUser_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ManageUser_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.txtID,
            this.txtUsername,
            this.txtPassword});
            this.tableLayoutPanel1.SetColumnSpan(this.ManageUser_dgv, 3);
            this.ManageUser_dgv.ContextMenuStrip = this.ManageUser_cmstrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ManageUser_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.ManageUser_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageUser_dgv.GridColor = System.Drawing.Color.Black;
            this.ManageUser_dgv.Location = new System.Drawing.Point(0, 37);
            this.ManageUser_dgv.Margin = new System.Windows.Forms.Padding(0);
            this.ManageUser_dgv.Name = "ManageUser_dgv";
            this.ManageUser_dgv.ReadOnly = true;
            this.ManageUser_dgv.RowHeadersVisible = false;
            this.ManageUser_dgv.RowTemplate.DividerHeight = 2;
            this.ManageUser_dgv.RowTemplate.Height = 30;
            this.ManageUser_dgv.RowTemplate.ReadOnly = true;
            this.ManageUser_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ManageUser_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ManageUser_dgv.Size = new System.Drawing.Size(687, 342);
            this.ManageUser_dgv.TabIndex = 1;
            this.ManageUser_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManageUser_dgv_CellDoubleClick);
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.check.Width = 19;
            // 
            // txtID
            // 
            this.txtID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtID.DataPropertyName = "UserID";
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Width = 56;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtUsername.DataPropertyName = "Username";
            this.txtUsername.HeaderText = "Username";
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPassword.DataPropertyName = "Passwords";
            this.txtPassword.HeaderText = "Password";
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            // 
            // ManageUser_cmstrip
            // 
            this.ManageUser_cmstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.deletesToolStripMenuItem});
            this.ManageUser_cmstrip.Name = "contextMenuStrip1";
            this.ManageUser_cmstrip.Size = new System.Drawing.Size(144, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.refresh_40634;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.refreshToolStripMenuItem.Text = "&Refresh Table";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // deletesToolStripMenuItem
            // 
            this.deletesToolStripMenuItem.Image = global::BanlydPharmacy.Properties.Resources.erase_delete_remove_wipe_out_512;
            this.deletesToolStripMenuItem.Name = "deletesToolStripMenuItem";
            this.deletesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deletesToolStripMenuItem.Text = "&Delete User";
            this.deletesToolStripMenuItem.Click += new System.EventHandler(this.DeletesToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.Search_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_picbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ManageUser_dgv, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 379);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Search_txt, 2);
            this.Search_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.ForeColor = System.Drawing.Color.Gray;
            this.Search_txt.Location = new System.Drawing.Point(34, 0);
            this.Search_txt.Margin = new System.Windows.Forms.Padding(0);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(653, 22);
            this.Search_txt.TabIndex = 2;
            this.Search_txt.Text = "search";
            this.Search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            this.Search_txt.Enter += new System.EventHandler(this.Search_txt_Enter);
            this.Search_txt.Leave += new System.EventHandler(this.Search_txt_Leave);
            // 
            // search_picbox
            // 
            this.search_picbox.BackColor = System.Drawing.Color.White;
            this.search_picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_picbox.Image = global::BanlydPharmacy.Properties.Resources.Very_Basic_Search_icon;
            this.search_picbox.Location = new System.Drawing.Point(0, 0);
            this.search_picbox.Margin = new System.Windows.Forms.Padding(0);
            this.search_picbox.Name = "search_picbox";
            this.search_picbox.Size = new System.Drawing.Size(34, 37);
            this.search_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_picbox.TabIndex = 8;
            this.search_picbox.TabStop = false;
            // 
            // ManageUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageUsers";
            this.Size = new System.Drawing.Size(687, 379);
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUser_dgv)).EndInit();
            this.ManageUser_cmstrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ManageUser_dgv;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.PictureBox search_picbox;
        private System.Windows.Forms.ContextMenuStrip ManageUser_cmstrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
    }
}
