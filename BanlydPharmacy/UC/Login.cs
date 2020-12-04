using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using Tulpep.NotificationWindow;

namespace BanlydPharmacy.UC
{
    public partial class Login : UserControl
    {
        // GLOBAL VARIABLES
        Main main = new Main();
        DateTime dateTime;
        Thread th;
        string Username;
        int userID;
        string command;
        // DEFAULT CONSTRUCTOR
        public Login()
        {
            InitializeComponent();
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void StartMainForm()
        {
            Application.Run(new Main());
        }
        //
        private int ValidateUser(string commandT)
        {
            int count = 0; // count is a variable holding the number of rows selected
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(commandT, main.con);
            SqlDataAdapter da = new SqlDataAdapter(main.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            count = dt.Rows.Count;
            return count;
        }
        //
        private (int, string) GetUserDetails()
        {
            int ID = 0;
            string username = "";
            command = "Select * from [dbo].[Users] where Username = '" + Username_txt.Text + "' and Passwords = '" + Password_txt.Text + "'";
            main.con = new SqlConnection(main.conString);
            main.cmd = new SqlCommand(command, main.con);
            SqlDataAdapter da = new SqlDataAdapter(main.cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                ID = Convert.ToInt32(dr["UserID"].ToString());
            return (ID, username);
        }
        //
        private void AddLoginDetails(int id)
        {
            dateTime = DateTime.Now;
            int decision; // 1 for addition and 0 for updating
            command = "Select UserID from [dbo].[LoginDetails] Where UserID = '" + userID + "'";
            if (ValidateUser(command) == 1)
                decision = 0;
            else
                decision = 1;
            using (main.con = new SqlConnection(main.conString))
            {
                main.cmd = new SqlCommand("[dbo].[sp_AddLoginDetails]", main.con)
                { CommandType = CommandType.StoredProcedure };
                main.cmd.Parameters.AddWithValue("@Decision", decision);
                main.cmd.Parameters.AddWithValue("@UserID", id);
                main.cmd.Parameters.AddWithValue("@Date", dateTime.ToShortDateString());
                main.cmd.Parameters.AddWithValue("@Time", dateTime.ToShortTimeString());
                main.con.Open();
                main.cmd.ExecuteNonQuery();
            }
        }
        //
        private void Enter_Control(TextBox tb, string Placeholder)
        {
            try
            {
                if (tb.Text == Placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    tb.TextAlign = HorizontalAlignment.Left;
                }
            }
            catch { }
        }
        //
        private void Leave_Control(TextBox tb, string Placeholder)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.ForeColor = Color.Silver;
                tb.TextAlign = HorizontalAlignment.Center;
                tb.Text = Placeholder;
            }
        }
        //
        // EVENT HANDLERS
        //
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                Username_txt.Focus();
                Login_btn.Text = "Login";
                Login_btn.BackColor = Color.Green;
                Login_btn.ForeColor = Color.White;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_btn.Text.Trim() == "Login")
                {
                    Regex regPass = new Regex("(?!^[0-9]*$)(?!^[a-zA-Z]*$)(?=.*[A-Z])(?=.*[a-z])^([a-zA-Z0-9]{6,16})$");
                    command = "Select * from [dbo].[Users] where Username = '" + Username_txt.Text + "' and Passwords = '"
                        + Password_txt.Text + "'";
                    if (regPass.IsMatch(Password_txt.Text.ToString()))
                    {
                        if (ValidateUser(command) == 1)
                        {
                            LoginStatus_lbl.Visible = false;
                            User_picb.Image = Properties.Resources.images__1_;
                            Welcome_label.Text = "Welcome " + Username_txt.Text;
                            Welcome_label.ForeColor = Color.DodgerBlue;
                            Login_btn.BackColor = Color.DodgerBlue;
                            Login_btn.ForeColor = Color.White;
                            Login_btn.Text = "Proceed";
                            userID = GetUserDetails().Item1;
                            Username = GetUserDetails().Item2;
                            AddLoginDetails(userID);
                            // show a notification to the user using tulep notificaions
                            PopupNotifier notification = new PopupNotifier()
                            {
                                TitleText = "Welcome to boppiPharm",
                                ContentText = "boppiPharm is a software application developed to leverage the gaxp between tradition " +
                                "point of sale pharmaceutical apps and modern capabilities of visualising and analysing data trends for" +
                                "easy decision making. Your staff can be managed with just a click.",
                                Delay = 10000,
                                TitleFont = new Font("Times New Roman", 14F, FontStyle.Bold),
                                ContentFont = new Font("Times New Roman", 12F, FontStyle.Regular),
                                ContentColor = Color.DodgerBlue,
                                TitleColor = Color.Crimson,
                            };
                            notification.Popup();
                        }
                        else
                        {
                            LoginStatus_lbl.Visible = true;
                            LoginStatus_lbl.Text = "Incorrect username or password";
                        }
                    }
                    else
                    {
                        LoginStatus_lbl.Visible = true;
                        LoginStatus_lbl.Text = "Passwords do not match";
                    }
                }
                else if (Login_btn.Text.Trim() == "Proceed")
                {
                    Application.ExitThread();
                    th = new Thread(StartMainForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                    MessageBox.Show("Contact the administrator for assistance", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Username_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                Enter_Control(Username_txt, "username");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Username_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                Leave_Control(Username_txt, "username");
                command = "Select Username from [dbo].[Users] where Username = '" + Username_txt.Text + "'";
                Username_picb.SizeMode = PictureBoxSizeMode.Zoom;
                if (ValidateUser(command) == 1)
                    Username_picb.Image = Properties.Resources._2000px_Gtk_ok_svg;
                else
                    Username_picb.Image = Properties.Resources.images__1_1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Control ctrl = (Control)sender;
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                {   // move cursor to the next tool (the curson moves according to the tab indices)
                    this.SelectNextControl(ctrl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Up)
                {   // movvee cursor to the previous tool
                    this.SelectNextControl(ctrl, false, true, true, true);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Username_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Password_txt_Enter(object sender, EventArgs e)
        {
            try
            {
                Enter_Control(Password_txt, "password");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Password_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                Leave_Control(Password_txt, "password");
                command = "Select Passwords from [dbo].[Users] where Passwords = '" + Password_txt.Text + "'";
                Password_picb.SizeMode = PictureBoxSizeMode.Zoom;
                if (ValidateUser(command) == 1)
                    Password_picb.Image = Properties.Resources._2000px_Gtk_ok_svg;
                else
                    Password_picb.Image = Properties.Resources.images__1_1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void ViewPassword_picb_Click(object sender, EventArgs e)
        {
            if(Password_txt.Text.Trim() == "username")
            {
                Password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                if (Password_txt.UseSystemPasswordChar)
                    Password_txt.UseSystemPasswordChar = false;
                else
                    Password_txt.UseSystemPasswordChar = true;
            }
        }
        //
        private void Password_txt_TextChanged(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
        }
    }
}
