using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.PeerToPeer;
using Microsoft.Identity.Client;

namespace CoffeeShop
{
    public partial class LoginForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public LoginForm()
        {
            InitializeComponent();

            labelName.Parent = pictureBox1;
            labelName.BackColor = Color.Transparent;
            labelPassword.Parent = pictureBox1;
            labelPassword.BackColor = Color.Transparent;
            labelEmporAd.Parent = pictureBox1;
            labelEmporAd.BackColor = Color.Transparent;
            checkBoxPassword.Parent = pictureBox1;
            checkBoxPassword.BackColor = Color.Transparent;
        }
        private void LoginForm_Load(object sender, EventArgs e){}

        //***************LABEL PLACEHOLDER BEHAVIOR***************// //***************LABEL PLACEHOLDER BEHAVIOR***************//
        private void txtboxUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUserName.Text))
            {
                labelPlaceholderName.Visible = true;
                txtboxUserName.Focus();
            }
            else
            {
                labelPlaceholderName.Visible = false;
            }
        }
        private void txtboxUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxUserPassword.Text))
            {
                labelPlaceholderPassword.Visible = true;
                txtboxUserPassword.Focus();
            }
            else
            {
                labelPlaceholderPassword.Visible = false;
            }
        }
        private void txtboxUserName_Click(object sender, EventArgs e)
        {
            if (txtboxUserName.Text == "")
            {
                labelPlaceholderName.BringToFront();
                txtboxUserName.SendToBack();
            }
            else if (txtboxUserPassword.Text == "")
            {
                labelPlaceholderName.BringToFront();
            }
        }
        private void txtboxUserPassword_Click(object sender, EventArgs e)
        {
            if (txtboxUserPassword.Text == "")
            {
                labelPlaceholderPassword.BringToFront();
                txtboxUserPassword.SendToBack();
            }
        }
        private void labelPlaceholderName_Click(object sender, EventArgs e)
        {

            txtboxUserName.Focus();
        }
        private void labelPlaceholderPassword_Click(object sender, EventArgs e)
        {

            txtboxUserPassword.Focus();
        }
        //***************LABEL PLACEHOLDER BEHAVIOR***************////***************LABEL PLACEHOLDER BEHAVIOR***************//
        
        //***************BUTTON BEHAVIORS AND SQL SERVER CONNNECTIONS***************////***************BUTTON BEHAVIORS AND SQL SERVER CONNNECTIONS***************//
        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] {buttonEmployee,buttonAdmin})
            {
                button.BackColor = button == clickedButton ? Color.FromArgb(64, 64, 0) : Color.DarkGray;
            }
        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                txtboxUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxUserPassword.UseSystemPasswordChar = true;
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtboxUserName.Text;
            string password = txtboxUserPassword.Text;

            switch (labelPlaceholderPassword.Text)
            {
                case "Enter Employee Password":
                    EmployeeLogin(username, password);
                break;
                case "Enter Admin Password":
                    AdminLogin();
                break;
                default:
                break;
            }

        }
        private void EmployeeLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Account WHERE EmployeeID = @EmployeeID AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EmployeeID", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dta = new DataTable();
                sda.Fill(dta);

                if (dta.Rows.Count > 0)
                {
                    string accountId = dta.Rows[0]["AccountId"].ToString();
                    EmployeeCoffeeShop coffeeShopManagementSystem = new EmployeeCoffeeShop(this, accountId);
                    coffeeShopManagementSystem.Show();
                    MessageBox.Show("Successfully Logged in", "Employee is now logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void AdminLogin()
        {
            if (txtboxUserName.Text == "Admin" && txtboxUserPassword.Text == "Password")
            {
                AdminCoffeeShop adminCoffeeShop = new AdminCoffeeShop();
                adminCoffeeShop.Show();
                MessageBox.Show("Successfully Logged in", "Admin is now logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetButtonBackgrounds(button);

            labelPlaceholderName.Text = "Enter Employee User ID";
            labelPlaceholderPassword.Text = "Enter Employee Password";
        }
        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetButtonBackgrounds(button);

            labelPlaceholderName.Text = "Enter Admin User ID";
            labelPlaceholderPassword.Text = "Enter Admin Password";
        }
        private void Clearbttn_Click(object sender, EventArgs e)
        {
            txtboxUserName.Clear();
            txtboxUserPassword.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtboxUserPassword.Text = ("Password04");
            txtboxUserName.Text = ("Employee04");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxUserPassword.Text = ("Password");
            txtboxUserName.Text = ("Admin");
        }
        //***************BUTTON BEHAVIORS AND SQL SERVER CONNNECTIONS***************// //***************BUTTON BEHAVIORS AND SQL SERVER CONNNECTIONS***************//
    }
}
