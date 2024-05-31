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
using System.Xml;
using System.IO;

namespace CoffeeShop
{
    public partial class AdminManageEmpForm : Form
    {
        private string connectionString = @"Data Source=LAPTOP-9G51TSSI\SQLEXPRESS;Initial Catalog=DatabaseForCoffeeShop;Integrated Security=True;";
        public AdminManageEmpForm()
        {
            InitializeComponent();
            FillEmployeeDGV();
        }

        private void AdminManageEmpForm_Load(object sender, EventArgs e)
        {
            ClrSelectTimer.Start();
            DisplayComboBoxItems();
        }
        private void ClrSelectTimer_Tick(object sender, EventArgs e)
        {
            ClrSelectTimer.Stop();
            EmployeeDGV.ClearSelection();
        }

        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

        private void DrawPanelBorder(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            int penThickness = 2;
            Pen borderPen = new Pen(Color.Black, penThickness);
            Rectangle rect = new Rectangle(penThickness / 2, penThickness / 2, panel.Width - penThickness, panel.Height - penThickness);
            e.Graphics.DrawRectangle(borderPen, rect);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e);}
        private void DesktopPanel_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e);}
        private void panel4_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panelRemove_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel8_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel7_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel6_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel2_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel3_Paint_1(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel9_Paint_1(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        private void panel11_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }

        private void panel12_Paint(object sender, PaintEventArgs e) { DrawPanelBorder(sender, e); }
        //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************// //***************PANEL DESIGNER***************////***************PANEL DESIGNER***************//

        //***************SELECT EMPLOYEE ID COMBO BOX***************// //***************SELECT EMPLOYEE ID COMBO BOX***************//
        private void EmpIDSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployeeID = EmpIDSearchComboBox.SelectedItem.ToString();
            CurrentEmpIDTextBox.Text = selectedEmployeeID;
            NewEmpIDTextBox.Text = selectedEmployeeID;

            EmployeeProfilePictureDisplay();
            CurrentEmployeeData();
        }
        private void CurrentEmployeeData() 
        {
            string employeeID = CurrentEmpIDTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Employee.EmployeeName, Employee.SalaryPerHour, Employee.EmployeeRole, Employee.EmployeeHireDate, Account.AccountID " +
                    "FROM Employee LEFT JOIN Account ON Employee.EmployeeID = Account.EmployeeID " +
                    "WHERE Employee.EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CNEmpTextBox.Text = reader["EmployeeName"].ToString();
                    CSETextBox.Text = reader["SalaryPerHour"].ToString();
                    CRETextBox.Text = reader["EmployeeRole"].ToString();
                    CDHETextBox.Text = ((DateTime)reader["EmployeeHireDate"]).ToString("yyyy-MM-dd");

                    if (reader["AccountID"] != DBNull.Value)
                    {
                        CAIDETextBox.Text = reader["AccountID"].ToString();
                        NewCAIDETextBox.Text = reader["AccountID"].ToString();
                    }
                    else
                    {
                        CAIDETextBox.Text = "EMPLOYEE HAS NO ACCOUNT";
                        NewCAIDETextBox.Text = "EMPLOYEE HAS NO ACCOUNT";
                    }
                }
                else
                {
        
                    CNEmpTextBox.Text = "NO DATA FOUND";
                    CSETextBox.Text = "NO DATA FOUND";
                    CRETextBox.Text = "NO DATA FOUND";
                    CDHETextBox.Text = "NO DATA FOUND";
                }

                reader.Close();
                connection.Close();
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
                        EmpPfppicturebox.Image = DefaultPFPpictureBox.Image;
                    }
                }
                else
                {
                    EmpPfppicturebox.Image = DefaultPFPpictureBox.Image;
                }
                connection.Close();
            }
        }
        //***************SELECT EMPLOYEE ID COMBO BOX***************// //***************SELECT EMPLOYEE ID COMBO BOX***************//

        //***************UPDATE EMPLOYEE INFROMATION***************//  //***************UPDATE EMPLOYEE INFROMATION***************//

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            DialogResult yesORno = MessageBox.Show("Are you sure you want to clear the new emplyee data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesORno == DialogResult.Yes)
            {
                NewCNEmpTextBox.Clear();
                NewCSETextBox.Clear();
                RoleComboBox.SelectedIndex = -1;
                HiredateTimePicker.Value = DateTime.Now.Date;
                PFPCHeckerTextBox.Clear();
                NewPFPpictureBox.Image = DefaultPFPpictureBox.Image;

                panel10.Visible = true;
            }
        }

        private void UpdateEMP_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CurrentEmpIDTextBox.Text))
            {
                MessageBox.Show("Please choose an employee from the combobox", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                NewEmployeeData();
                if(!string.IsNullOrWhiteSpace(PFPCHeckerTextBox.Text))
                {
                    UpdateEmployeePicture();
                }
            }
        }

        private void NewEmployeeData()
        {
            DialogResult yesORno = MessageBox.Show("Are you sure you want to update employee data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yesORno == DialogResult.Yes)
            {
                string employeeID = NewEmpIDTextBox.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Employee " +
                        "SET EmployeeName = @EmployeeName, " +
                        "SalaryPerHour = @SalaryPerHour, " +
                        "EmployeeRole = @EmployeeRole, " +
                        "EmployeeHireDate = @EmployeeHireDate " +
                        "WHERE EmployeeID = @EmployeeID", connection);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    //Employee Name
                    if (!string.IsNullOrWhiteSpace(NewCNEmpTextBox.Text))
                    {
                        CNEmpTextBox.ForeColor = Color.Black;
                        string employeeName = NewCNEmpTextBox.Text;
                        cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                    }
                    else if (string.IsNullOrWhiteSpace(NewCNEmpTextBox.Text))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeName", CNEmpTextBox.Text);
                    }

                    //Employee Slary Per Hour
                    decimal salaryPerHour;
                    if (!string.IsNullOrWhiteSpace(NewCSETextBox.Text))
                    {
                        NewCSETextBox.ForeColor = Color.Black;
                        salaryPerHour = Convert.ToDecimal(NewCSETextBox.Text);
                        cmd.Parameters.AddWithValue("@SalaryPerHour", salaryPerHour);
                    }
                    else if (string.IsNullOrWhiteSpace(NewCSETextBox.Text))
                    {
                        NewCSETextBox.ForeColor = Color.DarkGray;
                        salaryPerHour = Convert.ToDecimal(CSETextBox.Text);
                        cmd.Parameters.AddWithValue("@SalaryPerHour", salaryPerHour);
                    }


                    //EmployeeRole
                    if (!string.IsNullOrWhiteSpace(RoleComboBox.Text))
                    {
                        RoleComboBox.ForeColor = Color.Black;
                        string employeeRole = RoleComboBox.Text;
                        cmd.Parameters.AddWithValue("@EmployeeRole", employeeRole);
                    }
                    else if (string.IsNullOrWhiteSpace(RoleComboBox.Text))
                    {
                        RoleComboBox.ForeColor = Color.DarkGray;
                        cmd.Parameters.AddWithValue("@EmployeeRole", CRETextBox.Text);
                    }


                    //EmployeeHireDate
                    if (!string.IsNullOrWhiteSpace(HiredateTextBox.Text))
                    {
                        HiredateTextBox.ForeColor = Color.Black;
                        string hireDate = HiredateTextBox.Text;
                        cmd.Parameters.AddWithValue("@EmployeeHireDate", hireDate);
                    }
                    else if (string.IsNullOrWhiteSpace(HiredateTextBox.Text))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeHireDate", CDHETextBox.Text);
                    }
                    MessageBox.Show("Employee Data is now Updated!!!", "Employee Data Succesfully updated!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void HiredateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = HiredateTimePicker.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            HiredateTextBox.Text = formattedDate;
            panel10.Visible = false;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            HiredateTimePicker.Focus();
            panel10.Visible = false;
        }
        private void Impot_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PFPCHeckerTextBox.Text = "Update Image";
                NewPFPpictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void UpdateEmployeePicture()
        {
            string employeeID = NewEmpIDTextBox.Text;

            MemoryStream ms = new MemoryStream();
            NewPFPpictureBox.Image.Save(ms, NewPFPpictureBox.Image.RawFormat);
            byte[] imageBytes = ms.ToArray();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET EmployeeImage = @EmployeeImage WHERE EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@EmployeeImage", imageBytes);

                int rowsAffected = cmd.ExecuteNonQuery();

            }
        }

        //***************UPDATE EMPLOYEE INFROMATION***************//  //***************UPDATE EMPLOYEE INFROMATION***************//

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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            EmployeeDGV.DataSource = null;
            EmployeeDGV.Rows.Clear();
            EmployeeDGV.Columns.Clear();

            EmpPfppicturebox.Image = DefaultPFPpictureBox.Image;
            CNEmpTextBox.Clear();
            CurrentEmpIDTextBox.Clear();
            CSETextBox.Clear();
            CRETextBox.Clear();
            CDHETextBox.Clear();
            CAIDETextBox.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            RefreshEmployeeData();
            CurrentEmpIDTextBox.Text = NewEmpIDTextBox.Text;
            if (!string.IsNullOrWhiteSpace(NewEmpIDTextBox.Text))
            {
                EmployeeProfilePictureDisplay();
            }
            ClrSelectTimer.Start();
            FillEmployeeDGV();
        }
        private void RefreshEmployeeData()
        {
            string employeeID = NewEmpIDTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Employee.EmployeeName, Employee.SalaryPerHour, Employee.EmployeeRole, Employee.EmployeeHireDate, Account.AccountID " +
                    "FROM Employee LEFT JOIN Account ON Employee.EmployeeID = Account.EmployeeID " +
                    "WHERE Employee.EmployeeID = @EmployeeID", connection);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CNEmpTextBox.Text = reader["EmployeeName"].ToString();
                    CSETextBox.Text = reader["SalaryPerHour"].ToString();
                    CRETextBox.Text = reader["EmployeeRole"].ToString();
                    CDHETextBox.Text = ((DateTime)reader["EmployeeHireDate"]).ToString("yyyy-MM-dd");

                    if (reader["AccountID"] != DBNull.Value)
                    {
                        CAIDETextBox.Text = reader["AccountID"].ToString();
                        NewCAIDETextBox.Text = reader["AccountID"].ToString();
                    }
                    else
                    {
                        CAIDETextBox.Text = "EMPLOYEE HAS NO ACCOUNT";
                        NewCAIDETextBox.Text = "EMPLOYEE HAS NO ACCOUNT";
                    }
                }
                else
                {

                    CNEmpTextBox.Text = "NO DATA FOUND";
                    CSETextBox.Text = "NO DATA FOUND";
                    CRETextBox.Text = "NO DATA FOUND";
                    CDHETextBox.Text = "NO DATA FOUND";
                }

                reader.Close();
                connection.Close();
            }

        }

        
        //***************DISPLAY EMPLOYEE TABLE***************// //***************DISPLAY EMPLOYEE TABLE***************//


    }

}
