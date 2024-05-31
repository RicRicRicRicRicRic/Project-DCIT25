namespace CoffeeShop
{
    partial class AdminInventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.PStextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OQTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.MinusComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NQtextBox = new System.Windows.Forms.TextBox();
            this.Udpate_Button = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PNtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InvComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InverntoryDGV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.ColdCoffeebutton = new System.Windows.Forms.Button();
            this.HCoffeebutton = new System.Windows.Forms.Button();
            this.Foodbutton = new System.Windows.Forms.Button();
            this.ClearFoodTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearHotTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearColdTimer = new System.Windows.Forms.Timer(this.components);
            this.RefreshTImer = new System.Windows.Forms.Timer(this.components);
            this.DesktopPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverntoryDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.DesktopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DesktopPanel.Controls.Add(this.panel4);
            this.DesktopPanel.Controls.Add(this.panel5);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DesktopPanel.Size = new System.Drawing.Size(1320, 828);
            this.DesktopPanel.TabIndex = 39;
            this.DesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DesktopPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(60, 443);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 324);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Controls.Add(this.ProductLabel);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(30, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1140, 36);
            this.panel7.TabIndex = 86;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductLabel.Location = new System.Drawing.Point(217, 2);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(109, 37);
            this.ProductLabel.TabIndex = 91;
            this.ProductLabel.Text = "- - - - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 37);
            this.label6.TabIndex = 90;
            this.label6.Text = ":Update Inventroy";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OldLace;
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(30, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1140, 229);
            this.panel6.TabIndex = 85;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel10.Controls.Add(this.PStextBox);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.OQTextbox);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(290, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(290, 229);
            this.panel10.TabIndex = 91;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // PStextBox
            // 
            this.PStextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PStextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PStextBox.Location = new System.Drawing.Point(22, 153);
            this.PStextBox.Name = "PStextBox";
            this.PStextBox.ReadOnly = true;
            this.PStextBox.Size = new System.Drawing.Size(245, 37);
            this.PStextBox.TabIndex = 96;
            this.PStextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 96;
            this.label3.Text = "Product Status";
            // 
            // OQTextbox
            // 
            this.OQTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OQTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.OQTextbox.Location = new System.Drawing.Point(22, 54);
            this.OQTextbox.Name = "OQTextbox";
            this.OQTextbox.ReadOnly = true;
            this.OQTextbox.Size = new System.Drawing.Size(245, 37);
            this.OQTextbox.TabIndex = 93;
            this.OQTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 31);
            this.label2.TabIndex = 90;
            this.label2.Text = "Current Product Quantity\r\n";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel9.Controls.Add(this.MinusComboBox);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.AddComboBox);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.NQtextBox);
            this.panel9.Controls.Add(this.Udpate_Button);
            this.panel9.Controls.Add(this.buttonMinus);
            this.panel9.Controls.Add(this.buttonAdd);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(579, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 229);
            this.panel9.TabIndex = 91;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // MinusComboBox
            // 
            this.MinusComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusComboBox.FormattingEnabled = true;
            this.MinusComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.MinusComboBox.Location = new System.Drawing.Point(365, 153);
            this.MinusComboBox.Name = "MinusComboBox";
            this.MinusComboBox.Size = new System.Drawing.Size(144, 39);
            this.MinusComboBox.TabIndex = 98;
            this.MinusComboBox.SelectedIndexChanged += new System.EventHandler(this.MinusComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(365, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 31);
            this.label8.TabIndex = 97;
            this.label8.Text = "Instant Minus";
            // 
            // AddComboBox
            // 
            this.AddComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddComboBox.FormattingEnabled = true;
            this.AddComboBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.AddComboBox.Location = new System.Drawing.Point(365, 52);
            this.AddComboBox.Name = "AddComboBox";
            this.AddComboBox.Size = new System.Drawing.Size(144, 39);
            this.AddComboBox.TabIndex = 96;
            this.AddComboBox.SelectedIndexChanged += new System.EventHandler(this.AddComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(365, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 96;
            this.label7.Text = "Instant Add";
            // 
            // NQtextBox
            // 
            this.NQtextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NQtextBox.Location = new System.Drawing.Point(42, 52);
            this.NQtextBox.Name = "NQtextBox";
            this.NQtextBox.ReadOnly = true;
            this.NQtextBox.Size = new System.Drawing.Size(245, 37);
            this.NQtextBox.TabIndex = 95;
            this.NQtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Udpate_Button
            // 
            this.Udpate_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Udpate_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Udpate_Button.BackColor = System.Drawing.Color.Indigo;
            this.Udpate_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Udpate_Button.FlatAppearance.BorderSize = 2;
            this.Udpate_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Udpate_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Udpate_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Udpate_Button.Location = new System.Drawing.Point(127, 150);
            this.Udpate_Button.Name = "Udpate_Button";
            this.Udpate_Button.Size = new System.Drawing.Size(160, 40);
            this.Udpate_Button.TabIndex = 94;
            this.Udpate_Button.Text = "Update";
            this.Udpate_Button.UseVisualStyleBackColor = false;
            this.Udpate_Button.Click += new System.EventHandler(this.Udpate_Button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Red;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(227, 93);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(50, 36);
            this.buttonMinus.TabIndex = 92;
            this.buttonMinus.Text = "-";
            this.buttonMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(181, 93);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 36);
            this.buttonAdd.TabIndex = 91;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "Change Product Quantity";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Controls.Add(this.PNtextBox);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.InvComboBox);
            this.panel8.Location = new System.Drawing.Point(1, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 229);
            this.panel8.TabIndex = 90;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // PNtextBox
            // 
            this.PNtextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNtextBox.ForeColor = System.Drawing.Color.DimGray;
            this.PNtextBox.Location = new System.Drawing.Point(22, 153);
            this.PNtextBox.Name = "PNtextBox";
            this.PNtextBox.ReadOnly = true;
            this.PNtextBox.Size = new System.Drawing.Size(245, 37);
            this.PNtextBox.TabIndex = 94;
            this.PNtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 31);
            this.label5.TabIndex = 95;
            this.label5.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 89;
            this.label4.Text = "Select Product ID\r\n";
            // 
            // InvComboBox
            // 
            this.InvComboBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvComboBox.FormattingEnabled = true;
            this.InvComboBox.Items.AddRange(new object[] {
            "PLEASE CHOOSE ",
            "PRODUCT TYPE IN ",
            "THE TABLE ABOVE FIRST"});
            this.InvComboBox.Location = new System.Drawing.Point(22, 52);
            this.InvComboBox.Name = "InvComboBox";
            this.InvComboBox.Size = new System.Drawing.Size(245, 39);
            this.InvComboBox.TabIndex = 85;
            this.InvComboBox.SelectedIndexChanged += new System.EventHandler(this.InvComboBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(60, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1200, 324);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.InverntoryDGV);
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 228);
            this.panel1.TabIndex = 2;
            // 
            // InverntoryDGV
            // 
            this.InverntoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InverntoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InverntoryDGV.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverntoryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InverntoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InverntoryDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.InverntoryDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InverntoryDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InverntoryDGV.Location = new System.Drawing.Point(0, 0);
            this.InverntoryDGV.Name = "InverntoryDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverntoryDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.InverntoryDGV.RowHeadersWidth = 51;
            this.InverntoryDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InverntoryDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InverntoryDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.InverntoryDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InverntoryDGV.RowTemplate.Height = 24;
            this.InverntoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InverntoryDGV.Size = new System.Drawing.Size(1140, 228);
            this.InverntoryDGV.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.Refresh_button);
            this.panel3.Controls.Add(this.ColdCoffeebutton);
            this.panel3.Controls.Add(this.HCoffeebutton);
            this.panel3.Controls.Add(this.Foodbutton);
            this.panel3.Location = new System.Drawing.Point(30, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 36);
            this.panel3.TabIndex = 85;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Refresh_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refresh_button.BackColor = System.Drawing.Color.Orchid;
            this.Refresh_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Refresh_button.FlatAppearance.BorderSize = 2;
            this.Refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh_button.Location = new System.Drawing.Point(1012, 0);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(126, 36);
            this.Refresh_button.TabIndex = 94;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = false;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // ColdCoffeebutton
            // 
            this.ColdCoffeebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ColdCoffeebutton.BackColor = System.Drawing.Color.Indigo;
            this.ColdCoffeebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ColdCoffeebutton.FlatAppearance.BorderSize = 2;
            this.ColdCoffeebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColdCoffeebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdCoffeebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColdCoffeebutton.Location = new System.Drawing.Point(315, 0);
            this.ColdCoffeebutton.Name = "ColdCoffeebutton";
            this.ColdCoffeebutton.Size = new System.Drawing.Size(160, 41);
            this.ColdCoffeebutton.TabIndex = 85;
            this.ColdCoffeebutton.Text = "COLD COFFEE";
            this.ColdCoffeebutton.UseVisualStyleBackColor = false;
            this.ColdCoffeebutton.Click += new System.EventHandler(this.ColdCoffeebutton_Click);
            // 
            // HCoffeebutton
            // 
            this.HCoffeebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HCoffeebutton.BackColor = System.Drawing.Color.Indigo;
            this.HCoffeebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HCoffeebutton.FlatAppearance.BorderSize = 2;
            this.HCoffeebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HCoffeebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCoffeebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HCoffeebutton.Location = new System.Drawing.Point(157, 0);
            this.HCoffeebutton.Name = "HCoffeebutton";
            this.HCoffeebutton.Size = new System.Drawing.Size(160, 41);
            this.HCoffeebutton.TabIndex = 80;
            this.HCoffeebutton.Text = "HOT COFFEE";
            this.HCoffeebutton.UseVisualStyleBackColor = false;
            this.HCoffeebutton.Click += new System.EventHandler(this.HCoffeebutton_Click);
            // 
            // Foodbutton
            // 
            this.Foodbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Foodbutton.BackColor = System.Drawing.Color.Indigo;
            this.Foodbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Foodbutton.FlatAppearance.BorderSize = 2;
            this.Foodbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Foodbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Foodbutton.Location = new System.Drawing.Point(0, 0);
            this.Foodbutton.Name = "Foodbutton";
            this.Foodbutton.Size = new System.Drawing.Size(160, 41);
            this.Foodbutton.TabIndex = 60;
            this.Foodbutton.Text = "FOOD";
            this.Foodbutton.UseVisualStyleBackColor = false;
            this.Foodbutton.Click += new System.EventHandler(this.Foodbutton_Click);
            // 
            // ClearFoodTimer
            // 
            this.ClearFoodTimer.Interval = 25;
            this.ClearFoodTimer.Tick += new System.EventHandler(this.ClearFoodTimer_Tick);
            // 
            // ClearHotTimer
            // 
            this.ClearHotTimer.Interval = 25;
            this.ClearHotTimer.Tick += new System.EventHandler(this.ClearHotTimer_Tick);
            // 
            // ClearColdTimer
            // 
            this.ClearColdTimer.Interval = 25;
            this.ClearColdTimer.Tick += new System.EventHandler(this.ClearColdTimer_Tick);
            // 
            // RefreshTImer
            // 
            this.RefreshTImer.Tick += new System.EventHandler(this.RefreshTImer_Tick);
            // 
            // AdminInventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1320, 828);
            this.Controls.Add(this.DesktopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInventoryForm";
            this.Text = "AdminInventory";
            this.Load += new System.EventHandler(this.AdminInventoryForm_Load);
            this.DesktopPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverntoryDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InverntoryDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Foodbutton;
        private System.Windows.Forms.Button HCoffeebutton;
        private System.Windows.Forms.Button ColdCoffeebutton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer ClearFoodTimer;
        private System.Windows.Forms.Timer ClearHotTimer;
        private System.Windows.Forms.Timer ClearColdTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer RefreshTImer;
        private System.Windows.Forms.ComboBox InvComboBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OQTextbox;
        private System.Windows.Forms.TextBox PStextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PNtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Button Udpate_Button;
        private System.Windows.Forms.TextBox NQtextBox;
        private System.Windows.Forms.ComboBox MinusComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AddComboBox;
        private System.Windows.Forms.Label label7;
    }
}