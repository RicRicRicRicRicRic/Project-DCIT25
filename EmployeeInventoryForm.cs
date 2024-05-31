using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CoffeeShop
{
    public partial class EmployeeInventoryForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public EmployeeInventoryForm()
        {
            InitializeComponent();
        }
        private void InventoryEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadingStart();
            timer1.Start();
            panel5.Paint += panel5_Paint;
            FillFoodDGV();
            FillOrderDGV();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            InverntoryDGV.ClearSelection();
            OrderDGV.ClearSelection();
        }
        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        //***************BUTTON BEHAVIOR***************// //***************BUTTON BEHAVIOR***************// //***************BUTTON BEHAVIOR***************// 
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] { Foodbutton, HCoffeebutton, ColdCoffeebutton })
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.OldLace;
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.BackColor = Color.SaddleBrown;
                    button.ForeColor = Color.White;
                }
            }
        }

        private void Foodbutton_Click(object sender, EventArgs e)
        {
            InverntoryDGV.ClearSelection();
            OrderDGV.ClearSelection();

            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            FillFoodDGV();
            InverntoryDGV.AutoGenerateColumns = true;
            timer1.Start();
        }
        private void HCoffeebutton_Click(object sender, EventArgs e)
        {
            InverntoryDGV.ClearSelection();
            OrderDGV.ClearSelection();

            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            FillHotCoffeeDGV();
            InverntoryDGV.AutoGenerateColumns = true;
            timer1.Start();
        }
        private void ColdCoffeebutton_Click(object sender, EventArgs e)
        {
            InverntoryDGV.ClearSelection();
            OrderDGV.ClearSelection();

            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            FillColdCoffeeDGV();
            InverntoryDGV.AutoGenerateColumns = true;
            timer1.Start();
        }
        //***************BUTTON BEHAVIOR***************// //***************BUTTON BEHAVIOR***************// //***************BUTTON BEHAVIOR***************// 

        //***************FILL DGV***************// //***************FILL DGV***************// //***************FILL DGV***************// 
        private void FillFoodDGV()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT FoodStatus, FoodStock, FoodPrice, FoodName, FoodID FROM FoodInventory";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            InverntoryDGV.DataSource = dta;
            connection.Close();
        }
        private void FillHotCoffeeDGV()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT HotCoffeeStatus, HotCoffeeStock, HotCoffeePrice, HotCoffeeName, HotCoffeeID FROM HotCoffeeInventory";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            InverntoryDGV.DataSource = dta;
            connection.Close();
        }
        private void FillColdCoffeeDGV()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT ColdCoffeeStatus, ColdCoffeeStock, ColdCoffeePrice, ColdCoffeeName, ColdCoffeeID FROM ColdCoffeeInventory";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            InverntoryDGV.DataSource = dta;
            connection.Close();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            InverntoryDGV.ClearSelection();
            OrderDGV.ClearSelection();
            FillOrderDGV();
            timer1.Start();
        }
        private void FillOrderDGV() 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT  EmployeeID,OrderDate,OrderProductsSold,OrderCustomer,OrderRevenue,OrderID FROM Orders WHERE OrderDate = @SelectedDate";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", dateTimePicker.Value.Date);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                OrderDGV.DataSource = dt;
            }
        }
        //***************FILL DGV***************// //***************FILL DGV***************// //***************FILL DGV***************// 

        //***************PANEL DESIGNS***************// //***************PANEL DESIGNS***************// //***************PANEL DESIGNS***************//
        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void LoadingPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel3_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

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
        //***************PANEL DESIGNS***************// //***************PANEL DESIGNS***************// //***************PANEL DESIGNS***************//

        //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************// //***************LOADING FUNCTION***************//
        private void LoadingStart()
        {
            LoadPanel.Width = 10;
            increment = GetRandomIncrement();
            LoadingTimer.Start();
            LoadingPanel.BringToFront();
        }
        
        private void LoadingTimer_Tick(object sender, EventArgs e)
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
