using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BanlydPharmacy
{
    public partial class Main : Form
    {
        // GLOBAL AND PUBLIC VARIABLES
        public string conString;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public string Company_Name, Branch;
        public string Username;
        public int userId;
        private string command;
        int x, y;
        // DEFAULT CONSTRUCTOR
        public Main()
        {
            InitializeComponent();
            conString = @"Data Source=ISAAC\ISAACSQLSERVER;Initial Catalog=BanlydPharmacy;Integrated Security=True";
            Company_Name = "BANLYD PHARMACY LTD.";
            Branch = "DORMAA AHENKRO";
            userId = UserDetails().Item2;
            Username = UserDetails().Item1;
            x = Screen.PrimaryScreen.Bounds.Width;
            y = Screen.PrimaryScreen.Bounds.Height;
            TodaysDate = DateTime.Now;
        }
        // PROPERTIES
        public DateTime TodaysDate { get; }
        //
        // USER-DEFINED FUNCTIONS
        //
        private void LoginAgain()
        {
            Application.Run(new SplashScreen());
        }
        //
        public (string, int) UserDetails()
        {
            string username = "";
            int id = 0;
            command = "SELECT TOP (1) * FROM [dbo].[vViewUsers] ORDER BY LoginDate Desc, LoginTime Desc";
            con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                username = dr["Username"].ToString().Trim();
                id = Convert.ToInt32(dr["UserID"].ToString());
            }
            return (username, id);
        }
        //
        // EVENT HANDLERS
        //
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Sales childform = new Sales { MdiParent = this };
                childform.Show();
                this.Text = "boppiPharm - " + Company_Name + " ( " + Username + " )";
                Size = new Size((x/2)+(x/3), (y/2)+(y/3));
                Location = new Point((x-Size.Width)/2, (y-Size.Height)/2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void PersonalProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void PointOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Sales childform = new Sales { MdiParent = this };
                childform.Size = new Size(this.Size.Width, this.Size.Height);
                childform.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void StockQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.Stock newForm = new Forms.Stock { MdiParent = this };
                newForm.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                User form = new User();
                form.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.Calculator newForm = new Forms.Calculator();
                newForm.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                Application.ExitThread(); // close this thread and start a new thread
                Thread th = new Thread(LoginAgain);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to leave?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Application.Exit(); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}