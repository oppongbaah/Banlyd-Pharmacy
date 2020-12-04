using System;
using System.Drawing;
using System.Windows.Forms;

namespace BanlydPharmacy
{
    public partial class User : Form
    {
        // GLOBAL VARIABLES
        UC.ChangePassword ChangePassword_uc;
        UC.AddUser AddUser_uc;
        UC.ManageUsers ManageUser_uc;
        UC.RecentUsers RecentUser_uc;
        int width, height;
        // DEFAULT CONSTRUCTOR
        public User()
        {
            InitializeComponent();
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
            this.Size = new Size((width/2) + (width/5), height/2);
        }
        //
        // USER-DEFINED FUNCTIONS
        //
        public void AddUserControl(UserControl uc, int columnIndex, int columnSpan, int rowIndex, int rowSpan)
        {
            User_tlp.Controls.Add(uc, columnIndex, rowIndex);
            User_tlp.SetColumnSpan(uc, columnSpan);
            User_tlp.SetRowSpan(uc, rowSpan);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            uc.Margin = new Padding(3, 0, 3, 3);
        }
        //
        // EVENT HANLERS
        //
        private void User_Load(object sender, EventArgs e)
        {
            RecentUser_uc = new UC.RecentUsers();
            AddUserControl(RecentUser_uc, 0, 5, 2, 3);
            ChangePassword_uc = new UC.ChangePassword();
            AddUserControl(ChangePassword_uc, 0, 5, 2, 3);
            AddUser_uc = new UC.AddUser();
            AddUserControl(AddUser_uc, 0, 5, 2, 3);
            ManageUser_uc = new UC.ManageUsers();
            AddUserControl(ManageUser_uc, 0, 5, 2, 3);
            ManageUser_uc.BringToFront();
        }
        //
        private void Home_menu_Click(object sender, EventArgs e)
        {
            ManageUser_uc.BringToFront();
        }
        //
        private void New_menu_Click(object sender, EventArgs e)
        {
            AddUser_uc.BringToFront();
        }
        //
        private void Update_menu_Click(object sender, EventArgs e)
        {
            ChangePassword_uc.BringToFront();
        }
        //
        private void RecentUsers_menu_Click(object sender, EventArgs e)
        {
            RecentUser_uc.BringToFront();
        }
        //
        private void Close_picbox_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        // function to quit the program when esc key is pressed
        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 27)
            {
                if (MessageBox.Show("Do you want to exit", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    this.Close();
            }
        }
    }
}
