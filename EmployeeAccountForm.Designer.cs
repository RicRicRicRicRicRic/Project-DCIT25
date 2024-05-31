namespace CoffeeShop
{
    partial class EmployeeAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAccountForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.textBoxAccountIDdisplay = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabelAccountID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHireDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCustomers = new System.Windows.Forms.TextBox();
            this.labelEmployeeRole = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxEmployeeRole = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EmployeePicture = new System.Windows.Forms.PictureBox();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.Barpanel = new System.Windows.Forms.Panel();
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).BeginInit();
            this.LoadingPanel.SuspendLayout();
            this.Barpanel.SuspendLayout();
            this.LoadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackColor = System.Drawing.Color.OldLace;
            this.MainPanel.Controls.Add(this.LoadingPanel);
            this.MainPanel.Controls.Add(this.panel5);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainPanel.Size = new System.Drawing.Size(1320, 828);
            this.MainPanel.TabIndex = 16;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DesktopPanel_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.LogOutButton);
            this.panel5.Controls.Add(this.textBoxAccountIDdisplay);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(60, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1200, 709);
            this.panel5.TabIndex = 17;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(60, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 39);
            this.panel2.TabIndex = 94;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 37);
            this.label6.TabIndex = 92;
            this.label6.Text = "Employee Data";
            // 
            // LogOutButton
            // 
            this.LogOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogOutButton.BackColor = System.Drawing.Color.IndianRed;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogOutButton.FlatAppearance.BorderSize = 2;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOutButton.Location = new System.Drawing.Point(936, 504);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(180, 56);
            this.LogOutButton.TabIndex = 58;
            this.LogOutButton.Text = "LOG OUT";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // textBoxAccountIDdisplay
            // 
            this.textBoxAccountIDdisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccountIDdisplay.Location = new System.Drawing.Point(243, 128);
            this.textBoxAccountIDdisplay.Name = "textBoxAccountIDdisplay";
            this.textBoxAccountIDdisplay.ReadOnly = true;
            this.textBoxAccountIDdisplay.Size = new System.Drawing.Size(294, 42);
            this.textBoxAccountIDdisplay.TabIndex = 78;
            this.textBoxAccountIDdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.LabelAccountID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBoxHireDate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxRevenue);
            this.panel4.Location = new System.Drawing.Point(240, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 231);
            this.panel4.TabIndex = 97;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // LabelAccountID
            // 
            this.LabelAccountID.AutoSize = true;
            this.LabelAccountID.BackColor = System.Drawing.Color.Transparent;
            this.LabelAccountID.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountID.ForeColor = System.Drawing.Color.Black;
            this.LabelAccountID.Location = new System.Drawing.Point(6, 5);
            this.LabelAccountID.Name = "LabelAccountID";
            this.LabelAccountID.Size = new System.Drawing.Size(179, 37);
            this.LabelAccountID.TabIndex = 69;
            this.LabelAccountID.Text = ":Account ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 71;
            this.label1.Text = ":Date Hired";
            // 
            // textBoxHireDate
            // 
            this.textBoxHireDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHireDate.Location = new System.Drawing.Point(3, 115);
            this.textBoxHireDate.Name = "textBoxHireDate";
            this.textBoxHireDate.ReadOnly = true;
            this.textBoxHireDate.Size = new System.Drawing.Size(294, 42);
            this.textBoxHireDate.TabIndex = 86;
            this.textBoxHireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 37);
            this.label4.TabIndex = 88;
            this.label4.Text = ":Revenue Made";
            // 
            // textBoxRevenue
            // 
            this.textBoxRevenue.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRevenue.Location = new System.Drawing.Point(3, 189);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.ReadOnly = true;
            this.textBoxRevenue.Size = new System.Drawing.Size(294, 42);
            this.textBoxRevenue.TabIndex = 91;
            this.textBoxRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxCustomers);
            this.panel1.Controls.Add(this.labelEmployeeRole);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBoxEmployeeRole);
            this.panel1.Controls.Add(this.textBoxSalary);
            this.panel1.Location = new System.Drawing.Point(840, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 231);
            this.panel1.TabIndex = 97;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 37);
            this.label5.TabIndex = 90;
            this.label5.Text = ":Customers Served";
            // 
            // textBoxCustomers
            // 
            this.textBoxCustomers.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomers.Location = new System.Drawing.Point(3, 189);
            this.textBoxCustomers.Name = "textBoxCustomers";
            this.textBoxCustomers.ReadOnly = true;
            this.textBoxCustomers.Size = new System.Drawing.Size(294, 42);
            this.textBoxCustomers.TabIndex = 93;
            this.textBoxCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelEmployeeRole
            // 
            this.labelEmployeeRole.AutoSize = true;
            this.labelEmployeeRole.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeRole.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeeRole.Location = new System.Drawing.Point(6, 80);
            this.labelEmployeeRole.Name = "labelEmployeeRole";
            this.labelEmployeeRole.Size = new System.Drawing.Size(232, 37);
            this.labelEmployeeRole.TabIndex = 66;
            this.labelEmployeeRole.Text = ":Employee Role";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(3, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(243, 37);
            this.label.TabIndex = 72;
            this.label.Text = ":Salary Per Hour";
            // 
            // textBoxEmployeeRole
            // 
            this.textBoxEmployeeRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeRole.Location = new System.Drawing.Point(3, 115);
            this.textBoxEmployeeRole.Name = "textBoxEmployeeRole";
            this.textBoxEmployeeRole.ReadOnly = true;
            this.textBoxEmployeeRole.Size = new System.Drawing.Size(294, 42);
            this.textBoxEmployeeRole.TabIndex = 83;
            this.textBoxEmployeeRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(3, 40);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(294, 42);
            this.textBoxSalary.TabIndex = 80;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labelEmployeeName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxProducts);
            this.panel3.Controls.Add(this.textBoxEmployeeName);
            this.panel3.Controls.Add(this.textBoxEmployeeID);
            this.panel3.Location = new System.Drawing.Point(540, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 231);
            this.panel3.TabIndex = 96;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 37);
            this.label3.TabIndex = 73;
            this.label3.Text = ":Employee ID";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeeName.Location = new System.Drawing.Point(6, 80);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(254, 37);
            this.labelEmployeeName.TabIndex = 65;
            this.labelEmployeeName.Text = ":Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 37);
            this.label2.TabIndex = 89;
            this.label2.Text = ":Products Sold";
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducts.Location = new System.Drawing.Point(3, 189);
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.ReadOnly = true;
            this.textBoxProducts.Size = new System.Drawing.Size(294, 42);
            this.textBoxProducts.TabIndex = 92;
            this.textBoxProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(3, 115);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.ReadOnly = true;
            this.textBoxEmployeeName.Size = new System.Drawing.Size(294, 42);
            this.textBoxEmployeeName.TabIndex = 82;
            this.textBoxEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(3, 40);
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.ReadOnly = true;
            this.textBoxEmployeeID.Size = new System.Drawing.Size(294, 42);
            this.textBoxEmployeeID.TabIndex = 79;
            this.textBoxEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Bisque;
            this.panel6.Controls.Add(this.EmployeePicture);
            this.panel6.Location = new System.Drawing.Point(60, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 231);
            this.panel6.TabIndex = 98;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // EmployeePicture
            // 
            this.EmployeePicture.BackColor = System.Drawing.Color.IndianRed;
            this.EmployeePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeePicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("EmployeePicture.ErrorImage")));
            this.EmployeePicture.Image = ((System.Drawing.Image)(resources.GetObject("EmployeePicture.Image")));
            this.EmployeePicture.Location = new System.Drawing.Point(2, 0);
            this.EmployeePicture.Name = "EmployeePicture";
            this.EmployeePicture.Size = new System.Drawing.Size(178, 178);
            this.EmployeePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeePicture.TabIndex = 64;
            this.EmployeePicture.TabStop = false;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 15;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick_1);
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LoadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadingPanel.Controls.Add(this.Barpanel);
            this.LoadingPanel.Controls.Add(this.pictureBox4);
            this.LoadingPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoadingPanel.Size = new System.Drawing.Size(1320, 828);
            this.LoadingPanel.TabIndex = 39;
            this.LoadingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadingPanel_Paint);
            // 
            // Barpanel
            // 
            this.Barpanel.BackColor = System.Drawing.Color.DimGray;
            this.Barpanel.Controls.Add(this.LoadPanel);
            this.Barpanel.Location = new System.Drawing.Point(423, 600);
            this.Barpanel.Name = "Barpanel";
            this.Barpanel.Size = new System.Drawing.Size(474, 50);
            this.Barpanel.TabIndex = 3;
            // 
            // LoadPanel
            // 
            this.LoadPanel.BackColor = System.Drawing.Color.Lime;
            this.LoadPanel.Controls.Add(this.label7);
            this.LoadPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(474, 50);
            this.LoadPanel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(157, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 50);
            this.label7.TabIndex = 5;
            this.label7.Text = "LOADING";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(453, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(414, 416);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // EmployeeAccountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1320, 828);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeAccountForm";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeePicture)).EndInit();
            this.LoadingPanel.ResumeLayout(false);
            this.Barpanel.ResumeLayout(false);
            this.LoadPanel.ResumeLayout(false);
            this.LoadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.PictureBox EmployeePicture;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label LabelAccountID;
        private System.Windows.Forms.Label labelEmployeeRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAccountIDdisplay;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeRole;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHireDate;
        private System.Windows.Forms.TextBox textBoxCustomers;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.Panel Barpanel;
        private System.Windows.Forms.Panel LoadPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}