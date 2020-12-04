namespace BanlydPharmacy.UC
{
    partial class RecentUsers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.search_picbox = new System.Windows.Forms.PictureBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.RecentUsers_dgv = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentUsers_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.Controls.Add(this.search_picbox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Search_txt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RecentUsers_dgv, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 371);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // search_picbox
            // 
            this.search_picbox.BackColor = System.Drawing.Color.White;
            this.search_picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_picbox.Image = global::BanlydPharmacy.Properties.Resources.Very_Basic_Search_icon;
            this.search_picbox.Location = new System.Drawing.Point(3, 3);
            this.search_picbox.Name = "search_picbox";
            this.search_picbox.Size = new System.Drawing.Size(27, 31);
            this.search_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_picbox.TabIndex = 9;
            this.search_picbox.TabStop = false;
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_txt.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.Search_txt.ForeColor = System.Drawing.Color.Gray;
            this.Search_txt.Location = new System.Drawing.Point(36, 3);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(624, 22);
            this.Search_txt.TabIndex = 2;
            this.Search_txt.Text = "search";
            this.Search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            this.Search_txt.Enter += new System.EventHandler(this.Search_txt_Enter);
            this.Search_txt.Leave += new System.EventHandler(this.Search_txt_Leave);
            // 
            // RecentUsers_dgv
            // 
            this.RecentUsers_dgv.AllowUserToAddRows = false;
            this.RecentUsers_dgv.AllowUserToResizeColumns = false;
            this.RecentUsers_dgv.AllowUserToResizeRows = false;
            this.RecentUsers_dgv.BackgroundColor = System.Drawing.Color.White;
            this.RecentUsers_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecentUsers_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.RecentUsers_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecentUsers_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecentUsers_dgv.ColumnHeadersHeight = 40;
            this.RecentUsers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RecentUsers_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtUsername,
            this.txtLoginTime,
            this.txtLoginDate});
            this.tableLayoutPanel1.SetColumnSpan(this.RecentUsers_dgv, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecentUsers_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecentUsers_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecentUsers_dgv.GridColor = System.Drawing.Color.Black;
            this.RecentUsers_dgv.Location = new System.Drawing.Point(0, 37);
            this.RecentUsers_dgv.Margin = new System.Windows.Forms.Padding(0);
            this.RecentUsers_dgv.Name = "RecentUsers_dgv";
            this.RecentUsers_dgv.ReadOnly = true;
            this.RecentUsers_dgv.RowHeadersVisible = false;
            this.RecentUsers_dgv.RowTemplate.DividerHeight = 2;
            this.RecentUsers_dgv.RowTemplate.Height = 30;
            this.RecentUsers_dgv.RowTemplate.ReadOnly = true;
            this.RecentUsers_dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RecentUsers_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecentUsers_dgv.Size = new System.Drawing.Size(663, 334);
            this.RecentUsers_dgv.TabIndex = 1;
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
            // txtLoginTime
            // 
            this.txtLoginTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLoginTime.DataPropertyName = "LoginTime";
            this.txtLoginTime.HeaderText = "Login Time";
            this.txtLoginTime.Name = "txtLoginTime";
            this.txtLoginTime.ReadOnly = true;
            // 
            // txtLoginDate
            // 
            this.txtLoginDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtLoginDate.DataPropertyName = "LoginDate";
            this.txtLoginDate.HeaderText = "Login Date";
            this.txtLoginDate.Name = "txtLoginDate";
            this.txtLoginDate.ReadOnly = true;
            // 
            // RecentUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecentUsers";
            this.Size = new System.Drawing.Size(663, 371);
            this.Load += new System.EventHandler(this.RecentUsers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentUsers_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.PictureBox search_picbox;
        private System.Windows.Forms.DataGridView RecentUsers_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLoginDate;
    }
}
