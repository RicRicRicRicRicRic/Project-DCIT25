using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class FormReceipt : Form
    {

        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";

        //***************RECEIPT DATA**************////***************RECEIPT DATA**************////***************RECEIPT DATA**************////***************RECEIPT DATA**************//

        public FormReceipt(double amountPaid, double changeAmount, string employeeID)
        {
            InitializeComponent();
            TotalQuantity();
            ReceiptDataGridView();

            textBoxAmount.Text = "₱ " + amountPaid.ToString();
            textBoxChange.Text = "₱ " + changeAmount.ToString();
            double revenue = amountPaid - changeAmount;
            textBoxRevenue.Text = revenue.ToString();
            textBoxCashier.Text = employeeID.ToString();
        }
        private void ReceiptDataGridView()
        {
            receiptdgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            receiptdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receiptdgv.ScrollBars = ScrollBars.Vertical;
            receiptdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            receiptdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }
        private void TotalQuantity()
        {
            int totalCount = 0;

            foreach (DataGridViewRow row in receiptdgv.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                totalCount += quantity;
            }
            textBoxTotalItems.Text = totalCount.ToString();
        }
        public void AddToReceipt(string product, double price, int quantity)
        {
            int rowIndex = receiptdgv.Rows.Add();
            receiptdgv.Rows[rowIndex].Cells["ProductColumn"].Value = product;
            receiptdgv.Rows[rowIndex].Cells["PriceColumn"].Value = price;
            receiptdgv.Rows[rowIndex].Cells["QuantityColumn"].Value = quantity;

            TotalQuantity();
        }

        //***************RECEIPT DATA**************////***************RECEIPT DATA**************// //***************RECEIPT DATA**************////***************RECEIPT DATA**************//

        //***************SAVE DATA TO ORDER TABLE***************////***************SAVE DATA TO ORDER TABLE***************// //***************SAVE DATA TO ORDER TABLE***************////***************SAVE DATA TO ORDER TABLE***************//

        private void SaveToOrderTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
                    InsertNewOrder(connection, selectedDate);
                    MessageBox.Show("Data saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertNewOrder(SqlConnection connection, string selectedDate)
        {
            string orderId = GenerateOrderID(connection);
            string employeeID = textBoxCashier.Text;
            string query = "INSERT INTO Orders (OrderID, OrderRevenue, OrderCustomer, OrderProductsSold, OrderDate,EmployeeID) " +
                "VALUES (@OrderID, @Revenue, @Customer, @Products, @SelectedDate,@Cashier)";
            SqlCommand cmmd = new SqlCommand(query, connection);
            cmmd.Parameters.AddWithValue("@OrderID", orderId);
            cmmd.Parameters.AddWithValue("@Revenue", double.Parse(textBoxRevenue.Text));
            cmmd.Parameters.AddWithValue("@Customer", textBoxCustNum.Text);
            cmmd.Parameters.AddWithValue("@Products", int.Parse(textBoxTotalItems.Text));
            cmmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
            cmmd.Parameters.AddWithValue("@Cashier", employeeID);
            cmmd.ExecuteNonQuery();
        }
        private string GenerateOrderID(SqlConnection connection)
        {
            try
            {
                SqlCommand getMaxId = new SqlCommand("SELECT MAX(CAST(SUBSTRING(OrderID, 7, LEN(OrderID) - 6) AS INT)) FROM Orders", connection);
                object maxIdResult = getMaxId.ExecuteScalar();
                int maxId;
                if (maxIdResult == DBNull.Value)
                {
                    maxId = 0;
                }
                else
                {
                    maxId = Convert.ToInt32(maxIdResult);
                }
                int nextId = maxId + 1;
                string orderId = "Order_" + nextId.ToString();
                return orderId;
            }
            finally
            {
            }
        }

        //***************SAVE DATA TO ORDER TABLE***************////***************SAVE DATA TO ORDER TABLE***************////***************SAVE DATA TO ORDER TABLE***************////***************SAVE DATA TO ORDER TABLE***************//

        //***************UPDATE OR INSERT DATA TO SALES TABLE**************////***************UPDATE OR INSERT DATA TO SALES TABLE**************//  //***************UPDATE OR INSERT DATA TO SALES TABLE**************////***************UPDATE OR INSERT DATA TO SALES TABLE**************//

        private void UpdateSalesData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectedDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
                bool dateChecker = SalesRowChecker(connection, selectedDate);
                string salesId = GenerateSalesID(connection);

                if (dateChecker)
                {
                    UpdateSales(connection, selectedDate);
                }
                else
                {
                    InsertNewSales(connection, selectedDate, salesId);
                }
            }
        }

        private bool SalesRowChecker(SqlConnection connection, string selectedDate)
        {
            string query = "SELECT COUNT(*) FROM Sales WHERE DateOfSales = @SelectedDate";
            using (SqlCommand cmd = new SqlCommand(query,connection))
            {
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void UpdateSales(SqlConnection connection, string selectedDate) 
        {
            string query = @"UPDATE Sales 
                     SET RevenueDaily = (SELECT SUM(OrderRevenue) FROM Orders WHERE OrderDate = @SelectedDate),
                         CustomersDaily = (SELECT SUM(OrderCustomer) FROM Orders WHERE OrderDate = @SelectedDate),
                         ProductsSoldDaily = (SELECT SUM(OrderProductsSold) FROM Orders WHERE OrderDate = @SelectedDate)
                     WHERE DateOfSales = @SelectedDate";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
            cmd.ExecuteNonQuery();
        }
        private void InsertNewSales(SqlConnection connection, string selectedDate, string salesID)
        {
            string query = @"INSERT INTO Sales (SalesID, RevenueDaily, CustomersDaily, ProductsSoldDaily, DateOfSales) 
                     VALUES (@SalesID, 
                             (SELECT SUM(OrderRevenue) FROM Orders WHERE OrderDate = @SelectedDate),
                             (SELECT SUM(OrderCustomer) FROM Orders WHERE OrderDate = @SelectedDate),
                             (SELECT SUM(OrderProductsSold) FROM Orders WHERE OrderDate = @SelectedDate),
                             @SelectedDate)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@SalesID", salesID);
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
            cmd.ExecuteNonQuery();
        }
        private string GenerateSalesID(SqlConnection connection)
        {
            try
            {
                SqlCommand getMaxId = new SqlCommand("SELECT MAX(CAST(SUBSTRING(SalesID, 7, LEN(SalesID) - 6) AS INT)) FROM Sales", connection);
                object maxIdResult = getMaxId.ExecuteScalar();
                int maxId;
                if (maxIdResult == DBNull.Value)
                {
                    maxId = 0;
                }
                else
                {
                    maxId = Convert.ToInt32(maxIdResult);
                }
                int nextId = maxId + 1;
                string salesId = "Sales_" + nextId.ToString();
                return salesId;
               
            }
            finally
            {
            }
        }

        //***************UPDATE OR INSERT DATA TO SALES TABLE**************////***************UPDATE OR INSERT DATA TO SALES TABLE**************//   //***************UPDATE OR INSERT DATA TO SALES TABLE**************////***************UPDATE OR INSERT DATA TO SALES TABLE**************//
        
        //***************BUTTON BEHAVIROS**************////***************BUTTON BEHAVIROS**************////***************BUTTON BEHAVIROS**************////***************BUTTON BEHAVIROS**************//

        int CustomerNumber;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CustomerNumber ++;
            textBoxCustNum.Text = CustomerNumber.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CustomerNumber > 0)
            {
                CustomerNumber --;
                textBoxCustNum.Text = CustomerNumber.ToString();
            }
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            FoodInventoryStock();
            ColdCoffeeInventoryStock();
            HotCoffeeInventoryStock();

            if (CustomerNumber <= 0)
            {
                MessageBox.Show("Customer nummber cannot be 0.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CustomerNumber != 0)
            {
                DialogResult yesORno = MessageBox.Show("Are you sure to save to databse? Please Check first if data is correct", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesORno == DialogResult.Yes)
                {
                    SaveToOrderTable();
                    UpdateSalesData();
                }
            }
        }
        private void PrintSavebutton_Click(object sender, EventArgs e)
        {
            FoodInventoryStock();
            ColdCoffeeInventoryStock();
            HotCoffeeInventoryStock();

            if (CustomerNumber <= 0)
            {
                MessageBox.Show("Customer nummber cannot be 0.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CustomerNumber != 0)
            {
                DialogResult yesORno = MessageBox.Show("Are you sure to save to databse? Please Check first if data is correct", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesORno == DialogResult.Yes)
                {
                    SaveToOrderTable();
                    UpdateSalesData();
                }
            }
        }
        //***************BUTTON BEHAVIROS**************// //***************BUTTON BEHAVIROS**************// //***************BUTTON BEHAVIROS**************////***************BUTTON BEHAVIROS**************//

        private void receiptdgv_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBoxRevenue_TextChanged(object sender, EventArgs e) { }
        private void textBoxAmount_TextChanged(object sender, EventArgs e) { }
        private void textBoxChange_TextChanged(object sender, EventArgs e) { }
        private void textBoxTotalItems_TextChanged(object sender, EventArgs e) { }
        private void textBoxCustNum_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e) { }

        //***************UPDATE INVENTORY STOCK**************// //***************UPDATE INVENTORY STOCK**************//
        private void FoodInventoryStock() 
        {
            foreach (DataGridViewRow row in receiptdgv.Rows)
            {
                string product = row.Cells["ProductColumn"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                UpdateFoodStock(product, quantity);
            }
        }
        private void ColdCoffeeInventoryStock() 
        {
            foreach (DataGridViewRow row in receiptdgv.Rows)
            {
                string product = row.Cells["ProductColumn"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                UpdateColdCoffeeStock(product, quantity);
                
            }
        }
        private void HotCoffeeInventoryStock() 
        {
            foreach (DataGridViewRow row in receiptdgv.Rows)
            {
                string product = row.Cells["ProductColumn"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                UpdateHotCoffeeStock(product, quantity);
            }
        }
        private void UpdateFoodStock(string foodName, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE FoodInventory SET FoodStock = FoodStock - @Quantity WHERE FoodName = @FoodName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@FoodName", foodName);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateHotCoffeeStock(string coffeeName, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE HotCoffeeInventory SET HotCoffeeStock = HotCoffeeStock - @Quantity WHERE HotCoffeeName = @CoffeeName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@CoffeeName", coffeeName);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateColdCoffeeStock(string coffeeName, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE ColdCoffeeInventory SET ColdCoffeeStock = ColdCoffeeStock - @Quantity WHERE ColdCoffeeName = @CoffeeName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@CoffeeName", coffeeName);
                command.ExecuteNonQuery();
            }
        }
        //***************UPDATE INVENTORY STOCK**************// //***************UPDATE INVENTORY STOCK**************//

    }
}