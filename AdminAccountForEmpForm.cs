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
using Microsoft.Identity.Client;

namespace CoffeeShop
{
    public partial class AdminAccountForEmpForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";

        public AdminAccountForEmpForm()
        {
            InitializeComponent();
        }
        private void AdminAccountForEmpForm_Load(object sender, EventArgs e)
        {
            ClrSelectTimer.Start();
            FillAccontDGV();
            FillEmployeeDGV();
            AdjustEmployeeDGV(EmployeeDGV);
        }

        private void ClrSelectTimer_Tick(object sender, EventArgs e)
        {
            ClrSelectTimer.Stop();
            EmployeeDGV.ClearSelection();
            AccountDGV.ClearSelection();
        }


        //***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************// 

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
        private void AddPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void RemovePanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void UpdatePanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel1_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel12_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        //***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************// 

        private void SetButtonBackgrounds(Button clickedButton)
        {
            foreach (Button button in new Button[] { AddButton, RemoveButton, UpdateButton})
            {
                if (button == clickedButton)
                {
                    button.BackColor = Color.FromArgb(255, 255, 255);
                    button.ForeColor = Color.Maroon;
                }
                else
                {
                    button.BackColor = Color.Indigo;
                    button.ForeColor = Color.White;
                }
            }
        }
        //***************ADD ACCOUNT FUNCTION***************// //***************ADD ACCOUNT FUNCTION***************//

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTimer.Start();

            panelholdA.Visible = true;
            panelHoldR.Visible = false;
            panelHoldU.Visible = false;

            AddPanel.Visible = true;
            RemovePanel.Visible = false; ;
            UpdatePanel.Visible = false; ;

            Button button = (Button)sender;
            SetButtonBackgrounds(button);
            panel1.Visible = false;

