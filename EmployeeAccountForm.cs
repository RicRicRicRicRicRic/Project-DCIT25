using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class EmployeeAccountForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        private EmployeeCoffeeShop parentForm;
        private string accountId;

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadingStart();
            panel5.Paint += panel5_Paint;
            DisplayEmployeeInfo();
            EmployeeStats();
            EmployeePictureDisplay();
        }

        /////***************ACCOUNT INFO DISPLAY***************////////***************ACCOUNT INFO DISPLAY***************///
        public EmployeeAccountForm(EmployeeCoffeeShop parentForm, string accountId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.accountId = accountId;
            textBoxAccountIDdisplay.Text = accountId;

        }
        public void DisplayEmployeeInfo()
        {
            string accID = accountId;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT 
            Account.AccountID, 
            Employee.EmployeeID,
            Employee.EmployeeName, 
            Employee.EmployeeRole,
            Employee.SalaryPerHour,
            Employee.EmployeeHireDate
            FROM Account
            JOIN Employee ON Account.EmployeeID = Employee.EmployeeID
            WHERE Account.AccountID = @AccountID;", connection);
                cmd.Parameters.AddWithValue("@AccountID", accID);

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    switch (reader["EmployeeID"])
                    {
                        case DBNull _:
                            textBoxEmployeeID.Text = "NO DATA FOUND";
                            break;
                        default:
                            textBoxEmployeeID.Text = reader["EmployeeID"].ToString();
                            break;
                    }
                    switch (reader["SalaryPerHour"])
                    {
                        case DBNull _:
                            textBoxSalary.Text = "NO DATA FOUND";
                            break;
                        default:
                            textBoxSalary.Text = reader["SalaryPerHour"].ToString();
                            break;
                    }
                    switch (reader["EmployeeHireDate"])
                    {
                        case DBNull _:
                            textBoxHireDate.Text = "NO DATA FOUND";
                            break;
                        default:
                            DateTime hireDate = Convert.ToDateTime(reader["EmployeeHireDate"]);
                            textBoxHireDate.Text = hireDate.ToString("yyyy-MM-dd");
                            break;
                    }
                    switch (reader["EmployeeRole"])
                    {
                        case DBNull _:
                            textBoxEmployeeRole.Text = "NO DATA FOUND";
                            break;
                        default:
                            textBoxEmployeeRole.Text = reader["EmployeeRole"].ToString();
                            break;
                    }
                    switch (reader["EmployeeName"])
                    {
                        case DBNull _:
                            textBoxEmployeeName.Text = "NO DATA FOUND";
                            break;
                        default:
                            textBoxEmployeeName.Text = reader["EmployeeName"].ToString();
                            break;
                    }
                }

            }
        }


        //***************ACCOUNT INFO DISPLAY***************////***************ACCOUNT INFO DISPLAY***************//

        //***************LOG OUT BUTTON***************////***************LOG OUT BUTTON***************//
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                parentForm.Close();
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
        //***************LOG OUT BUTTON***************////***************LOG OUT BUTTON***************//

        //***************EMPLOYEE INFORMATION DISPLAY***************// //***************EMPLOYEE INFORMATION DISPLAY***************//
        private void EmployeeStats()
        {
            string empID = textBoxEmployeeID.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT " +
                    "SUM(OrderRevenue) AS EmployeeRevenue," +
                    "SUM(OrderCustomer) AS EmployeeCustServed," +
                    "SUM(OrderProductsSold) AS EmployeeProdSold " +
                    "FROM Orders WHERE EmployeeID = @IDofEmployee ", connection);

                cmd.Parameters.AddWithValue("@IDofEmployee", empID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double RevenueGenerated;
                    int ProductSold;
                    int CustomerServed;

                    switch (reader["EmployeeRevenue"])
                    {
                        case DBNull _:
                            RevenueGenerated = 0.0;
                            break;
                        default:
                            RevenueGenerated = Convert.ToDouble(reader["EmployeeRevenue"]);
                            break;
                    }
                    switch (reader["EmployeeProdSold"])
                    {
                        case DBNull _:
                            ProductSold = 0;
                            break;
                        default:
                            ProductSold = (int)reader["EmployeeProdSold"];
                            break;
                    }
                    switch (reader["EmployeeCustServed"])
                    {
                        case DBNull _:
                            CustomerServed = 0;
                            break;
                        default:
                            CustomerServed = (int)reader["EmployeeCustServed"];
                            break;
                    }
                    textBoxRevenue.Text = "₱" + RevenueGenerated.ToString();
                    textBoxProducts.Text = ProductSold.ToString();
                    textBoxCustomers.Text = CustomerServed.ToString();
                }
            }
        }

        //***************EMPLOYEE INFORMATION DISPLAY***************// //***************EMPLOYEE INFORMATION DISPLAY***************////***************EMPLOYEE INFORMATION DISPLAY***************// //***************EMPLOYEE INFORMATION DISPLAY***************//

        //***************PROFILE PICTURE EMPLOYEE DISPALY***************////***************PROFILE PICTURE EMPLOYEE DISPALY***************//  //***************PROFILE PICTURE EMPLOYEE DISPALY***************////***************PROFILE PICTURE EMPLOYEE DISPALY***************//

        private void EmployeePictureDisplay()
        {
            string empID = textBoxEmployeeID.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeImage AS ProfileEmp FROM Employee WHERE EmployeeID = @IDofEmployee", connection);
                cmd.Parameters.AddWithValue("@IDofEmployee", empID);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dta = new DataSet();
                sda.Fill(dta, "EmployeeImage");
                int c = dta.Tables["EmployeeImage"].Rows.Count;

                if (c > 0)
                {
                    if (dta.Tables["EmployeeImage"].Rows[c - 1]["ProfileEmp"] != DBNull.Value)
                    {
                        Byte[] byteEmployeeImage = (Byte[])(dta.Tables["EmployeeImage"].Rows[c - 1]["ProfileEmp"]);
                        MemoryStream stmEmployeeImage = new MemoryStream(byteEmployeeImage);
                        EmployeePicture.Image = Image.FromStream(stmEmployeeImage);
                    }
                    else
                    {
                        EmployeePicture.Image = EmployeePicture.Image;
                    }
                }
                else
                {
                    EmployeePicture.Image = null;
                }
                connection.Close();
            }
        }


        //***************PROFILE PICTURE EMPLOYEE DISPALY***************////***************PROFILE PICTURE EMPLOYEE DISPALY***************////***************PROFILE PICTURE EMPLOYEE DISPALY***************////***************PROFILE PICTURE EMPLOYEE DISPALY***************//

        //***************PANEL DESIGNS***************////***************PANEL DESIGNS***************////***************PANEL DESIGNS***************////***************PANEL DESIGNS***************//
        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint_1(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelName_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelRole_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelSalary_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelSalGen_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel2_Paint_1(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel6_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void LoadingPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            GraphicsPath panelPath = new GraphicsPath();
            int cornerRadius = 20;
            panelPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
            panelPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
            panelPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            panelPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            panelPath.CloseFigure();

            panel.Region = new Region(panelPath);

            using (SolidBrush brush = new SolidBrush(panel.BackColor))
            {
                e.Graphics.FillPath(brush, panelPath);
            }

            using (Pen pen = new Pen(Color.Black, 4))
            {
                e.Graphics.DrawPath(pen, panelPath);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            GraphicsPath panelPath = new GraphicsPath();
            int cornerRadius = 20;

            panelPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 180, 90);
            panelPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Top, cornerRadius * 2, cornerRadius * 2, 270, 90);
            panelPath.AddArc(panel.ClientRectangle.Right - cornerRadius * 2, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            panelPath.AddArc(panel.ClientRectangle.Left, panel.ClientRectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            panelPath.CloseFigure();

            panel.Region = new Region(panelPath);

            using (SolidBrush brush = new SolidBrush(panel.BackColor))
            {
                e.Graphics.FillPath(brush, panelPath);
            }
        }

        /////***************PANEL DESIGNS***************////////***************PANEL DESIGNS***************///

        //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************//
        private void LoadingStart()
        {
            LoadPanel.Width = 10;
            increment = GetRandomIncrement();
            LoadingTimer.Start();
            LoadingPanel.BringToFront();
        }
        private void LoadingTimer_Tick_1(object sender, EventArgs e)
        {
            LoadPanel.Width += increment;
            if (LoadPanel.Width >= 474)
            {
                LoadingTimer.Stop();
                LoadingPanel.Visible = false;
                LoadPanel.Width = 10;
               
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

        //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************//


    }
}
