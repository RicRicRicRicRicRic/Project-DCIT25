using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class MenuHotCoffeeForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public EmployeeCoffeeShop _CoffeeShopManagementSystem;
        public MenuHotCoffeeForm(EmployeeCoffeeShop coffeeShopManagementSystem)
        {
            InitializeComponent();
            _CoffeeShopManagementSystem = coffeeShopManagementSystem;
        }
        private void FormHotCoffee_Load(object sender, EventArgs e)
        {
            LoadingStart();
            HotTimer = new Timer();
            HotTimer.Tick += HotTimer_Tick;
            HotTimer.Start();
        }
        //***************PANEL DESING***************// //***************PANEL DESING***************// //***************PANEL DESING***************//
        private void DesktopPanel_Paint_1(object sender, PaintEventArgs e)
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
        private void LoadingPanel_Paint_1(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        //***************PANEL DESING***************// //***************PANEL DESING***************// //***************PANEL DESING***************//

        private void Description_Click(object sender, EventArgs e) { }
        private void Price_Click(object sender, EventArgs e) { }

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
            else if(productFound == true)
            {
                int currentQuantity = Convert.ToInt32(_CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["QuantityColumn"].Value);
                double currentPrice = Convert.ToDouble(_CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["PriceColumn"].Value);

                _CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["QuantityColumn"].Value = currentQuantity + Quantity;
                _CoffeeShopManagementSystem.ReceiptDataGridView.Rows[receiptrow].Cells["PriceColumn"].Value = currentPrice + Prices;
            }
            
        }

        private void buttonEspresso_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A strong, concentrated coffee brewed by forcing hot water through finely-ground coffee beans. It's the base for many other"
        + Environment.NewLine +
        ".coffee drinks";
            Description.Text = generatedText;

            string generatedPrice = "₱80";
            Price.Text = generatedPrice;

            double Prices = 80;
            int Quantity = 1;
            string product = "Espresso";

            UpdateReceipt(product, Prices, Quantity);
        }
        private void buttonDecaf_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Short for decaffeinated coffee, it's coffee from coffee beans that have had at least 97% of their caffeine removed. It offers a"
                + Environment.NewLine +
                ".similar taste to regular coffee but with much less caffeine";
            Description.Text = generatedText;

            string generatedPrice = "₱90";
            Price.Text = generatedPrice;

            double Prices = 90;
            int Quantity = 1;
            string product = "Decaf";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonLatte_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".Made with espresso and steamed milk, topped with a small amount of milk foam. It has a creamy texture and a mild coffee "
                + Environment.NewLine +
                ".flavor";
            Description.Text = generatedText;

            string generatedPrice = "₱120";
            Price.Text = generatedPrice;

            double Prices = 120;
            int Quantity = 1;
            string product = "Latte";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonCappuccino_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Similar to a latte but with a higher ratio of foam to milk. It consists of equal parts espresso,steamed milk,and milk foam giving"
               + Environment.NewLine +
               ".it a frothy texture";
            Description.Text = generatedText;

            string generatedPrice = "₱110";
            Price.Text = generatedPrice;

            double Prices = 110;
            int Quantity = 1;
            string product = "Cappuccino";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonMacchiato_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "An espresso \"stained\" with a small amount of steamed milk or milk foam. It has a strong coffee flavor with a hint of "
               + Environment.NewLine +
               ".creaminess";
            Description.Text = generatedText;

            string generatedPrice = "₱100";
            Price.Text = generatedPrice;

            double Prices = 100;
            int Quantity = 1;
            string product = "Macchiato";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonFlatWhite_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Originating from Australia and New Zealand, it's similar to a latte but with a higher coffee-to-milk ratio and a velvety"
               + Environment.NewLine +
               ".microfoam texture";
            Description.Text = generatedText;
            string generatedPrice = "₱130";
            Price.Text = generatedPrice;

            double Prices = 130;
            int Quantity = 1;
            string product = "Flat White";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonAmericano_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "Made by diluting a shot of espresso with hot water, giving it a similar strength to drip coffee but with a different"
               + Environment.NewLine +
               ".flavor profile";
            Description.Text = generatedText;
            string generatedPrice = "₱140";

            Price.Text = generatedPrice;
            double Prices = 140;
            int Quantity = 1;
            string product = "Americano";

            UpdateReceipt(product, Prices, Quantity);
        }

        private void buttonMochaLatte_Click(object sender, EventArgs e)
        {
            ClearMoney(sender, e);
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A combination of espresso, steamed milk, and chocolate syrup, topped with whipped cream. It has a rich, chocolatey"
               + Environment.NewLine +
               ".flavor along with the boldness of espresso";
            Description.Text = generatedText;


            string generatedPrice = "₱85";
            Price.Text = generatedPrice;

            double Prices = 85;
            int Quantity = 1;
            string product = "Mocha Latte";

            UpdateReceipt(product, Prices, Quantity);
        }
        //***************MENU BUTTONS***************// //***************MENU BUTTONS***************// //***************MENU BUTTONS***************//

        //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************//
        private void UnavailableInventoryWarning()
        {
            string[] hotCoffeeNames = {"Espresso", "Decaf", "Latte", "Cappuccino",
        "Macchiato", "Flat White", "Americano", "Mocha Latte"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string hotCoffeeName in hotCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT HotCoffeeStatus FROM HotCoffeeInventory WHERE HotCoffeeName = @HotCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@HotCoffeeName", hotCoffeeName);

                    string hotCoffeeStatus = (string)cmd.ExecuteScalar();
                    if (hotCoffeeStatus == "Unavailable")
                    {
                        switch (hotCoffeeName)
                        {
                            case "Espresso":
                                EoutLabel.Visible = true;
                                ERunPanel.Visible = false;
                                buttonEspresso.Enabled = false;
                                buttonEspresso.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Decaf":
                                DoutLabel.Visible = true;
                                DRunPanel.Visible = false;
                                buttonDecaf.Enabled = false;
                                buttonDecaf.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Latte":
                                LoutLabel.Visible = true;
                                LRunPanel.Visible = false;
                                buttonLatte.Enabled = false;
                                buttonLatte.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Cappuccino":
                                CoutLabel.Visible = true;
                                CRunPanel.Visible = false;
                                buttonCappuccino.Enabled = false;
                                buttonCappuccino.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Macchiato":
                                MoutLabel.Visible = true;
                                MRunPanel.Visible = false;
                                buttonMacchiato.Enabled = false;
                                buttonMacchiato.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Flat White":
                                FWoutLabel.Visible = true;
                                FWRunPanel.Visible = false;
                                buttonFlatWhite.Enabled = false;
                                buttonFlatWhite.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Americano":
                                AoutLabel.Visible = true;
                                ARunPanel.Visible = false;
                                buttonAmericano.Enabled = false;
                                buttonAmericano.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Mocha Latte":
                                MLoutLabel.Visible = true;
                                MLRunPanel.Visible = false;
                                buttonMochaLatte.Enabled = false;
                                buttonMochaLatte.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                        }
                    }
                }
            }
        }

        private void RunningOutInventoryWarning()
        {
            string[] hotCoffeeNames = {"Espresso", "Decaf", "Latte", "Cappuccino",
        "Macchiato", "Flat White", "Americano", "Mocha Latte"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string hotCoffeeName in hotCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT HotCoffeeStatus, HotCoffeeStock FROM HotCoffeeInventory WHERE HotCoffeeName = @HotCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@HotCoffeeName", hotCoffeeName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string hotCoffeeStatus = reader["HotCoffeeStatus"].ToString();
                            int hotCoffeeStock = Convert.ToInt32(reader["HotCoffeeStock"]);

                            if (hotCoffeeStatus == "Running Out")
                            {
                                switch (hotCoffeeName)
                                {
                                    case "Espresso":
                                        ERunPanel.Visible = true;
                                        ERunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Decaf":
                                        DRunPanel.Visible = true;
                                        DRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Latte":
                                        LRunPanel.Visible = true;
                                        LRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Cappuccino":
                                        CRunPanel.Visible = true;
                                        CRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Macchiato":
                                        MRunPanel.Visible = true;
                                        MRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Flat White":
                                        FWRunPanel.Visible = true;
                                        FWRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Americano":
                                        ARunPanel.Visible = true;
                                        ARunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
                                        break;
                                    case "Mocha Latte":
                                        MLRunPanel.Visible = true;
                                        MLRunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + hotCoffeeStock;
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
            string[] hotCoffeeNames = {"Espresso", "Decaf", "Latte", "Cappuccino",
        "Macchiato", "Flat White", "Americano", "Mocha Latte"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string hotCoffeeName in hotCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT HotCoffeeStatus FROM HotCoffeeInventory WHERE HotCoffeeName = @HotCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@HotCoffeeName", hotCoffeeName);

                    string hotCoffeeStatus = (string)cmd.ExecuteScalar();
                    if (hotCoffeeStatus == "Available")
                    {
                        switch (hotCoffeeName)
                        {
                            case "Espresso":
                                EoutLabel.Visible = false;
                                ERunPanel.Visible = false;
                                buttonEspresso.Enabled = true;
                                buttonEspresso.BackColor = Color.LightSalmon;
                                break;
                            case "Decaf":
                                DoutLabel.Visible = false;
                                DRunPanel.Visible = false;
                                buttonDecaf.Enabled = true;
                                buttonDecaf.BackColor = Color.LightSalmon;
                                break;
                            case "Latte":
                                LoutLabel.Visible = false;
                                LRunPanel.Visible = false;
                                buttonLatte.Enabled = true;
                                buttonLatte.BackColor = Color.LightSalmon;
                                break;
                            case "Cappuccino":
                                CoutLabel.Visible = false;
                                CRunPanel.Visible = false;
                                buttonCappuccino.Enabled = true;
                                buttonCappuccino.BackColor = Color.LightSalmon;
                                break;
                            case "Macchiato":
                                MoutLabel.Visible = false;
                                MRunPanel.Visible = false;
                                buttonMacchiato.Enabled = true;
                                buttonMacchiato.BackColor = Color.LightSalmon;
                                break;
                            case "Flat White":
                                FWoutLabel.Visible = false;
                                FWRunPanel.Visible = false;
                                buttonFlatWhite.Enabled = true;
                                buttonFlatWhite.BackColor = Color.LightSalmon;
                                break;
                            case "Americano":
                                AoutLabel.Visible = false;
                                ARunPanel.Visible = false;
                                buttonAmericano.Enabled = true;
                                buttonAmericano.BackColor = Color.LightSalmon;
                                break;
                            case "Mocha Latte":
                                MLoutLabel.Visible = false;
                                MLRunPanel.Visible = false;
                                buttonMochaLatte.Enabled = true;
                                buttonMochaLatte.BackColor = Color.LightSalmon;
                                break;
                        }
                    }
                }
            }
        }


        private void HotTimer_Tick(object sender, EventArgs e)
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
