namespace BanlydPharmacy.UC
{
    partial class Profile
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
            this.Profile_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileExit_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Profile_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Profile_panel
            // 
            this.Profile_panel.BackgroundImage = global::BanlydPharmacy.Properties.Resources.leath;
            this.Profile_panel.Controls.Add(this.label3);
            this.Profile_panel.Controls.Add(this.label1);
            this.Profile_panel.Controls.Add(this.Update_btn);
            this.Profile_panel.Controls.Add(this.Username_txt);
            this.Profile_panel.Controls.Add(this.Password_txt);
            this.Profile_panel.Controls.Add(this.panel2);
            this.Profile_panel.Controls.Add(this.pictureBox1);
            this.Profile_panel.Controls.Add(this.pictureBox2);
            this.Profile_panel.Controls.Add(this.label6);
            this.Profile_panel.Controls.Add(this.label5);
            this.Profile_panel.Controls.Add(this.Username_lbl);
            this.Profile_panel.Location = new System.Drawing.Point(43, 52);
            this.Profile_panel.Name = "Profile_panel";
            this.Profile_panel.Size = new System.Drawing.Size(340, 382);
            this.Profile_panel.TabIndex = 19;
            this.Profile_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(54, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOTE : For security reasons, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username is disabled from editing";
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.Color.Teal;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_btn.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.Location = new System.Drawing.Point(127, 270);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(117, 34);
            this.Update_btn.TabIndex = 20;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            // 
            // Username_txt
            // 
            this.Username_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Username_txt.Enabled = false;
            this.Username_txt.Location = new System.Drawing.Point(84, 151);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(232, 20);
            this.Username_txt.TabIndex = 19;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(84, 235);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(232, 20);
            this.Password_txt.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.ProfileExit_label);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 31);
            this.panel2.TabIndex = 0;
            // 
            // ProfileExit_label
            // 
            this.ProfileExit_label.AutoSize = true;
            this.ProfileExit_label.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileExit_label.ForeColor = System.Drawing.Color.Red;
            this.ProfileExit_label.Location = new System.Drawing.Point(312, 6);
            this.ProfileExit_label.Name = "ProfileExit_label";
            this.ProfileExit_label.Size = new System.Drawing.Size(21, 19);
            this.ProfileExit_label.TabIndex = 0;
            this.ProfileExit_label.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edit Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BanlydPharmacy.Properties.Resources.sign_warning_icon_34355;
            this.pictureBox1.Location = new System.Drawing.Point(5, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BanlydPharmacy.Properties.Resources.avatar5;
            this.pictureBox2.Location = new System.Drawing.Point(131, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(9, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Username";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.BackColor = System.Drawing.Color.Teal;
            this.Username_lbl.Font = new System.Drawing.Font("High Tower Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.ForeColor = System.Drawing.Color.White;
            this.Username_lbl.Location = new System.Drawing.Point(149, 96);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(39, 15);
            this.Username_lbl.TabIndex = 12;
            this.Username_lbl.Text = "User";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Profile_panel);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(449, 482);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.Profile_panel.ResumeLayout(false);
            this.Profile_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Profile_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ProfileExit_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Username_lbl;
    }
}
