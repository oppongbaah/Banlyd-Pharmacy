using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BanlydPharmacy.Forms
{
    public partial class Calculator : Form
    {
        // Global variables
        int x, y;
        // default constructor
        public Calculator()
        {
            InitializeComponent();
            InitialiseStandard_uc();
        }
        //
        // User defined functions
        //
        public void ShowUserCotrol(UserControl uc, int col, int colSpan)
        {
            this.Main_tlp.Controls.Add(uc, col, 2);
            Main_tlp.SetColumnSpan(uc, colSpan);
            Main_tlp.SetRowSpan(uc, 1);
            uc.Dock = DockStyle.Fill;
        }
        //
        // Event handlers
        //
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                Navigation_pnl.Visible = false;
                Mode_lbl.Text = Standard_btn.Text;
                Highlight_lbl.Location = new Point(7, 50);
                //
                Main_tlp.SetColumnSpan(Navigation_pnl, 1);
                ShowUserCotrol(Standard_uc, 1, 2);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        //
        private void Navigation_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                x = 7;
                y = btn.Location.Y + 5;
                Highlight_lbl.Location = new Point(x, y);
                Highlight_lbl.Visible = Mode_lbl.Visible = true;
                btn.SendToBack();
                switch (btn.Name)
                {
                    case "Standard_btn":
                        {
                            Navigation_pnl.Visible = false;
                            Mode_lbl.Text = "Standard";
                            ShowUserCotrol(Standard_uc, 2, 2);
                            Standard_uc.Select();
                            break;
                        }
                    case "Date_btn":
                        {
                            throw new NotImplementedException();
                            // break;
                        }
                    case "Currency_btn":
                        {
                            throw new NotImplementedException();
                            //  break;
                        }
                    case "Volumn_btn":
                        {
                            throw new NotImplementedException();
                            //  break;
                        }
                    case "Length_btn":
                        {
                            throw new NotImplementedException();
                            //  break;
                        }
                    case "Weight_btn":
                        {
                            throw new NotImplementedException();
                            //  break;
                        }
                    case "Temperature_btn":
                        {
                            throw new NotImplementedException();
                            // break;
                        }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        //
        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void ShowNavList_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Navigation_pnl.Visible)
                {
                    Navigation_pnl.Visible = true;
                    Mode_lbl.Visible = false;
                    // if in standard mode
                    Main_tlp.SetColumnSpan(Navigation_pnl, 2);
                    ShowUserCotrol(Standard_uc, 2, 1);
                }
                else if (Navigation_pnl.Visible)
                {
                    Navigation_pnl.Visible = false;
                    Mode_lbl.Visible = true;
                    // if in standard mode
                    Main_tlp.SetColumnSpan(Navigation_pnl, 1);
                    ShowUserCotrol(Standard_uc, 1, 2);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
    }
}

