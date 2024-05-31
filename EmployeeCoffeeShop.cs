using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class EmployeeCoffeeShop : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        private Form activeForm;
        private LoginForm loginForm;
        public string accountId;

        public EmployeeCoffeeShop(LoginForm loginForm, string accountId)
        {
            InitializeComponent();
            InitializeReceiptDataGridView();
            this.loginForm = loginForm;
            this.accountId = accountId;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Close_Button_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //***************DASHBOARD BUTTONS***************// //***************DASHBOARD BUTTONS***************// //***************DASHBOARD BUTTONS***************//
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] { Hcoffee_button, Ccoffee_button, Food_Button, Sales_Button, Account_Button, Inventory_Button })
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.SaddleBrown;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = Color.LightSalmon;
                    button.Enabled = true;
                }

            }
        }
        private void Food_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuFoodForm(this), sender);
            DesktopPanel.Size = new Size(910, 828);
        }
        private void Ccoffee_button_Click(object sender, EventArgs e)
        {

            OpenChildForm(new MenuColdCoffeeForm(this), sender);
            DesktopPanel.Size = new Size(910, 828);

        }
        public void Hcoffee_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuHotCoffeeForm(this), sender);
            DesktopPanel.Size = new Size(910, 828);
        }

        private void Sales_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeSalesForm(), sender);
            DesktopPanel.Size = new Size(1320, 828);
            DesktopPanel.BringToFront();
            panel8.BringToFront();
        }
        private void Inventory_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeInventoryForm(), sender);
            DesktopPanel.Size = new Size(1320, 828);
            DesktopPanel.BringToFront();
            panel8.BringToFront();
        }
        private void Account_Button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeAccountForm(this, accountId), sender);
            DesktopPanel.Size = new Size(1320, 828);
            DesktopPanel.BringToFront();
            panel8.BringToFront();
        }

        //***************DASHBOARD BUTTONS***************// //***************DASHBOARD BUTTONS***************// //***************DASHBOARD BUTTONS***************////***************DASHBOARD BUTTONS***************//

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************////***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

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
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel5_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

        //***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************////***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************////***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************////***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************//

        public TextBox SenderPrice => textBoxPrice;
        public TextBox SenderQuantity => textBoxQuantity;
        public TextBox SenderChange => textBoxChange;

        public void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                PesoLabel.Visible = true;
                textBoxPrice.Focus();
            }
            else
            {
                PesoLabel.Visible = false;
            }
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                PesoLabel1.Visible = true;
                textBoxAmount.Focus();
            }
            else
            {
                PesoLabel1.Visible = false;
            }
        }
        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxChange.Text))
            {
                PesoLabel2.Visible = true;
                textBoxChange.Focus();
            }
            else
            {
                PesoLabel2.Visible = false;
            }
        }
        private void receiptdgv_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void textBoxQuantity_TextChanged(object sender, EventArgs e) { }
        public void InitializeReceiptDataGridView()
        {
            receiptdgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            receiptdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            receiptdgv.ScrollBars = ScrollBars.Vertical;
            receiptdgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            receiptdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }
        public DataGridView ReceiptDataGridView => receiptdgv;

        private void Total_button_Click(object sender, EventArgs e)
        {
            if (ReceiptDataGridView.Rows.Count == 0)
            {
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
            }
            else
            {
                double totalPrice = 0;
                int totalCount = 0;
                foreach (DataGridViewRow row in ReceiptDataGridView.Rows)
                {
                    double price = Convert.ToDouble(row.Cells["PriceColumn"].Value);
                    int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);

                    totalPrice += price;
                    totalCount += quantity;
                }
                textBoxPrice.Text = totalPrice.ToString();
                textBoxQuantity.Text = totalCount.ToString();
            }
        }
        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (receiptdgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult yesORno = MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesORno == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = receiptdgv.SelectedRows[0];
                receiptdgv.Rows.Remove(selectedRow);
                receiptdgv.ClearSelection();
                textBoxPrice.Clear();
                textBoxQuantity.Clear();
            }
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure to clear the receipt? Please cofirm.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (yesORno == DialogResult.Yes)
            {
                receiptdgv.Rows.Clear();
                textBoxPrice.Clear();
                textBoxAmount.Clear();
                textBoxChange.Clear();
                textBoxQuantity.Clear();
            }
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                MessageBox.Show("Please input the amount.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Please calculate the total.", "Total Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double num1 = Convert.ToDouble(textBoxPrice.Text);
            double num2 = Convert.ToDouble(textBoxAmount.Text);
            double total = num2 - num1;
            textBoxChange.Text = total.ToString();
            if (total <= -1)
            {
                double missingFees = Math.Abs(total);
                MessageBox.Show($"Please inform the customer to pay the missing fees." +
                    Environment.NewLine +
                    $"Missing fees: ₱{missingFees}", "Payment is not enough.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Receipt_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxChange.Text))
            {
                MessageBox.Show("Please calculate first.", "Missing Calculation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double change = Convert.ToDouble(textBoxChange.Text);

            if (change < 0)
            {
                double missingFees = -change;
                MessageBox.Show("Receipt will not process unless the customer makes full payment." +
                    "Missing fees: ₱ " + missingFees, "Receipt Won't Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool ColdBool = ColdCoffeeInevntory();
                bool FoodBool = FoodInventory();
                bool HotBool = HotCoffeeInventory();

                if (ColdBool == false)
                {
                    //MessageBox.Show("TRANSACTION FOR COLD COFEE CANCELLED");
                }
                else if (FoodBool == false)
                {
                    //MessageBox.Show("TRANSACTION FOR FOOD CANCELLED");
                }
                else if (HotBool == false)
                {
                    //MessageBox.Show("TRANSACTION FRO HOT COFFEE CANCELLED");
                }
                else
                {
                    showReceipt();
                }

            }
        }

        private void showReceipt()
        {
            string employeeID = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT EmployeeID FROM Account WHERE AccountID = @AccountID;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@AccountID", accountId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employeeID = reader["EmployeeID"].ToString();
                }
            }

            double amountPaid = Convert.ToDouble(textBoxAmount.Text);
            double changeAmount = Convert.ToDouble(textBoxChange.Text);
            FormReceipt receiptForm = new FormReceipt(amountPaid, changeAmount, employeeID);

            foreach (DataGridViewRow row in ReceiptDataGridView.Rows)
            {
                string product = row.Cells["ProductColumn"].Value.ToString();
                double price = Convert.ToDouble(row.Cells["PriceColumn"].Value);
                int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                receiptForm.AddToReceipt(product, price, quantity);
            }
            receiptForm.ShowDialog();
        }
        //***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************// //***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************////***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************////***************RECEIPT BUTTONS,DATA AND BEHAVIOR***************//

        //***************QUANTITY TO INVENTORY CHECKER***************// //***************QUANTITY TO INVENTORY CHECKER***************// //***************QUANTITY TO INVENTORY CHECKER***************//

        private bool ColdCoffeeInevntory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in receiptdgv.Rows)
                {
                    string coldCoffeeName = row.Cells["ProductColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    int stock;

                    SqlCommand cmd = new SqlCommand("SELECT ColdCoffeeStock FROM ColdCoffeeInventory WHERE ColdCoffeeName = @ColdCoffeeName;", connection);
                    cmd.Parameters.AddWithValue("@ColdCoffeeName", coldCoffeeName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return true;
                        }
                        stock = Convert.ToInt32(reader["ColdCoffeeStock"]);
                        if (quantity > stock)
                        {
                            MessageBox.Show("Not enough stock for " + coldCoffeeName + " Available stock: " + stock, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool HotCoffeeInventory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in receiptdgv.Rows)
                {
                    string hotCoffeeName = row.Cells["ProductColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    int stock;

                    SqlCommand cmd = new SqlCommand("SELECT HotCoffeeStock FROM HotCoffeeInventory WHERE HotCoffeeName = @HotCoffeeName;", connection);
                    cmd.Parameters.AddWithValue("@HotCoffeeName", hotCoffeeName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return true;
                        }
                        stock = Convert.ToInt32(reader["HotCoffeeStock"]);
                        if (quantity > stock)
                        {
                            MessageBox.Show("Not enough stock for " + hotCoffeeName + ". Available stock: " + stock, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                    }
                }
            }
            return true;
        }

        private bool FoodInventory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                foreach (DataGridViewRow row in receiptdgv.Rows)
                {
                    string foodName = row.Cells["ProductColumn"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["QuantityColumn"].Value);
                    int stock;

                    SqlCommand cmd = new SqlCommand("SELECT FoodStock FROM FoodInventory WHERE FoodName = @FoodName;", connection);
                    cmd.Parameters.AddWithValue("@FoodName", foodName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return true;
                        }
                        stock = Convert.ToInt32(reader["FoodStock"]);
                        if (quantity > stock)
                        {
                            MessageBox.Show("Not enough stock for " + foodName + ". Available stock: " + stock, "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                    }
                }
            }
            return true;
        }

        //***************QUANTITY TO INVENTORY CHECKER***************// //***************QUANTITY TO INVENTORY CHECKER***************//

    }
}