            AddESComboBox.Items.Clear();
            AddESComboBox.Text = "";
            AddAIDTextBox.Clear();
            AddAPTextBox.Clear();
        }
        private void AddTimer_Tick(object sender, EventArgs e)
        {
            AddTimer.Stop();
            AddEmployeeIDSearch();
            EmployeeDGV.ClearSelection();
            AccountDGV.ClearSelection();
        }


        private void SaveAccount_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddAIDTextBox.Text) | !string.IsNullOrEmpty(AddAPTextBox.Text) | AddESComboBox.SelectedIndex != -1)
            {
                EmployeeIDExists();
            }
            else 
            {
                MessageBox.Show("Rows or Selection cannot be blank");
            }
        }
        private void AddEmployeeIDSearch()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID FROM Employee", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AddESComboBox.Items.Add(reader["EmployeeID"].ToString());
                }

                reader.Close();
                connection.Close();
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure to clear all data? ", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(yesORno == DialogResult.Yes) 
            {
                AddESComboBox.SelectedIndex = -1;
                AddAIDTextBox.Clear();
                AddAPTextBox.Clear();
            }
        }

        private void AccountIDExists()
        {
            string accID = AddAIDTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE AccountID = @AccountID", connection);
                cmd.Parameters.AddWithValue("@AccountID", accID);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("An account with an ID of "+ accID + " already exists");
                }
                else
                {
                    AddAccount();
                }
            }
        }
        private void EmployeeIDExists()
        {
            string empID = AddESComboBox.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", empID);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("An account for this employee already exists.");
                }
                else 
                {
                    DialogResult yesORno = MessageBox.Show("Are you sure to add account? ", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (yesORno == DialogResult.Yes)
                    { 
                        AccountIDExists(); 
                    }
                }
            }
        }

        private void AddAccount()
        {
            string accID = AddAIDTextBox.Text; 
            string pass = AddAPTextBox.Text;
            string empID = AddESComboBox.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Account (AccountID, Password,EmployeeId) VALUES (@AccountID, @Password,@EmployeeID)", connection);
                cmd.Parameters.AddWithValue("@AccountID", accID);
                cmd.Parameters.AddWithValue("@Password", pass); 
                cmd.Parameters.AddWithValue("@EmployeeID", empID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add account.");
                }
            }
        }

        //***************ADD ACCOUNT FUNCTION***************// //***************ADD ACCOUNT FUNCTION***************//

        //***************REMOVE ACCOUNT FUNCTION***************// //***************REMOVE ACCOUNT FUNCTION***************//
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Removetimer.Start();

            panelHoldR.Visible = true;
            panelHoldR.BringToFront();

            panelholdA.Visible = false;
            panelHoldU.Visible = false;

            Button button = (Button)sender;
            SetButtonBackgrounds(button);

            RemovePanel.Visible = true;
            AddPanel.Visible = false; ;
            UpdatePanel.Visible = false;
            panel1.Visible = false;

            RemAIDcombobox.Items.Clear();
            RemAIDcombobox.Text = "";
            RemEIDtextBox.Clear();
        }
        private void Removetimer_Tick(object sender, EventArgs e)
        {
            Removetimer.Stop();

            EmployeeDGV.ClearSelection();
            AccountDGV.ClearSelection();
            RemoveAccountIDSearch();
        }
        private void RemAIDcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmployeeID();
        }
        public void RemoveAccountIDSearch()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT AccountID  FROM Account", connection);
                DataTable dta = new DataTable();
                sda.Fill(dta);

                foreach (DataRow row in dta.Rows)
                {
                    RemAIDcombobox.Items.Add(row["AccountID"].ToString());
                }
            }
        }
        public void DisplayEmployeeID()
        {
            string accID = RemAIDcombobox.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID FROM Account WHERE AccountID = @AccountID", connection);
                cmd.Parameters.AddWithValue("@AccountID", accID);
                object result = cmd.ExecuteScalar();

                RemEIDtextBox.Text = result.ToString();
            }
        }
        private void RemDelAccButton_Click(object sender, EventArgs e)
        {
            if (RemAIDcombobox.SelectedItem != null)
            {
                DialogResult yesORno = MessageBox.Show("Are you sure to delete account?", "CONFRIMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesORno == DialogResult.Yes)
                {
                    string accID = RemAIDcombobox.SelectedItem.ToString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Account WHERE AccountID = @AccountID", connection);
                        cmd.Parameters.AddWithValue("@AccountID", accID);
                        int rowsFound = cmd.ExecuteNonQuery();

                        if (rowsFound > 0)
                        {
                            MessageBox.Show("Account " + accID + " deleted successfully.");
                            RemAIDcombobox.Items.Remove(accID);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete account.");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select an account to delete first");
            }
        }

        //***************REMOVE ACCOUNT FUNCTION***************// //***************REMOVE ACCOUNT FUNCTION***************//

        //***************UPDATE ACCOUNT FUNCTION***************// //***************UPDATE ACCOUNT FUNCTION***************//

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateTimer.Start();

            panelHoldU.Visible = true;
            panelHoldR.Visible = false;
            panelholdA.Visible = false;

            UpdatePanel.Visible = true;
            RemovePanel.Visible = false;
            AddPanel.Visible = false;

            Button button = (Button)sender;
            SetButtonBackgrounds(button);

            panel1.Visible = false;

            UpAIDcombobox.Items.Clear();
            UpAIDcombobox.Text = "";
            UpEMPtextBox.Clear();
            UpEIDtextBox.Clear();
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
            UpdateAccountIDSearch();
            EmployeeDGV.ClearSelection();
            AccountDGV.ClearSelection();
        }


        private void Update_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UpEIDtextBox.Text) | !string.IsNullOrWhiteSpace(UpEMPtextBox.Text) | UpAIDcombobox.SelectedIndex != -1)
            {
                DialogResult yesORno = MessageBox.Show("Are you sure to change the account password", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yesORno == DialogResult.Yes)
                {
                    UpdateEmployeePassword();
                }
            }
            else
            {
                MessageBox.Show("Rows or Selection cannot be blank");
            }
        }

        private void UpAIDcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayEmployeeIDandPassword();
        }

        public void UpdateAccountIDSearch()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT AccountID FROM Account", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    UpAIDcombobox.Items.Add(reader["AccountID"].ToString());
                }

                reader.Close();
            }
        }

        public void UpdateDisplayEmployeeIDandPassword()
        {
            string accID = UpAIDcombobox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID, Password FROM Account WHERE AccountID = @AccountID", connection);
                cmd.Parameters.AddWithValue("@AccountID", accID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string empID = reader["EmployeeID"].ToString();
                    string empPass = reader["Password"].ToString();
                    UpEIDtextBox.Text = empID;
                    UpEMPtextBox.Text = empPass;
                }
            }
        }
        public void UpdateEmployeePassword()
        {
            string empID = UpEIDtextBox.Text;
            string empPass = UpEMPtextBox.Text;
            string accID = UpAIDcombobox.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(empPass))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Account SET Password = @Password WHERE AccountID = @AccountID", connection);
                    cmd.Parameters.AddWithValue("@AccountID", accID);
                    cmd.Parameters.AddWithValue("@Password", empPass);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password for " + empID + "has been changed");
                }
            }
            else
            {
                MessageBox.Show("Password cannot be empty");
            }
        }

        

        //***************UPDATE ACCOUNT FUNCTION***************// //***************UPDATE ACCOUNT FUNCTION***************//

        //***************REFRESH EMPLOYEE AND ACCOUNT TABLE***************// //***************REFRESH EMPLOYEE AND ACCOUNT TABLE***************//
        private void Refresh_button_Click(object sender, EventArgs e)
        {
            timer1.Start();

            EmployeeDGV.DataSource = null;
            EmployeeDGV.Rows.Clear();
            EmployeeDGV.Columns.Clear();

            AccountDGV.DataSource = null;
            AccountDGV.Rows.Clear();
            AccountDGV.Columns.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FillAccontDGV();
            FillEmployeeDGV();
            EmployeeDGV.ClearSelection();
            AccountDGV.ClearSelection();
        }

        //***************REFRESH EMPLOYEE AND ACCOUNT TABLE***************// //***************REFRESH EMPLOYEE AND ACCOUNT TABLE***************//

        //***************DISPLAY EMPLOYEE AND ACCOUNT TABLE***************// //***************DISPLAY EMPLOYEE AND ACCOUNT TABLE***************//

        public void AdjustEmployeeDGV(DataGridView EmployeeDGV)
        {
            EmployeeDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            EmployeeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeDGV.ScrollBars = ScrollBars.Vertical;
            EmployeeDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        private void FillEmployeeDGV()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT EmployeeID,EmployeeName,EmployeeRole,SalaryPerHour,EmployeeHireDate FROM Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            EmployeeDGV.DataSource = dta;
            connection.Close();
        }

        private void FillAccontDGV()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Account";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            AccountDGV.DataSource = dta;
            connection.Close();
        }
        //***************DISPLAY EMPLOYEE AND ACCOUNT TABLE***************// //***************DISPLAY EMPLOYEE AND ACCOUNT TABLE***************//

    }
}
