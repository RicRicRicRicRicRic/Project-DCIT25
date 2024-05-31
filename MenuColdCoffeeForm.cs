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

namespace CoffeeShop
{
    public partial class MenuColdCoffeeForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public EmployeeCoffeeShop _CoffeeShopManagementSystem;
        public MenuColdCoffeeForm(EmployeeCoffeeShop coffeeShopManagementSystem)
        {
            InitializeComponent();
            _CoffeeShopManagementSystem = coffeeShopManagementSystem;
        }
        private void MenuColdCoffeeForm_Load(object sender, EventArgs e)
        {
            LoadingStart();
            ColdCoffeeTimer = new Timer();
            ColdCoffeeTimer.Tick += ColdCoffeeTimer_Tick;
            ColdCoffeeTimer.Start();
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
        private void panel21_Paint_1(object sender, PaintEventArgs e)
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
                if ( row.Cells["ProductColumn"].Value.ToString() == product)
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
        private void buttonIcedCoffee_Click(object sender, EventArgs e)
        {
            if (ICoutLabel.Visible == false)
            {
                _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
                string generatedText = ".A chilled coffee beverage served over ice, perfect for a refreshing pick-me-up on a hot day";
                Description.Text = generatedText;

                string generatedPrice = "₱90";
                Price.Text = generatedPrice;

                int Prices = 90;
                int Quantity = 1;
                string product = "Iced Coffee";

                UpdateReceipt(product, Prices, Quantity);
                ClearMoney(sender, e);
            }
           

        }

        private void buttonColdBrew_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".A rich and smooth coffee brewed with cold water over an extended period, resulting in a bold flavor with low acidity";
            Description.Text = generatedText;

            string generatedPrice = "₱110";
            Price.Text = generatedPrice;

            int Prices = 110;
            int Quantity = 1;
            string product = "Cold Brew";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonIcedLatte_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".A creamy and indulgent coffee drink made with espresso and chilled milk, served over ice for a satisfying refreshment";
            Description.Text = generatedText;

            string generatedPrice = "₱120";
            Price.Text = generatedPrice;

            int Prices = 120;
            int Quantity = 1;
            string product = "Iced Latte";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonFrappe_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A blended coffee beverage combining espresso, milk, ice, and various flavorings, topped with whipped cream, offering a" 
                +Environment.NewLine + 
                ".delightful treat for coffee lovers";
            Description.Text = generatedText;

            string generatedPrice = "₱150";
            Price.Text = generatedPrice;

            int Prices = 150;
            int Quantity = 1;
            string product = "Frappe";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonIcedMocha_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A decadent blend of espresso, chocolate syrup, chilled milk, and ice, creating a delightful fusion of coffee and chocolate "
                + Environment.NewLine +
                ".flavors, perfect for a sweet indulgence";
            Description.Text = generatedText;

            string generatedPrice = "₱85";
            Price.Text = generatedPrice;

            int Prices = 85;
            int Quantity = 1;
            string product = "Iced Mocha";
            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

 
        private void buttonNitroColdBrew_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A velvety smooth and creamy cold brew coffee infused with nitrogen gas, resulting in a cascading effect and a unique "
                + Environment.NewLine +
                ".texture, providing a luxurious coffee experience";
            Description.Text = generatedText;

            string generatedPrice = "₱155";
            Price.Text = generatedPrice;

            int Prices = 155;
            int Quantity = 1;
            string product = "Nitro Cold Brew";
            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }

        private void buttonCoffeeMilkShake_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = ".A creamy and indulgent beverage made with freshly brewed coffee, chilled milk, and velvety ice cream, blended to perfection"
                + Environment.NewLine +
                ".for a rich and refreshing treat";
            Description.Text = generatedText;

            string generatedPrice = "₱115";
            Price.Text = generatedPrice;

