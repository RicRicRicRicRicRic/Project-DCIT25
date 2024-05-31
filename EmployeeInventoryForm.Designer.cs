namespace CoffeeShop
{
    partial class EmployeeInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInventoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.LoadingPanel = new System.Windows.Forms.Panel();
            this.Barpanel = new System.Windows.Forms.Panel();
            this.LoadPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InverntoryDGV = new System.Windows.Forms.DataGridView();
            this.Foodbutton = new System.Windows.Forms.Button();
            this.HCoffeebutton = new System.Windows.Forms.Button();
            this.ColdCoffeebutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.DesktopPanel.SuspendLayout();
            this.LoadingPanel.SuspendLayout();
            this.Barpanel.SuspendLayout();
            this.LoadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InverntoryDGV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.OldLace;
            this.DesktopPanel.Controls.Add(this.LoadingPanel);
            this.DesktopPanel.Controls.Add(this.panel5);
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DesktopPanel.Size = new System.Drawing.Size(1320, 828);
            this.DesktopPanel.TabIndex = 14;
            this.DesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DesktopPanel_Paint);
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
            this.LoadingPanel.TabIndex = 40;
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
            this.LoadPanel.Controls.Add(this.label4);
            this.LoadPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Size = new System.Drawing.Size(474, 50);
            this.LoadPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(157, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOADING";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.Foodbutton);
            this.panel5.Controls.Add(this.HCoffeebutton);
            this.panel5.Controls.Add(this.ColdCoffeebutton);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(60, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1200, 709);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.OrderDGV);
            this.panel4.Location = new System.Drawing.Point(30, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 293);
            this.panel4.TabIndex = 83;
            // 
            // OrderDGV
            // 
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderDGV.Location = new System.Drawing.Point(0, 0);
            this.OrderDGV.Name = "OrderDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDGV.RowHeadersWidth = 51;
            this.OrderDGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderDGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDGV.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.OrderDGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.RowTemplate.Height = 24;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(1140, 293);
            this.OrderDGV.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(30, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 39);
            this.panel2.TabIndex = 83;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(906, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 33);
            this.dateTimePicker.TabIndex = 81;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(664, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 31);
            this.label7.TabIndex = 82;
            this.label7.Text = "Select Date of Order";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 31);
            this.label3.TabIndex = 86;
            this.label3.Text = "Order Records";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.InverntoryDGV);
            this.panel1.Location = new System.Drawing.Point(30, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 279);
            this.panel1.TabIndex = 0;
            // 
            // InverntoryDGV
            // 
            this.InverntoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InverntoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InverntoryDGV.BackgroundColor = System.Drawing.Color.OldLace;
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
            this.InverntoryDGV.Size = new System.Drawing.Size(1140, 279);
            this.InverntoryDGV.TabIndex = 81;
            // 
            // Foodbutton
            // 
            this.Foodbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Foodbutton.BackColor = System.Drawing.Color.SaddleBrown;
            this.Foodbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Foodbutton.FlatAppearance.BorderSize = 2;
            this.Foodbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Foodbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Foodbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Foodbutton.Location = new System.Drawing.Point(30, 30);
            this.Foodbutton.Name = "Foodbutton";
            this.Foodbutton.Size = new System.Drawing.Size(160, 40);
            this.Foodbutton.TabIndex = 59;
            this.Foodbutton.Text = "FOOD";
            this.Foodbutton.UseVisualStyleBackColor = false;
            this.Foodbutton.Click += new System.EventHandler(this.Foodbutton_Click);
            // 
            // HCoffeebutton
            // 
            this.HCoffeebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HCoffeebutton.BackColor = System.Drawing.Color.SaddleBrown;
            this.HCoffeebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HCoffeebutton.FlatAppearance.BorderSize = 2;
            this.HCoffeebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HCoffeebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HCoffeebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HCoffeebutton.Location = new System.Drawing.Point(188, 30);
            this.HCoffeebutton.Name = "HCoffeebutton";
            this.HCoffeebutton.Size = new System.Drawing.Size(160, 40);
            this.HCoffeebutton.TabIndex = 79;
            this.HCoffeebutton.Text = "HOT COFFEE";
            this.HCoffeebutton.UseVisualStyleBackColor = false;
            this.HCoffeebutton.Click += new System.EventHandler(this.HCoffeebutton_Click);
            // 
            // ColdCoffeebutton
            // 
            this.ColdCoffeebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ColdCoffeebutton.BackColor = System.Drawing.Color.SaddleBrown;
            this.ColdCoffeebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ColdCoffeebutton.FlatAppearance.BorderSize = 2;
            this.ColdCoffeebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColdCoffeebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColdCoffeebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ColdCoffeebutton.Location = new System.Drawing.Point(346, 30);
            this.ColdCoffeebutton.Name = "ColdCoffeebutton";
            this.ColdCoffeebutton.Size = new System.Drawing.Size(160, 40);
            this.ColdCoffeebutton.TabIndex = 80;
            this.ColdCoffeebutton.Text = "COLD COFFEE";
            this.ColdCoffeebutton.UseVisualStyleBackColor = false;
            this.ColdCoffeebutton.Click += new System.EventHandler(this.ColdCoffeebutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(504, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 38);
            this.panel3.TabIndex = 84;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(449, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 85;
            this.label2.Text = "Product Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 15;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // EmployeeInventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1320, 828);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeInventoryForm";
            this.Load += new System.EventHandler(this.InventoryEmployeeForm_Load);
            this.DesktopPanel.ResumeLayout(false);
            this.LoadingPanel.ResumeLayout(false);
            this.Barpanel.ResumeLayout(false);
            this.LoadPanel.ResumeLayout(false);
            this.LoadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InverntoryDGV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button ColdCoffeebutton;
        private System.Windows.Forms.Button HCoffeebutton;
        private System.Windows.Forms.Button Foodbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InverntoryDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Panel LoadingPanel;
        private System.Windows.Forms.Panel Barpanel;
        private System.Windows.Forms.Panel LoadPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}