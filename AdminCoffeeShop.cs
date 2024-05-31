using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AdminCoffeeShop : Form
    {
        private Form activeForm;
        public AdminCoffeeShop()
        {
            InitializeComponent();

        }
        private void AdminCoffeeShop_Load(object sender, EventArgs e)
        {
            LoadingPanel.SendToBack();
        }
        private void OpenChildForm(Form childForm, object clickedButton)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            SetButtonBackgrounds(clickedButton as Button);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesORno == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
        //***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************//
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] { AddRemEmp_Button, ManageEmp_Button, Inventory_button, Sales_button, Account_button })
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.Indigo;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = Color.MediumPurple;
                    button.Enabled = true;
                }
            }
        }
        private void AddRemEmp_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAddRemEmpForm(), sender);    
            LoadingStart();
        }
        private void ManageEmp_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminManageEmpForm(), sender);
            LoadingStart();
        }

        private void Inventory_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminInventoryForm(), sender);
            LoadingStart();
        }
        private void Sales_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminSalesForm(), sender);
            LoadingStart();
        }
        private void Account_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdminAccountForEmpForm(), sender);
            LoadingStart();
        }
        //***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************//

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//
        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel8_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void LoadingPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

        //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************//
        private void LoadingStart()
        {
            LoadPanel.Width = 10;
            increment = GetRandomIncrement();
            LoadingTimer.Start();
            LoadingPanel.BringToFront();
            DesktopPanel.SendToBack();
            panel8.BringToFront();
        }
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadPanel.Width += increment;
            if (LoadPanel.Width >= 474)
            {
                LoadingTimer.Stop();
                LoadingPanel.SendToBack();
                DesktopPanel.BringToFront();
                LoadPanel.Width = 10;
                panel8.BringToFront();
            }
        }
        private Random random = new Random();
        private int increment;
        private int GetRandomIncrement()
        {
            int[] increments = { 5, 10, 15, 20 };
            int index = random.Next(0, increments.Length);
            return increments[index];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************//

    }
}
