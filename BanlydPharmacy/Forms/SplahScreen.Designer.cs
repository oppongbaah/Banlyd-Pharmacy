namespace BanlydPharmacy
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new 
                System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Login_timer = new System.Windows.Forms.Timer(this.components);
            this.Login_backGW = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Login_timer
            // 
            this.Login_timer.Enabled = true;
            this.Login_timer.Interval = 10000;
            this.Login_timer.Tick += new System.EventHandler(this.Login_timer_Tick);
            // 
            // Login_backGW
            // 
            this.Login_backGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Login_backGW_DoWork);
            this.Login_backGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Login_backGW_ProgressChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(775, 395);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "boppiPharm";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region Initialise and define the properties of all aded controls here
        /// <summary>
        /// Develop codes for programmable design
        /// </summary>
        private void InitialiseMyComponents()
        {
            //
            // Login_tlp
            //
            Login_tlp = new System.Windows.Forms.TableLayoutPanel
            {
                BackColor = System.Drawing.Color.White,
                ColumnCount = 4,
                Location = new System.Drawing.Point(0, 0),
                Name = "Login_tlp",
                Padding = new System.Windows.Forms.Padding(3),
                RowCount = 2,
                Size = new System.Drawing.Size(775, 395),
                TabIndex = 1,
                Margin = new System.Windows.Forms.Padding(3, 3, 3, 3)
            };
            // Setting the rows styles
            this.Login_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Login_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            // Setting the column styles
            this.Login_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Login_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Login_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Login_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            //
            // SplashScreen_tlp
            //
            SplashScreen_tlp = new System.Windows.Forms.TableLayoutPanel
            {
                BackColor = System.Drawing.Color.White,
                ColumnCount = 2,
                Location = new System.Drawing.Point(0, 0),
                Name = "SplashScreen_tlp",
                Padding = new System.Windows.Forms.Padding(3),
                RowCount = 2,
                Size = new System.Drawing.Size(775, 395),
                TabIndex = 2
            };
            // Setting the rows styles
            this.SplashScreen_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.SplashScreen_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            // Setting the column styles
            this.SplashScreen_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SplashScreen_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            //
            // Other controls
            //
            SplashScreen_picb = new System.Windows.Forms.PictureBox
            {
                Name = "SplashScreen_picb"
            };
            //
            LoadingStatus_lbl = new System.Windows.Forms.Label
            {
                Name = "LoadingStatus_lbl",
                Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.Crimson
            };
            //
            Loading_progbar = new System.Windows.Forms.ProgressBar
            {
                Name = "Loading_progbar"
            };
            //
            Close_picb = new System.Windows.Forms.PictureBox
            {
                Name = "Close_picb",
                Image = Properties.Resources._2931151___bin_close_delete_exit_recycle_remove_x,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(3, 3, 3, 3)
            };
            Close_picb.Click += new System.EventHandler(this.Close_picb_Click);
            //
            Minimise_picb = new System.Windows.Forms.PictureBox
            {
                Name = "Minimise_picb",
                Image = Properties.Resources._2931142___delete_minimize_minus_remove,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Margin = new System.Windows.Forms.Padding(3, 3, 3, 3)
            };
            Minimise_picb.Click += new System.EventHandler(this.Minimise_picb_Click);
            //
            HearderName_lbl = new System.Windows.Forms.Label()
            {
                Text = "boppiPharm",
                ForeColor = System.Drawing.Color.Crimson,
                Font = new System.Drawing.Font("Franklin Gothic Heavy", 25F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            //
            logo_picb = new System.Windows.Forms.PictureBox()
            {
                Image = Properties.Resources.sign_emergency_code_sos_24_icon_icons_com_57215,
                Dock = System.Windows.Forms.DockStyle.Fill,
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            };
        }
        #endregion
        private System.Windows.Forms.Timer Login_timer;
        private System.ComponentModel.BackgroundWorker Login_backGW;
        // Explicitly add my controls
        private System.Windows.Forms.TableLayoutPanel SplashScreen_tlp;
        private System.Windows.Forms.TableLayoutPanel Login_tlp;
        private System.Windows.Forms.PictureBox SplashScreen_picb;
        private System.Windows.Forms.Label LoadingStatus_lbl;
        private System.Windows.Forms.ProgressBar Loading_progbar;
        private System.Windows.Forms.PictureBox Minimise_picb;
        private System.Windows.Forms.PictureBox Close_picb;
        private System.Windows.Forms.Label HearderName_lbl;
        private System.Windows.Forms.PictureBox logo_picb;
    }
}

