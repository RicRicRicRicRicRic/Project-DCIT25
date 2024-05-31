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
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace CoffeeShop
{
    public partial class EmployeeSalesForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public EmployeeSalesForm()
        {
            InitializeComponent();

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd";

        }
        private void SalesForm_Load(object sender, EventArgs e)
        {
            panel5.Paint += panel5_Paint;
            FillChartCustomersbyDay();
            FillChartRevenueByDay();
        }

        //***************PANEL DESIGNS**************// //***************PANEL DESIGNS**************//  //***************PANEL DESIGNS**************// //***************PANEL DESIGNS**************// 

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

        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel7_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel6_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel8_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel9_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void DesktopPanel_Paint_1(object sender, PaintEventArgs e){ DrawPanelBorder(sender, e);}

        //***************PANEL DESIGNS**************// //***************PANEL DESIGNS**************//  //***************PANEL DESIGNS**************// //***************PANEL DESIGNS**************// 
        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            FillChartCustomersbyDay();
            FillChartRevenueByDay();
            DateTime selectedDTP = dateTimePicker.Value.Date;
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT RevenueDaily, CustomersDaily, ProductsSoldDaily" +
                        " FROM Sales WHERE DateOfSales = @SelectedDate", connection);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDTP);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxRevenue.Text = "₱" + reader["RevenueDaily"].ToString();
                        textBoxCustomers.Text = reader["CustomersDaily"].ToString();
                        textBoxProduct.Text = reader["ProductsSoldDaily"].ToString();
                    }
                    else
                    {
                        textBoxRevenue.Clear();
                        textBoxCustomers.Clear();
                        textBoxProduct.Clear();
                    }
                    reader.Close();
                }
            }
        }

        private void comboBoxOrganize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedOption = comboBoxOrganize.SelectedItem.ToString();

            if (selectedOption == "Organize by Day")
            {
                FillChartCustomersbyDay();
                FillChartRevenueByDay();
            }
            else if (selectedOption == "Organize by Month")
            {
                FillChartCustomersByMonth();
                FillChartRevenueByMonth();
            }
            else if (selectedOption == "Organize by Year")
            {
                FillChartCustomersByYear();
                FillChartRevenueByYear();
            }
        }

        //***************DAY - FILL CHART DATA**************// //***************DAY - FILL CHART DATA**************//   
        private void FillChartCustomersbyDay()
        {
            chartCustomer.Series["CustData"].Points.Clear();
            DateTime selectedDate = dateTimePicker.Value.Date;
            DateTime previousDates = selectedDate.AddDays(-6); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DateOfSales, CustomersDaily, ProductsSoldDaily FROM Sales WHERE DateOfSales " +
                    "BETWEEN @PreviousDates AND @SelectedDate", connection);
                cmd.Parameters.AddWithValue("@PreviousDates", previousDates); 
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["DateOfSales"];
                    int customers = Convert.ToInt32(reader["CustomersDaily"]);
                    int products = Convert.ToInt32(reader["ProductsSoldDaily"]);
                    chartCustomer.Series["CustData"].Points.AddXY(date.ToString("yyyy-MM-dd"), customers);
                    textBoxCustomers.Text = customers.ToString();
                    textBoxProduct.Text = products.ToString();
                }
                reader.Close();
            }
        }
        private void FillChartRevenueByDay()
        {
            chartRevenue.Series["RevenueData"].Points.Clear();
            DateTime selectedDate = dateTimePicker.Value.Date;
            DateTime previousDates = selectedDate.AddDays(-6);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT DateOfSales, RevenueDaily FROM Sales WHERE DateOfSales" +
                    " BETWEEN @PreviousDates AND @SelectedDate", connection);
                cmd.Parameters.AddWithValue("@PreviousDates", previousDates);
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["DateOfSales"];
                    double revenue = 0;
                    if (reader["RevenueDaily"] != DBNull.Value)
                    {
                        revenue = Convert.ToDouble(reader["RevenueDaily"]);
                        textBoxRevenue.Text = "₱" + revenue.ToString();
                    }
                    chartRevenue.Series["RevenueData"].Points.AddXY(date.ToString("yyyy-MM-dd"), revenue);
                }
                reader.Close();
            }
        }

        //***************DAY - FILL CHART DATA**************// //***************DAY - FILL CHART DATA**************//

        //***************MONTH - FILL CHART DATA**************// //***************MONTH - FILL CHART DATA**************//
        private void FillChartRevenueByMonth()
        {
            chartRevenue.Series["RevenueData"].Points.Clear();
            textBoxRevenue.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MONTH(DateOfSales) AS SalesMonth, " +
                    "SUM(RevenueDaily) AS TotalRevenue" +
                    " FROM Sales WHERE YEAR(DateOfSales) = YEAR(GETDATE())" +
                    " GROUP BY MONTH(DateOfSales)", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int month = (int)reader["SalesMonth"];
                    double revenue = Convert.ToDouble(reader["TotalRevenue"]);

                    string monthName = GetMonthName(month);
                    chartRevenue.Series["RevenueData"].Points.AddXY(monthName, revenue);

                    if (month == dateTimePicker.Value.Month)
                    {
                        textBoxRevenue.Text = "₱" + revenue.ToString();
                    }
                }
                reader.Close();
            }
        }
        

        private void FillChartCustomersByMonth()
        {
            chartCustomer.Series["CustData"].Points.Clear();
            textBoxCustomers.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MONTH(DateOfSales) AS SalesMonth," +
                    " SUM(CustomersDaily) AS TotalCustomers," +
                    " SUM(ProductsSoldDaily) AS TotalProducts " +
                    "FROM Sales WHERE YEAR(DateOfSales) = YEAR(GETDATE()) " +
                    "GROUP BY MONTH(DateOfSales)", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int month = (int)reader["SalesMonth"];
                    int customers = Convert.ToInt32(reader["TotalCustomers"]);
                    int products = Convert.ToInt32(reader["TotalProducts"]);

                    string monthName = GetMonthName(month);
                    chartCustomer.Series["CustData"].Points.AddXY(monthName, customers);

                    if (month == dateTimePicker.Value.Month)
                    {
                        textBoxCustomers.Text = customers.ToString();
                        textBoxProduct.Text = products.ToString();
                    }
                }
                reader.Close();
            }
        }
        private string GetMonthName(int month)
        {
            string[] monthNames =
            {
                        "", "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December"
            };

            if (month >= 1 && month <= 12)
            {
                return monthNames[month];
            }
            else
            {
                return "";
            }
        }
        //***************MONTH - FILL CHART DATA**************// //***************MONTH - FILL CHART DATA**************//

        //***************YEAR - FILL CHART DATA**************// //***************YEAR - FILL CHART DATA**************//
        private void FillChartRevenueByYear()
        {
            chartRevenue.Series["RevenueData"].Points.Clear();
            textBoxRevenue.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT YEAR(DateOfSales) AS SalesYear, SUM(RevenueDaily) AS TotalRevenue" +
                    " FROM Sales GROUP BY YEAR(DateOfSales)", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int year = (int)reader["SalesYear"];
                    double revenue = Convert.ToDouble(reader["TotalRevenue"]);

                    chartRevenue.Series["RevenueData"].Points.AddXY(year.ToString(), revenue);

                    if (year == dateTimePicker.Value.Year)
                    {
                        textBoxRevenue.Text = "₱" + revenue.ToString();
                    }
                }
                reader.Close();
            }
        }

        private void FillChartCustomersByYear()
        {
            chartCustomer.Series["CustData"].Points.Clear();
            textBoxCustomers.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT YEAR(DateOfSales) AS SalesYear, SUM(CustomersDaily) AS TotalCustomers, SUM(ProductsSoldDaily) AS TotalProducts" +
                    " FROM Sales GROUP BY YEAR(DateOfSales)", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int year = (int)reader["SalesYear"];
                    int customers = Convert.ToInt32(reader["TotalCustomers"]);
                    int products = Convert.ToInt32(reader["TotalProducts"]);

                    chartCustomer.Series["CustData"].Points.AddXY(year.ToString(), customers);

                    if (year == dateTimePicker.Value.Year)
                    {
                        textBoxCustomers.Text = customers.ToString();
                        textBoxProduct.Text = products.ToString();
                    }
                }
                reader.Close();
            }
        }

      



        //***************YEAR - FILL CHART DATA**************// //***************YEAR - FILL CHART DATA**************//


    }
}
