namespace BanlydPharmacy
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.label1 = new System.Windows.Forms.Label();
            this.Close_picbox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.New_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Update_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentUsers_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.User_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Close_picbox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.User_tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.User_tlp.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(46, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close_picbox
            // 
            this.Close_picbox.BackColor = System.Drawing.SystemColors.Control;
            this.Close_picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Close_picbox.Image = global::BanlydPharmacy.Properties.Resources.close_delete_delete_theaction_theoutput_10252;
            this.Close_picbox.Location = new System.Drawing.Point(883, 3);
            this.Close_picbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.Close_picbox.Name = "Close_picbox";
            this.Close_picbox.Size = new System.Drawing.Size(45, 40);
            this.Close_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_picbox.TabIndex = 1;
            this.Close_picbox.TabStop = false;
            this.Close_picbox.Click += new System.EventHandler(this.Close_picbox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.User_tlp.SetColumnSpan(this.menuStrip1, 5);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_menu,
            this.New_menu,
            this.Update_menu,
            this.RecentUsers_menu});
            this.menuStrip1.Location = new System.Drawing.Point(3, 43);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 34);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home_menu
            // 
            this.Home_menu.CheckOnClick = true;
            this.Home_menu.Name = "Home_menu";
            this.Home_menu.Size = new System.Drawing.Size(52, 30);
            this.Home_menu.Text = "&Home";
            this.Home_menu.Click += new System.EventHandler(this.Home_menu_Click);
            // 
            // New_menu
            // 
            this.New_menu.Name = "New_menu";
            this.New_menu.Size = new System.Drawing.Size(43, 30);
            this.New_menu.Text = "&New";
            this.New_menu.Click += new System.EventHandler(this.New_menu_Click);
            // 
            // Update_menu
            // 
            this.Update_menu.Name = "Update_menu";
            this.Update_menu.Size = new System.Drawing.Size(113, 30);
            this.Update_menu.Text = "&Change Password";
            this.Update_menu.Click += new System.EventHandler(this.Update_menu_Click);
            // 
            // RecentUsers_menu
            // 
            this.RecentUsers_menu.Name = "RecentUsers_menu";
            this.RecentUsers_menu.Size = new System.Drawing.Size(86, 30);
            this.RecentUsers_menu.Text = "&Recent Users";
            this.RecentUsers_menu.Click += new System.EventHandler(this.RecentUsers_menu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // User_tlp
            // 
            this.User_tlp.ColumnCount = 5;
            this.User_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.User_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.User_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.User_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.User_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.User_tlp.Controls.Add(this.menuStrip1, 0, 1);
            this.User_tlp.Controls.Add(this.Close_picbox, 4, 0);
            this.User_tlp.Controls.Add(this.label1, 1, 0);
            this.User_tlp.Controls.Add(this.pictureBox1, 0, 0);
            this.User_tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_tlp.Location = new System.Drawing.Point(0, 0);
            this.User_tlp.Name = "User_tlp";
            this.User_tlp.RowCount = 5;
            this.User_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.25382F));
            this.User_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.03036F));
            this.User_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.76146F));
            this.User_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.97062F));
            this.User_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.98374F));
            this.User_tlp.Size = new System.Drawing.Size(931, 424);
            this.User_tlp.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::BanlydPharmacy.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(931, 424);
            this.Controls.Add(this.User_tlp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Close_picbox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.User_tlp.ResumeLayout(false);
            this.User_tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Close_picbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Update_menu;
        private System.Windows.Forms.ToolStripMenuItem New_menu;
        private System.Windows.Forms.ToolStripMenuItem Home_menu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel User_tlp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem RecentUsers_menu;
    }
}