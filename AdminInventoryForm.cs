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
using static System.ComponentModel.Design.ObjectSelectorEditor;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop
{
    public partial class AdminInventoryForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public AdminInventoryForm()
        {
            InitializeComponent();
        }

        private void AdminInventoryForm_Load(object sender, EventArgs e)
        {

        }
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] { Foodbutton, HCoffeebutton, ColdCoffeebutton })
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.BackColor = Color.Indigo;
                    button.ForeColor = Color.White;
                }
            }
        }
        //***************PANEL DESIGNS***************//  //***************PANEL DESIGNS***************//  //***************PANEL DESIGNS***************//
        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
      
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel5_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel6_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel7_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel8_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel10_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel9_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        //***************PANEL DESIGNS***************//  //***************PANEL DESIGNS***************//  //***************PANEL DESIGNS***************//

        private void InvComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Foodbutton.BackColor == Color.White)
            {
                FoodData();
            }
            if (HCoffeebutton.BackColor == Color.White)
            {
                HotData();
            }
            if (ColdCoffeebutton.BackColor == Color.White)
            {
                ColdData();
            }
        }
        //***************FOOD INVENTORY***************// //***************FOOD INVENTORY***************// //***************FOOD INVENTORY***************// 
        private void Foodbutton_Click(object sender, EventArgs e)
        {
            ClearFoodTimer.Start();
            FillFoodDGV();
            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            ProductLabel.Text = "Food";

            InvComboBox.Items.Clear();
            InvComboBox.Text = ""; 

            PNtextBox.Clear();
            OQTextbox.Clear();
            PStextBox.Clear();
            NQtextBox.Clear();
        }

        private void ClearFoodTimer_Tick(object sender, EventArgs e)
        {
            ClearFoodTimer.Stop();
            InverntoryDGV.ClearSelection();
            FoodID();
        }
        private void FoodID() 
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FoodID FROM FoodInventory", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InvComboBox.Items.Add(reader["FoodID"]);
                }
                reader.Close();
            }
        }
        private void FoodData()
        {
            string selectedFoodID = InvComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT FoodName, FoodStock, FoodStatus FROM FoodInventory WHERE FoodID = @FoodID", connection);
                cmd.Parameters.AddWithValue("@FoodID", selectedFoodID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PNtextBox.Text = reader["FoodName"].ToString();
                    OQTextbox.Text = reader["FoodStock"].ToString();
                    NQtextBox.Text = reader["FoodStock"].ToString();
                    PStextBox.Text = reader["FoodStatus"].ToString();
                }
                reader.Close();
            }
        }

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
        //***************FOOD INVENTORY***************// //***************FOOD INVENTORY***************// //***************FOOD INVENTORY***************//

        //***************HOT COFFEE INVENTORY***************// //***************HOT COFFEE INVENTORY***************// //***************HOT COFFEE INVENTORY***************//
        private void HCoffeebutton_Click(object sender, EventArgs e)
        {
            ClearHotTimer.Start();
            FillHotCoffeeDGV();
            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            ProductLabel.Text = "Hot Coffee";

            InvComboBox.Items.Clear();
            InvComboBox.Text = ""; 

            PNtextBox.Clear();
            OQTextbox.Clear();
            PStextBox.Clear();
            NQtextBox.Clear();
        }

        private void ClearHotTimer_Tick(object sender, EventArgs e)
        {
            ClearHotTimer.Stop();
            InverntoryDGV.ClearSelection();
            HotID();
        }
        private void HotID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT HotCoffeeID FROM HotCoffeeInventory", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    InvComboBox.Items.Add(reader["HotCoffeeID"]);
                }
                reader.Close();
            }
        }
        private void HotData() 
        {
            string selectedHotID = InvComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  HotCoffeeName,  HotCoffeeStatus,  HotCoffeeStock FROM HotCoffeeInventory WHERE  HotCoffeeID = @HotID", connection);
                cmd.Parameters.AddWithValue("@HotID", selectedHotID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    PNtextBox.Text = reader["HotCoffeeName"].ToString();
                    OQTextbox.Text = reader["HotCoffeeStock"].ToString();
                    NQtextBox.Text = reader["HotCoffeeStock"].ToString();
                    PStextBox.Text = reader["HotCoffeeStatus"].ToString();
                }
                reader.Close();
            }
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
        //***************HOT COFFEE INVENTORY***************// //***************HOT COFFEE INVENTORY***************// //***************HOT COFFEE INVENTORY***************//

        //***************COLD COFFEE INVENTORY***************// //***************COLD COFFEE INVENTORY***************////***************COLD COFFEE INVENTORY***************//
        
        private void ColdCoffeebutton_Click(object sender, EventArgs e)
        {
            ClearColdTimer.Start();
            FillColdCoffeeDGV();
            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            ProductLabel.Text = "Cold Coffee";

            InvComboBox.Items.Clear();
            InvComboBox.Text = ""; 

            PNtextBox.Clear();
            OQTextbox.Clear();
            PStextBox.Clear();
            NQtextBox.Clear();
            ColdID();
        }
        private void ColdID() 
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ColdCoffeeID FROM  ColdCoffeeInventory", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    InvComboBox.Items.Add(reader["ColdCoffeeID"]);
                }
                reader.Close();
            }
        }
        private void ColdData() 
        {
            string selectedColdID = InvComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT  ColdCoffeeStatus,ColdCoffeeName, ColdCoffeeStock FROM ColdCoffeeInventory WHERE  ColdCoffeeID = @ColdID ", connection);
                cmd.Parameters.AddWithValue("@ColdID", selectedColdID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PNtextBox.Text = reader["ColdCoffeeName"].ToString();
                    OQTextbox.Text = reader["ColdCoffeeStock"].ToString();
                    NQtextBox.Text = reader["ColdCoffeeStock"].ToString();
                    PStextBox.Text = reader["ColdCoffeeStatus"].ToString();
                }
                reader.Close();
            }
        }
        private void ClearColdTimer_Tick(object sender, EventArgs e)
        {
            ClearColdTimer.Stop();
            InverntoryDGV.ClearSelection();
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

        //***************COLD COFFEE INVENTORY***************// //***************COLD COFFEE INVENTORY***************// //***************COLD COFFEE INVENTORY***************//

        //***************REFRESH BUTTON***************// //***************REFRESH BUTTON***************// //***************REFRESH BUTTON***************//

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            RefreshTImer.Start();
            if (Foodbutton.BackColor == Color.White)
            {
                InverntoryDGV.DataSource = null;
                InverntoryDGV.Rows.Clear();
                InverntoryDGV.Columns.Clear();
            }
            if (HCoffeebutton.BackColor == Color.White)
            {
                InverntoryDGV.DataSource = null;
                InverntoryDGV.Rows.Clear();
                InverntoryDGV.Columns.Clear();
            }
            if (ColdCoffeebutton.BackColor == Color.White)
            {
                InverntoryDGV.DataSource = null;
                InverntoryDGV.Rows.Clear();
                InverntoryDGV.Columns.Clear();
            }
            MinusComboBox.Text = "";
            AddComboBox.Text = "";
            PNtextBox.Clear();
            OQTextbox.Clear();
            PStextBox.Clear();
            NQtextBox.Clear();
        }

        private void RefreshTImer_Tick(object sender, EventArgs e)
        {
            RefreshTImer.Stop();
            if (Foodbutton.BackColor == Color.White)
            {
                if(InvComboBox.SelectedItem != null) 
                {
                    FoodData();
                }
                FillFoodDGV();
                InverntoryDGV.ClearSelection();
            }
            if (HCoffeebutton.BackColor == Color.White)
            {
                if (InvComboBox.SelectedItem != null)
                {
                    HotData();
                }
                FillHotCoffeeDGV();
                InverntoryDGV.ClearSelection();
            }
            if (ColdCoffeebutton.BackColor == Color.White)
            {
                if (InvComboBox.SelectedItem != null)
                {
                    ColdData();
                }
                FillColdCoffeeDGV();
                InverntoryDGV.ClearSelection();
            }

            
        }
        //***************REFRESH BUTTON***************// //***************REFRESH BUTTON***************// //***************REFRESH BUTTON***************//

        //***************CHANGE QUANTITY BUTTON***************// //***************CHANGE QUANTITY BUTTON***************// //***************CHANGE QUANTITY BUTTON***************//

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NQtextBox.Text)) 
            {
                int currentValue = Convert.ToInt32(NQtextBox.Text);
                currentValue++;
                NQtextBox.Text = currentValue.ToString();
            }
            else 
            {
                MessageBox.Show("Please choose a product first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NQtextBox.Text)) 
            {
                int currentValue = Convert.ToInt32(NQtextBox.Text);
                if(currentValue > 0) 
                {
                    currentValue--;
                    NQtextBox.Text = currentValue.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please choose a product first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Udpate_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NQtextBox.Text))
            {
                DialogResult yesORno = MessageBox.Show("Are you sure to change the product stock? ", "CONFRIMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesORno == DialogResult.Yes)
                {
                    if (Foodbutton.BackColor == Color.White)
                    {
                        MessageBox.Show("Food quantity has been updated");
                        NewFoodQuantity();
                    }
                    if (HCoffeebutton.BackColor == Color.White)
                    {
                        MessageBox.Show("Hot coffee quantity has been updated");
                        NewHotQuantity();
                    }
                    if (ColdCoffeebutton.BackColor == Color.White)
                    {
                        MessageBox.Show("Cold coffee quantity has been updated");
                        NewColdQuantity();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a product first.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void NewFoodQuantity()
        {
            string selectedFood = InvComboBox.SelectedItem.ToString();
            int newFoodStock = Convert.ToInt32(NQtextBox.Text); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE FoodInventory SET FoodStock = @FoodStock WHERE FoodID = @Fid", connection);
                cmd.Parameters.AddWithValue("@Fid", selectedFood);
                cmd.Parameters.AddWithValue("@FoodStock", newFoodStock);

                cmd.ExecuteNonQuery();
            }
        }

        private void NewHotQuantity() 
        {
            string selectedHot = InvComboBox.SelectedItem.ToString();
            int newHotStock = Convert.ToInt32(NQtextBox.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE HotCoffeeInventory SET HotCoffeeStock = @HotCoffeeStock WHERE  HotCoffeeID= @Hid", connection);
                cmd.Parameters.AddWithValue("@Hid", selectedHot);
                cmd.Parameters.AddWithValue("@HotCoffeeStock", newHotStock);

                cmd.ExecuteNonQuery();
            }
        }

        private void NewColdQuantity() 
        {
            string selectedCold = InvComboBox.SelectedItem.ToString();
            int newColdStock = Convert.ToInt32(NQtextBox.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ColdCoffeeInventory SET ColdCoffeeStock = @ColdCoffeeStock WHERE ColdCoffeeID = @Cid", connection);
                cmd.Parameters.AddWithValue("@Cid", selectedCold);
                cmd.Parameters.AddWithValue("@ColdCoffeeStock", newColdStock);

                cmd.ExecuteNonQuery();
            }
        }

        private void AddComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddComboBox.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(NQtextBox.Text)) 
                {
                    DialogResult ok = MessageBox.Show("Please select a product first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ok == DialogResult.OK)
                    {
                        MinusComboBox.SelectedIndex = -1;
                        AddComboBox.SelectedIndex = -1;
                        AddComboBox.Text = "";
                        MinusComboBox.Text = "";
                    }
                    else
                    {
                        MinusComboBox.SelectedIndex = -1;
                        AddComboBox.SelectedIndex = -1;
                        AddComboBox.Text = "";
                        MinusComboBox.Text = "";
                    }
                }
                else
                {
                    int currentValue = Convert.ToInt32(NQtextBox.Text);
                    int newValue = Convert.ToInt32(AddComboBox.SelectedItem.ToString());
                    int result = currentValue + newValue;

                    NQtextBox.Text = result.ToString();

                }
            }
        }

        private void MinusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MinusComboBox.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(NQtextBox.Text)) 
                {
                    DialogResult ok = MessageBox.Show("Please select a product first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ok == DialogResult.OK) 
                    {
                        MinusComboBox.SelectedIndex = -1;
                        AddComboBox.SelectedIndex = -1;
                        MinusComboBox.Text = "";
                        AddComboBox.Text = "";
                     
                    }
                    else 
                    {
                        MinusComboBox.SelectedIndex = -1;
                        AddComboBox.SelectedIndex = -1;
                        MinusComboBox.Text = "";
                        AddComboBox.Text = "";
                    }
                }
                else 
                {
                    int currentValue = Convert.ToInt32(NQtextBox.Text);
                    int newValue = Convert.ToInt32(MinusComboBox.SelectedItem.ToString());

                    int result = currentValue - newValue;
                    if (result < 0)
                    {
                        MessageBox.Show("Resulting value cannot be negative.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NQtextBox.Text = result.ToString();
                    }
                    
                }
                    
            }
            
        }


        //***************CHANGE QUANTITY BUTTON***************// //***************CHANGE QUANTITY BUTTON***************// //***************CHANGE QUANTITY BUTTON***************//
    }
}
