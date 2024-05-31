using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AdminAddRemEmpForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public AdminAddRemEmpForm()
        {
            InitializeComponent();
        }
        private void AdminAddRemEmpForm_Load(object sender, EventArgs e)
        {
            ClrSelectTimer.Start();
            DisplayComboBoxItems();
            FillEmployeeDGV();
        }
        private void ClrSelectTimer_Tick(object sender, EventArgs e)
        {
            ClrSelectTimer.Stop();
            EmployeeDGV.ClearSelection();
        }

        //***************ADD AND REMOVE EMPLOYEE BUTTONS***************////***************ADD AND REMOVE EMPLOYEE BUTTONS***************//

        private void RemoveEmp_button_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EmployeeDGV.ClearSelection();
            RemoveEmp_button.BackColor = Color.FromArgb(255, 255, 255);
            RemoveEmp_button.ForeColor = Color.Maroon;

            Add_Button.ForeColor = Color.White;
            Add_Button.BackColor = Color.Indigo;

            panelAdd.Visible = false;
            panelRemove.Visible = true;

            panel11.BringToFront();
            panel11.Visible = true;
            panel10.Visible = false;

            RefreshSelectionTImer.Start();
            EmpIDSearchComboBox.Items.Clear();

            EmployeeNametxtBox.Clear();
            RevenueMadeTxtBox.Clear();
            ProductsSoldtxtBox.Clear();
            EmpPfppicturebox.Image = DefaultPictureBox.Image;
            CustomerSerevedtxtBox.Clear();
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            EmployeeDGV.ClearSelection();
            Add_Button.BackColor = Color.FromArgb(255, 255, 255);
            Add_Button.ForeColor = Color.Maroon;

            RemoveEmp_button.ForeColor = Color.White;
            RemoveEmp_button.BackColor = Color.Indigo;

            panelAdd.Visible = true;
            panelRemove.Visible = false;

            panel10.BringToFront();
            panel10.Visible = true;
            panel11.Visible = false;

            RefreshSelectionTImer.Start();
            EmpIDSearchComboBox.Items.Clear();
            EmployeePictureBox.Image = DefaultPictureBox.Image;

            EmpNameTxtBox.Clear();
            EmpIDtxtBox.Clear();
            SalarytxtBox.Clear();
            RoleComboBox.SelectedIndex = -1;
            HireDatePicker.Value = DateTime.Today;

        }
        private void RefreshSelectionTImer_Tick(object sender, EventArgs e)
        {
            RefreshSelectionTImer.Stop();
            DisplayComboBoxItems();
        }

        //***************ADD AND REMOVE EMPLOYEE BUTTONS***************////***************ADD AND REMOVE EMPLOYEE BUTTONS***************//

        //***************REMOVE EMPLOYEES BUTTON DASHBOARD***************// //***************REMOVE EMPLOYEES BUTTON DASHBOARD***************//
        private void EmpIDSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpIDSearchComboBox.SelectedItem != null)
            {
                DisplaySelectedEmployeeStats();
                EmployeeProfilePictureDisplay();
                DisplayEmployeeName();
            }
            else
            {
                MessageBox.Show("Please select an Employee to delete");
            }
        }

        private void DisplayComboBoxItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeID FROM Employee", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EmpIDSearchComboBox.Items.Add(reader["EmployeeID"].ToString());
                }

                reader.Close();
                connection.Close();
            }
        }
        private void EmpRemoved_Button_Click(object sender, EventArgs e)
        {
            if (EmpIDSearchComboBox.SelectedItem != null)
            {
                DialogResult yesORno = MessageBox.Show("Are you sure you want to remove the selected Employee Forever?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yesORno == DialogResult.Yes)
                {
                    RemEmpTimer.Start();
                    RemeveSelectedEmployee();
                    RemoveEmployeeAccount();
                    EmpPfppicturebox.Image = DefaultPictureBox.Image;
                }
            }
            else
            {
                MessageBox.Show("Please select and employee to delete first");
            }
        }
        private void RemEmpTimer_Tick(object sender, EventArgs e)
        {
            RemEmpTimer.Stop();
            EmployeeNametxtBox.Clear();
            RevenueMadeTxtBox.Clear();
            ProductsSoldtxtBox.Clear();
            CustomerSerevedtxtBox.Clear();
            EmpIDTextBox.Clear();
            EmployeePictureBox.Image = DefaultPictureBox.Image;
        }
        private void RemoveEmployeeAccount()
        {
            if (EmpIDSearchComboBox.SelectedItem != null)
            {
                string selectedEmployeeID = EmpIDSearchComboBox.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Account WHERE EmployeeID = @EmployeeID", connection);
                    cmd.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                    int rowsFound = cmd.ExecuteNonQuery();
                }
            }
        }

        private void RemeveSelectedEmployee()
        {
            string selectedEmpID = EmpIDSearchComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", selectedEmpID);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    EmpIDSearchComboBox.Items.Remove(selectedEmpID);
                    MessageBox.Show("Employee removed successfully.");
                }
                else
                {
                    MessageBox.Show("Employee not found in the database.");
                }
            }
        }
        private void DisplaySelectedEmployeeStats()
        {
            string selectedEmployeeID = EmpIDSearchComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT " +
                    "SUM(OrderRevenue) AS EmployeeRevenue," +
                    "SUM(OrderCustomer) AS EmployeeCustServed," +
                    "SUM(OrderProductsSold) AS EmployeeProdSold " +
                    "FROM Orders WHERE EmployeeID = @IDofEmployee ", connection);

                cmd.Parameters.AddWithValue("@IDofEmployee", selectedEmployeeID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    double RevenueGenerated;
                    int ProductSold;
                    int CustomerServed;


                    switch (reader["EmployeeRevenue"])
                    {
                        case DBNull _:
                            RevenueGenerated = 0.0;
                            break;
                        default:
                            RevenueGenerated = Convert.ToDouble(reader["EmployeeRevenue"]);
                            break;
                    }
                    switch (reader["EmployeeProdSold"])
                    {
                        case DBNull _:
                            ProductSold = 0;
                            break;
                        default:
                            ProductSold = (int)reader["EmployeeProdSold"];
                            break;
                    }
                    switch (reader["EmployeeCustServed"])
                    {
                        case DBNull _:
                            CustomerServed = 0;
                            break;
                        default:
                            CustomerServed = (int)reader["EmployeeCustServed"];
                            break;
                    }

                    RevenueMadeTxtBox.Text = "₱" + RevenueGenerated.ToString();
                    ProductsSoldtxtBox.Text = ProductSold.ToString();
                    CustomerSerevedtxtBox.Text = CustomerServed.ToString();
                }
                else
                {
                    RevenueMadeTxtBox.Text = "NO DATA FOUND";
                    ProductsSoldtxtBox.Text = "NO DATA FOUND";
                    CustomerSerevedtxtBox.Text = "NO DATA FOUND";
                }
            }
        }
        private void EmployeeProfilePictureDisplay()
        {
            string selectedEmployeeID = EmpIDSearchComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT EmployeeImage AS ProfileEmp FROM Employee WHERE EmployeeID = @IDofEmployee", connection);
                cmd.Parameters.AddWithValue("@IDofEmployee", selectedEmployeeID);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dta = new DataSet();
                sda.Fill(dta, "EmployeeImage");
                int c = dta.Tables["EmployeeImage"].Rows.Count;

                if (c > 0)
                {
                    if (dta.Tables["EmployeeImage"].Rows[c - 1]["ProfileEmp"] != DBNull.Value)
                    {
                        Byte[] byteEmployeeImage = (Byte[])(dta.Tables["EmployeeImage"].Rows[c - 1]["ProfileEmp"]);
                        MemoryStream stmEmployeeImage = new MemoryStream(byteEmployeeImage);
                        EmpPfppicturebox.Image = Image.FromStream(stmEmployeeImage);
                    }
                    else
                    {
                        EmpPfppicturebox.Image = DefaultPictureBox.Image;
                    }
                }
                else
                {
                    EmpPfppicturebox.Image = DefaultPictureBox.Image;
                }
                connection.Close();
            }
        }
        private void DisplayEmployeeName()
        {
            string selectedEmployeeID = EmpIDSearchComboBox.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select EmployeeName FROM Employee WHERE EmployeeID = @IDofEmployee", connection);
                cmd.Parameters.AddWithValue("@IDofEmployee", selectedEmployeeID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string NameOFemployee;
                    switch (reader["EmployeeName"])
                    {
                        case DBNull _:
                            NameOFemployee = "NO DATA FOUND";
                            break;
                        default:
                            NameOFemployee = Convert.ToString(reader["EmployeeName"]);
                            break;
                    }
                    EmployeeNametxtBox.Text = NameOFemployee;
                }
            }
        }

        //***************REMOVE EMPLOYEES BUTTON DASHBOARD***************// //***************REMOVE EMPLOYEES BUTTON DASHBOARD***************//

        //***************ADD EMPLOYEES BUTTON DASHBOARD***************// //***************ADD EMPLOYEES BUTTON DASHBOARD***************//
        private void EmpAdd_Button_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure to add this employee?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesORno == DialogResult.Yes)
            {
                AddEmpTimer.Start();
                EmployeeExistsORdoesnotExists();
            }
        }
        private void AddEmpTimer_Tick(object sender, EventArgs e)
        {
            AddEmpTimer.Stop();
            RoleComboBox.SelectedIndex = -1;
            HireDatePicker.Value = DateTime.Today;
            EmpNameTxtBox.Clear();
            SalarytxtBox.Clear();
            EmpIDtxtBox.Clear();
            EmployeePictureBox.Image = DefaultPictureBox.Image;
        }

        private void EmployeeExistsORdoesnotExists()
        {
            string employeeID = EmpIDtxtBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Employee with ID " + employeeID + " already exists.");
                }
                else
                {
                    AddNewEmployee();
                }
            }
        }

        private void AddNewEmployee()
        {
            string employeeID = EmpIDtxtBox.Text;
            string employeeName = EmpNameTxtBox.Text;
            string employeeRole = RoleComboBox.SelectedItem.ToString();
            double salaryPerHour = double.Parse(SalarytxtBox.Text);
            DateTime hireDate = HireDatePicker.Value;

            byte[] imageBytes = null;

            if (EmployeePictureBox.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                EmployeePictureBox.Image.Save(ms, EmployeePictureBox.Image.RawFormat);
                imageBytes = ms.ToArray();
            }
            else
            {
                DialogResult yesORno = MessageBox.Show("Are you sure you to save data without a profile picture for the employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yesORno == DialogResult.No)
                {
                    return;
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee (EmployeeID, EmployeeName, EmployeeRole, SalaryPerHour, EmployeeHireDate, EmployeeImage) VALUES (@EmployeeID, @EmployeeName, @EmployeeRole, @SalaryPerHour, @EmployeeHireDate, @EmployeeImage)", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                cmd.Parameters.AddWithValue("@EmployeeRole", employeeRole);
                cmd.Parameters.AddWithValue("@SalaryPerHour", salaryPerHour);
                cmd.Parameters.AddWithValue("@EmployeeHireDate", hireDate);
                object employeeImageValue;
                if (imageBytes != null)
                {
                    employeeImageValue = imageBytes;
                }
                else
                {
                    employeeImageValue = DBNull.Value;
                }

                cmd.Parameters.AddWithValue("@EmployeeImage", employeeImageValue);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show(employeeName + " is now an employee of Java Express.");
                }
                else
                {
                    MessageBox.Show("Failed to add " + employeeName + " as an employee");
                }
            }
        }
        private void Impot_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EmployeePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        //***************ADD EMPLOYEES BUTTON DASHBOARD***************// //***************ADD EMPLOYEES BUTTON DASHBOARD***************//

        //***************DISPLAY EMPLOYEE TABLE***************// //***************DISPLAY EMPLOYEE TABLE***************//
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
        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            EmployeeDGV.DataSource = null;
            EmployeeDGV.Rows.Clear();
            EmployeeDGV.Columns.Clear();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FillEmployeeDGV();
            EmployeeDGV.ClearSelection();
        }


        //***************DISPLAY EMPLOYEE TABLE***************// //***************DISPLAY EMPLOYEE TABLE***************//

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel1_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelRemove_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel9_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel7_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

    }
}
