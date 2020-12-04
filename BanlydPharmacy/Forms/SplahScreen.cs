using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace BanlydPharmacy
{
    public partial class SplashScreen : Form
    {
        // GLOBAL VARIABLES
        int width, height;
        // DEFAULT CONSTRUCTOR
        public SplashScreen()
        {
            InitializeComponent();
            InitialiseMyComponents();
            // get the screen resolution of the specific computer
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void AddControl(TableLayoutPanel tlp, Control ctrl, int column, int row, int columnSpan, int rowSpan)
        {
            tlp.Controls.Add(ctrl, column, row);
            tlp.SetColumnSpan(ctrl, columnSpan);
            tlp.SetRowSpan(ctrl, rowSpan);
            tlp.Dock = DockStyle.Fill;
            ctrl.Dock = DockStyle.Fill;
        }
        //
        // EVENT HANDLERS
        //
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                // set the size and location of the window
                Size = new Size(width/2, height/2);
                Location = new Point((width / 2) - (Size.Width / 2), (height / 2) - (Size.Height / 2));
                Controls.Add(SplashScreen_tlp);                
                // add controls to the table layout panel
                AddControl(SplashScreen_tlp, SplashScreen_picb, 0, 0, 2, 1);
                AddControl(SplashScreen_tlp, LoadingStatus_lbl, 0, 1, 1, 1);
                AddControl(SplashScreen_tlp, Loading_progbar, 1, 1, 1, 1);
                // set some other properties
                Login_timer.Start();
                Login_backGW.WorkerReportsProgress = true;
                Login_backGW.RunWorkerAsync();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Login_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Login_backGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    // delay the progress bar for 0.1s for each iteration = 10s for all 100 iterations
                    Thread.Sleep(100);
                    Login_backGW.ReportProgress(i);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Login_backGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            try
            {
                Loading_progbar.Value = e.ProgressPercentage;
                LoadingStatus_lbl.Text = "Please wait . . . " + e.ProgressPercentage.ToString();
                if(e.ProgressPercentage == 0)
                {
                    SplashScreen_picb.Image = Properties.Resources.stocksnaps5wgvl18a9;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                if (e.ProgressPercentage == 10)
                {
                    SplashScreen_picb.Image = Properties.Resources.wp1931610;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                if (e.ProgressPercentage == 20)
                {
                    SplashScreen_picb.Image = Properties.Resources.download;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                if (e.ProgressPercentage == 30)
                {
                    SplashScreen_picb.Image = Properties.Resources.pharmacist_2551090_960_720;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (e.ProgressPercentage == 40)
                {
                    SplashScreen_picb.Image = Properties.Resources.pharmacist_helping_an_elderly_person_illustration_csp20040727;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (e.ProgressPercentage == 50)
                {
                    SplashScreen_picb.Image = Properties.Resources._5614_clinical_pharmacy_and_pharmacology;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (e.ProgressPercentage == 60)
                {
                    SplashScreen_picb.Image = Properties.Resources.Pill_bottle_spilling;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (e.ProgressPercentage == 70)
                {
                    SplashScreen_picb.Image = Properties.Resources.OriginalLogo;
                    SplashScreen_picb.SizeMode = PictureBoxSizeMode.Zoom;
                }
                if (e.ProgressPercentage == 100)
                {
                    // remove the the table layout panel and add the login form
                    Controls.Remove(SplashScreen_tlp);
                    Size = new Size(520, 540);
                    StartPosition = FormStartPosition.Manual;
                    Location = new Point((width/2) - (Size.Width/2), (height/2) - (Size.Height/2));
                    Controls.Add(Login_tlp);
                    UC.Login login = new UC.Login
                    {
                        Name = "login_uc",
                        Dock = DockStyle.Fill
                    };
                    AddControl(Login_tlp, logo_picb, 0, 0, 1, 1);
                    AddControl(Login_tlp, HearderName_lbl, 1, 0, 1, 1);
                    AddControl(Login_tlp, Minimise_picb, 2, 0, 1, 1);
                    AddControl(Login_tlp, Close_picb, 3, 0, 1, 1);
                    AddControl(Login_tlp, login, 0, 1, 4, 1);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Close_picb_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        //
        private void Minimise_picb_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
