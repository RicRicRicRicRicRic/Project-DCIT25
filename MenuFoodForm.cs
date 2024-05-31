using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class MenuFoodForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public EmployeeCoffeeShop _CoffeeShopManagementSystem;
        public MenuFoodForm(EmployeeCoffeeShop coffeeShopManagementSystem)
        {
            InitializeComponent();
            _CoffeeShopManagementSystem = coffeeShopManagementSystem;
        }
        private void MenuFoodForm_Load(object sender, EventArgs e)
        {
            LoadingStart();
            FoodTimer = new Timer();
            FoodTimer.Tick += FoodTimer_Tick;
            FoodTimer.Start();
        }

        //***************PANEL DESING***************// //***************PANEL DESING***************// //***************PANEL DESING***************//

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void LoadingPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        //***************PANEL DESING***************// //***************PANEL DESING***************// //***************PANEL DESING***************//

        //***************MENU BUTTONS***************// //***************MENU BUTTONS***************// //***************MENU BUTTONS***************//

        private void ClearMoney(object senderm, EventArgs e)
        {
            _CoffeeShopManagementSystem.SenderPrice.Clear();
            _CoffeeShopManagementSystem.SenderQuantity.Clear();
            _CoffeeShopManagementSystem.SenderChange.Clear();
        }
        private void UpdateReceipt(string product, double Prices, int Quantity)
        {
            bool productFound = false;
            int receiptrow = 0;

            foreach (DataGridViewRow row in _CoffeeShopManagementSystem.ReceiptDataGridView.Rows)
            {
                if (row.Cells["ProductColumn"].Value.ToString() == product)
                {
                    productFound = true;
                    receiptrow = row.Index;
                    break;
                }
            }

            if (productFound == false)
            {
                _CoffeeShopManagementSystem.ReceiptDataGridView.Rows.Add(product, Prices, Quantity);
            }
            else if (productFound == true)
            {
                int currentQuantity = Convert.ToInt32(_CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["QuantityColumn"].Value);
                double currentPrice = Convert.ToDouble(_CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["PriceColumn"].Value);

                _CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["QuantityColumn"].Value = currentQuantity + Quantity;
                _CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["PriceColumn"].Value = currentPrice + Prices;
            }

        }
        private void buttonCroissant_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".A classic French pastry made with buttery, flaky layers, perfect for a light and indulgent breakfast or snack";
            Description.Text = generatedText;

            string generatedPrice = "₱60";
            Price.Text = generatedPrice;

            double Prices = 60;
            int Quantity = 1;
            string product = "Croissant";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender,e);
        }

        private void buttonBlueBerryMuffin_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".A moist and fluffy muffin filled with juicy blueberries, offering a burst of sweetness in every bite";
            Description.Text = generatedText;

            string generatedPrice = "₱70";
            Price.Text = generatedPrice;

            double Prices = 70;
            int Quantity = 1;
            string product = "Blueberry Muffin";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonBagelCreamCheese_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A chewy and flavorful bagel served toasted and topped with smooth cream cheese, a satisfying and savory option for a"
                + Environment.NewLine +
                ".breakfast or brunch";
            Description.Text = generatedText;

            string generatedPrice = "₱80";
            Price.Text = generatedPrice;

            double Prices = 80;
            int Quantity = 1;
            string product = "Bagel with Cream Cheese";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonAvocadoToast_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Slices of hearty whole-grain toast topped with creamy mashed avocado, sprinkled with a pinch of sea salt and a dash of lemon"
                + Environment.NewLine +
                ".juice, offering a nutritious and satisfying option for a light meal or snack";
            Description.Text = generatedText;

            string generatedPrice = "₱60";
            Price.Text = generatedPrice;

            double Prices = 60;
            int Quantity = 1;
            string product = "Avocado Toast";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonQuicheLorraine_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ",A savory pie filled with a rich and creamy custard, bacon pieces, and Swiss cheese, baked to perfection in a buttery pastry crust"
               + Environment.NewLine +
               ".ideal for a savory breakfast or brunch";
            Description.Text = generatedText;

            string generatedPrice = "₱100";
            Price.Text = generatedPrice;

            double Prices = 100; 
            int Quantity = 1;
            string product = "Quiche Lorraine";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonChickenCaesarSalad_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Crisp romaine lettuce tossed with grilled chicken breast, Parmesan cheese, crunchy croutons, and tangy Caesar dressing, creating a" 
                + Environment.NewLine +
                ".refreshing and satisfying salad option";
            Description.Text = generatedText;

            string generatedPrice = "₱160";
            Price.Text = generatedPrice;

            double Prices = 160;
            int Quantity = 1;
            string product = "Chicken Caesar Salad";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonGrilledCheeseSandwich_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".Two slices of golden toasted bread filled with melted cheese, creating a gooey and comforting sandwich that pairs perfectly " 
                + Environment.NewLine +
                "with a cup of coffee";
            Description.Text = generatedText;

            string generatedPrice = "₱95";
            Price.Text = generatedPrice;

            double Prices = 95;
            int Quantity = 1;
            string product = "Grilled Cheese Sandwich";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonChocolateChipCookies_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".Soft and chewy cookies studded with chunks of rich chocolate, offering a delightful treat for any time of day";
            Description.Text = generatedText;

            string generatedPrice = "₱55";
            Price.Text = generatedPrice;

            double Prices = 55;
            int Quantity = 1;
            string product = "Chocolate Chip Cookies";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }


        //***************MENU BUTTONS***************// //***************MENU BUTTONS***************// //***************MENU BUTTONS***************//

        //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************//
        private void UnavailableInventoryWarning()
        {
            string[] foodNames = {"Croissant", "Blueberry Muffin", "Bagel with Cream Cheese", "Avocado Toast",
        "Quiche Lorraine", "Chicken Caesar Salad", "Grilled Cheese Sandwich", "Chocolate Chip Cookies"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string foodName in foodNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT FoodStatus FROM FoodInventory WHERE FoodName = @FoodName", connection);
                    cmd.Parameters.AddWithValue("@FoodName", foodName);

                    string foodStatus = (string)cmd.ExecuteScalar();
                    if (foodStatus == "Unavailable")
                    {
                        switch (foodName)
                        {
                            case "Croissant":
                                CoutLabel.Visible = true;
                                CrunPanel.Visible = false;
                                buttonCroissant.Enabled = false;
                                buttonCroissant.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Blueberry Muffin":
                                BMoutLabel.Visible = true;
                                BMCrunPanel.Visible = false;
                                buttonBlueBerryMuffin.Enabled = false;
                                buttonBlueBerryMuffin.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Bagel with Cream Cheese":
                                BWCCoutLabel.Visible = true;
                                BWCCrunPanel.Visible = false;
                                buttonBagelCreamCheese.Enabled = false;
                                buttonBagelCreamCheese.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Avocado Toast":
                                AToutLabel.Visible = true;
                                ATrunPanel.Visible = false;
                                buttonAvocadoToast.Enabled = false;
                                buttonAvocadoToast.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Quiche Lorraine":
                                QLoutLabel.Visible = true;
                                QLrunPanel.Visible = false;
                                buttonQuicheLorraine.Enabled = false;
                                buttonQuicheLorraine.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Chicken Caesar Salad":
                                CCSoutLabel.Visible = true;
                                CCSrunPanel.Visible = false;
                                buttonChickenCaesarSalad.Enabled = false;
                                buttonChickenCaesarSalad.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Grilled Cheese Sandwich":
                                GCSoutLabel.Visible = true;
                                GCSrunPanel.Visible = false;
                                buttonGrilledCheeseSandwich.Enabled = false;
                                buttonGrilledCheeseSandwich.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Chocolate Chip Cookies":
                                CCCoutLabel.Visible = true;
                                CCCrunPanel.Visible = false;
                                buttonChocolateChipCookies.Enabled = false;
                                buttonChocolateChipCookies.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                        }
                    }
                }
            }
        }
        private void RunningOutInventoryWarning()
        {
            string[] foodNames = {"Croissant", "Blueberry Muffin", "Bagel with Cream Cheese", "Avocado Toast",
        "Quiche Lorraine", "Chicken Caesar Salad", "Grilled Cheese Sandwich", "Chocolate Chip Cookies"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string foodName in foodNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT FoodStatus, FoodStock FROM FoodInventory WHERE FoodName = @FoodName", connection);
                    cmd.Parameters.AddWithValue("@FoodName", foodName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string foodStatus = reader["FoodStatus"].ToString();
                            int foodStock = Convert.ToInt32(reader["FoodStock"]);

                            if (foodStatus == "Running Out")
                            {
                                switch (foodName)
                                {
                                    case "Croissant":
                                        CrunPanel.Visible = true;
                                        CrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Blueberry Muffin":
                                        BMCrunPanel.Visible = true;
                                        BMCrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Bagel with Cream Cheese":
                                        BWCCrunPanel.Visible = true;
                                        BWCCrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Avocado Toast":
                                       ATrunPanel.Visible = true;
                                       ATrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Quiche Lorraine":
                                        QLrunPanel.Visible = true;
                                        QLoutLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Chicken Caesar Salad":
                                        CCSrunPanel.Visible = true;
                                        CCSrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Grilled Cheese Sandwich":
                                        GCSrunPanel.Visible = true;
                                        GCSrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                    case "Chocolate Chip Cookies":
                                        CCCrunPanel.Visible = true;
                                        CCCrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + foodStock;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void AvailableInventory()
        {
            string[] foodNames = {"Croissant", "Blueberry Muffin", "Bagel with Cream Cheese", "Avocado Toast",
        "Quiche Lorraine", "Chicken Caesar Salad", "Grilled Cheese Sandwich", "Chocolate Chip Cookies"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string foodName in foodNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT FoodStatus FROM FoodInventory WHERE FoodName = @FoodName", connection);
                    cmd.Parameters.AddWithValue("@FoodName", foodName);

                    string foodStatus = (string)cmd.ExecuteScalar();
                    if (foodStatus == "Available")
                    {
                        switch (foodName)
                        {
                            case "Croissant":
                                CoutLabel.Visible = false;
                                CrunPanel.Visible = false;
                                buttonCroissant.Enabled = true;
                                buttonCroissant.BackColor = Color.LightSalmon;
                                break;
                            case "Blueberry Muffin":
                                BMoutLabel.Visible = false;
                                BMCrunPanel.Visible = false;
                                buttonBlueBerryMuffin.Enabled = true;
                                buttonBlueBerryMuffin.BackColor = Color.LightSalmon;
                                break;
                            case "Bagel with Cream Cheese":
                                BWCCoutLabel.Visible = false;
                                BWCCrunPanel.Visible = false;
                                buttonBagelCreamCheese.Enabled = true;
                                buttonBagelCreamCheese.BackColor = Color.LightSalmon;
                                break;
                            case "Avocado Toast":
                                AToutLabel.Visible = false;
                                ATrunPanel.Visible = false;
                                buttonAvocadoToast.Enabled = true;
                                buttonAvocadoToast.BackColor = Color.LightSalmon;
                                break;
                            case "Quiche Lorraine":
                                QLoutLabel.Visible = false;
                                QLrunPanel.Visible = false;
                                buttonQuicheLorraine.Enabled = true;
                                buttonQuicheLorraine.BackColor = Color.LightSalmon;
                                break;
                            case "Chicken Caesar Salad":
                                CCSoutLabel.Visible = false;
                                CCSrunPanel.Visible = false;
                                buttonChickenCaesarSalad.Enabled = true;
                                buttonChickenCaesarSalad.BackColor = Color.LightSalmon;
                                break;
                            case "Grilled Cheese Sandwich":
                                GCSoutLabel.Visible = false;
                                GCSrunPanel.Visible = false;
                                buttonGrilledCheeseSandwich.Enabled = true;
                                buttonGrilledCheeseSandwich.BackColor = Color.LightSalmon;
                                break;
                            case "Chocolate Chip Cookies":
                                CCCoutLabel.Visible = false;
                                CCCrunPanel.Visible = false;
                                buttonChocolateChipCookies.Enabled = true;
                                buttonChocolateChipCookies.BackColor = Color.LightSalmon;
                                break;
                        }
                    }
                }
            }
        }

        private void FoodTimer_Tick(object sender, EventArgs e)
        {
            AvailableInventory();
            UnavailableInventoryWarning();
            RunningOutInventoryWarning();
        }


        //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************//

        //***************LOADING SCREEN***************// //***************LOADING SCREEN***************// //***************LOADING SCREEN***************// 
        private void LoadingStart()
        {
            LoadPanel.Width = 10;
            increment = GetRandomIncrement();
            LoadingTimer.Start();
            LoadingPanel.Visible = true;
            DesktopPanel.SendToBack();

        }
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadPanel.Width += increment;
            if (LoadPanel.Width >= 474)
            {
                LoadingTimer.Stop();
                LoadingPanel.Visible = false;
                DesktopPanel.BringToFront();
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

        //***************LOADING SCREEN***************// //***************LOADING SCREEN***************// //***************LOADING SCREEN***************// 

    }
}