            int Prices = 115;
            int Quantity = 1;
            string product = "Coffee Milk Shake";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }
        private void buttonAffogato_Click(object sender, EventArgs e)
        {
            _CoffeeShopManagementSystem.ReceiptDataGridView.ClearSelection();
            string generatedText = "A delightful dessert or beverage featuring a scoop of vanilla ice cream \"drowned\" in a shot of hot espresso, creating a harmonious"
                + Environment.NewLine +
                ".blend of hot and cold, bitter and sweet flavors";
            Description.Text = generatedText;

            string generatedPrice = "₱140";
            Price.Text = generatedPrice;

            int Prices = 140;
            int Quantity = 1;
            string product = "Affogato";

            UpdateReceipt(product, Prices, Quantity);
            ClearMoney(sender, e);
        }
        //***************MENU BUTTONS***************// //***************MENU BUTTONS***************// //***************MENU BUTTONS***************//

        //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************// //***************LOW STORAGE WARNING***************//
        private void UnavailableInventoryWarning()
        {
            string[] coldCoffeeNames = {"Iced Coffee", "Cold Brew", "Iced Latte", "Frappe",
                                "Iced Mocha", "Nitro Cold Brew", "Coffee Milk Shake", "Affogato"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string coldName in coldCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT ColdCoffeeStatus FROM ColdCoffeeInventory WHERE ColdCoffeeName = @ColdCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@ColdCoffeeName", coldName);

                    string coldCoffeeStatus = (string)cmd.ExecuteScalar();
                    if (coldCoffeeStatus == "Unavailable")
                    {
                        switch (coldName)
                        {
                            case "Iced Coffee":
                                ICoutLabel.Visible = true;
                                IrunPanel.Visible = false;
                                buttonIcedCoffee.Enabled = false;
                                buttonIcedCoffee.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Cold Brew":
                                CBoutLabel.Visible = true;
                                CBrunPanel.Visible = false;
                                buttonColdBrew.Enabled = false;
                                buttonColdBrew.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Iced Latte":
                                ILoutLabel.Visible = true;
                                ILrunPanel.Visible = false;
                                buttonIcedLatte.Enabled = false;
                                buttonIcedLatte.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Frappe":
                                FoutLabel.Visible = true;
                                FrunPanel.Visible = false;
                                buttonFrappe.Enabled = false;
                                buttonFrappe.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Iced Mocha":
                                IMoutLabel.Visible = true;
                                IMrunPanel.Visible = false;
                                buttonIcedMocha.Enabled = false;
                                buttonIcedMocha.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Nitro Cold Brew":
                                NoutLable.Visible = true;
                                NrunPanel.Visible = false;
                                buttonNitroColdBrew.Enabled = false;
                                buttonNitroColdBrew.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Coffee Milk Shake":
                                CMoutLabel.Visible = true;
                                CMrunPanel.Visible = false;
                                buttonCoffeeMilkShake.Enabled = false;
                                buttonCoffeeMilkShake.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                            case "Affogato":
                                AoutLabel.Visible = true;
                                ArunPanel.Visible = false;
                                buttonAffogato.Enabled = false;
                                buttonAffogato.BackColor = Color.FromArgb(128, 64, 64);
                                break;
                        }
                    }
                }
            }
        }

        private void RunningOutInventoryWarning()
        {
            string[] coldCoffeeNames = {"Iced Coffee", "Cold Brew", "Iced Latte", "Frappe",
        "Iced Mocha", "Nitro Cold Brew", "Coffee Milk Shake", "Affogato"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string coldName in coldCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT ColdCoffeeStatus, ColdCoffeeStock FROM ColdCoffeeInventory WHERE ColdCoffeeName = @ColdCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@ColdCoffeeName", coldName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string coldCoffeeStatus = reader["ColdCoffeeStatus"].ToString();
                            int coldCoffeeStock = Convert.ToInt32(reader["ColdCoffeeStock"]);

                            if (coldCoffeeStatus == "Running Out")
                            {
                                switch (coldName)
                                {
                                    case "Iced Coffee":
                                        IrunPanel.Visible = true;
                                        IrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Cold Brew":
                                        CBrunPanel.Visible = true;
                                        CBrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Iced Latte":
                                        ILrunPanel.Visible = true;
                                        ILrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Frappe":
                                        FrunPanel.Visible = true;
                                        FrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Iced Mocha":
                                        IMrunPanel.Visible = true;
                                        IMrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Nitro Cold Brew":
                                        NrunPanel.Visible = true;
                                        NrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Coffee Milk Shake":
                                        CMrunPanel.Visible = true;
                                        CMrunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
                                        break;
                                    case "Affogato":
                                        ArunPanel.Visible = true;
                                        ArunLabel.Text = "RUNNING OUT" + Environment.NewLine +
                                            "Stock Left: " + coldCoffeeStock;
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
            string[] coldCoffeeNames = {"Iced Coffee", "Cold Brew", "Iced Latte", "Frappe",
                "Iced Mocha", "Nitro Cold Brew", "Coffee Milk Shake", "Affogato"};

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (string coldName in coldCoffeeNames)
                {
                    SqlCommand cmd = new SqlCommand("SELECT ColdCoffeeStatus FROM ColdCoffeeInventory WHERE ColdCoffeeName = @ColdCoffeeName", connection);
                    cmd.Parameters.AddWithValue("@ColdCoffeeName", coldName);

                    string coldCoffeeStatus = (string)cmd.ExecuteScalar();
                    if (coldCoffeeStatus == "Available")
                    {
                        switch (coldName)
                        {
                            case "Iced Coffee":
                                ICoutLabel.Visible = false;
                                IrunPanel.Visible = false;
                                buttonIcedCoffee.Enabled = true;
                                buttonIcedCoffee.BackColor = Color.LightSalmon;
                                break;
                            case "Cold Brew":
                                CBoutLabel.Visible = false;
                                CBrunPanel.Visible = false;
                                buttonColdBrew.Enabled = true;
                                buttonColdBrew.BackColor = Color.LightSalmon;
                                break;
                            case "Iced Latte":
                                ILoutLabel.Visible = false;
                                ILrunPanel.Visible = false;
                                buttonIcedLatte.Enabled = true;
                                buttonIcedLatte.BackColor = Color.LightSalmon;
                                break;
                            case "Frappe":
                                FoutLabel.Visible = false;
                                FrunPanel.Visible = false;
                                buttonFrappe.Enabled = true;
                                buttonFrappe.BackColor = Color.LightSalmon;
                                break;
                            case "Iced Mocha":
                                IMoutLabel.Visible = false;
                                IMrunPanel.Visible = false;
                                buttonIcedMocha.Enabled = true;
                                buttonIcedMocha.BackColor = Color.LightSalmon;
                                break;
                            case "Nitro Cold Brew":
                                NoutLable.Visible = false;
                                NrunPanel.Visible = false;
                                buttonNitroColdBrew.Enabled = true;
                                buttonNitroColdBrew.BackColor = Color.LightSalmon;
                                break;
                            case "Coffee Milk Shake":
                                CMoutLabel.Visible = false;
                                CMrunPanel.Visible = false;
                                buttonCoffeeMilkShake.Enabled = true;
                                buttonCoffeeMilkShake.BackColor = Color.LightSalmon;
                                break;
                            case "Affogato":
                                AoutLabel.Visible = false;
                                ArunPanel.Visible = false;
                                buttonAffogato.Enabled = true;
                                buttonAffogato.BackColor = Color.LightSalmon;
                                break;
                        }
                    }
                }
            }
        }


        public void ColdCoffeeTimer_Tick(object sender, EventArgs e)
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

