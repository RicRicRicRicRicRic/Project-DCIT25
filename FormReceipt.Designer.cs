namespace CoffeeShop
{
    partial class FormReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.textBoxTotalItems = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCustNum = new System.Windows.Forms.TextBox();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptdgv = new System.Windows.Forms.DataGridView();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintSavebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCashier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(173, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 50);
            this.label1.TabIndex = 29;
            this.label1.Text = "RECEIPT";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.MintCream;
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(599, 182);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(202, 30);
            this.textBoxAmount.TabIndex = 30;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // textBoxChange
            // 
            this.textBoxChange.BackColor = System.Drawing.Color.MintCream;
            this.textBoxChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChange.Location = new System.Drawing.Point(848, 182);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.ReadOnly = true;
            this.textBoxChange.Size = new System.Drawing.Size(202, 30);
            this.textBoxChange.TabIndex = 31;
            this.textBoxChange.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // textBoxRevenue
            // 
            this.textBoxRevenue.BackColor = System.Drawing.Color.MintCream;
            this.textBoxRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRevenue.Location = new System.Drawing.Point(599, 272);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.ReadOnly = true;
            this.textBoxRevenue.Size = new System.Drawing.Size(202, 30);
            this.textBoxRevenue.TabIndex = 32;
            this.textBoxRevenue.TextChanged += new System.EventHandler(this.textBoxRevenue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(594, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 27);
            this.label4.TabIndex = 33;
            this.label4.Text = "AMMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(843, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "CHANGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(594, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 36;
            this.label5.Text = "REVENUE";
            // 
            // Save_button
            // 
            this.Save_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Save_button.FlatAppearance.BorderSize = 2;
            this.Save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save_button.Location = new System.Drawing.Point(600, 640);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(203, 66);
            this.Save_button.TabIndex = 37;
            this.Save_button.Text = "SAVE TO DATABASE";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // textBoxTotalItems
            // 
            this.textBoxTotalItems.BackColor = System.Drawing.Color.MintCream;
            this.textBoxTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalItems.Location = new System.Drawing.Point(848, 272);
            this.textBoxTotalItems.Name = "textBoxTotalItems";
            this.textBoxTotalItems.ReadOnly = true;
            this.textBoxTotalItems.Size = new System.Drawing.Size(202, 30);
            this.textBoxTotalItems.TabIndex = 40;
            this.textBoxTotalItems.TextChanged += new System.EventHandler(this.textBoxTotalItems_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(594, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "TOTAL CUSTOMER";
            // 
            // textBoxCustNum
            // 
            this.textBoxCustNum.BackColor = System.Drawing.Color.MintCream;
            this.textBoxCustNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustNum.Location = new System.Drawing.Point(599, 364);
            this.textBoxCustNum.Name = "textBoxCustNum";
            this.textBoxCustNum.ReadOnly = true;
            this.textBoxCustNum.Size = new System.Drawing.Size(89, 34);
            this.textBoxCustNum.TabIndex = 44;
            this.textBoxCustNum.TextChanged += new System.EventHandler(this.textBoxCustNum_TextChanged);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Red;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(751, 362);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(50, 36);
            this.buttonMinus.TabIndex = 45;
            this.buttonMinus.Text = "-";
            this.buttonMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(695, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 36);
            this.buttonAdd.TabIndex = 46;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.receiptdgv);
            this.panel1.Location = new System.Drawing.Point(45, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 644);
            this.panel1.TabIndex = 48;
            // 
            // receiptdgv
            // 
            this.receiptdgv.AllowUserToAddRows = false;
            this.receiptdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.receiptdgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.receiptdgv.ColumnHeadersHeight = 40;
            this.receiptdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductColumn,
            this.PriceColumn,
            this.QuantityColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptdgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.receiptdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptdgv.Location = new System.Drawing.Point(0, 0);
            this.receiptdgv.Name = "receiptdgv";
            this.receiptdgv.ReadOnly = true;
            this.receiptdgv.RowHeadersWidth = 51;
            this.receiptdgv.RowTemplate.Height = 24;
            this.receiptdgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiptdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receiptdgv.Size = new System.Drawing.Size(447, 644);
            this.receiptdgv.TabIndex = 26;
            this.receiptdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptdgv_CellContentClick);
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Product";
            this.ProductColumn.MinimumWidth = 6;
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            this.ProductColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 125;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.MinimumWidth = 6;
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 125;
            // 
            // PrintSavebutton
            // 
            this.PrintSavebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrintSavebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintSavebutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PrintSavebutton.FlatAppearance.BorderSize = 2;
            this.PrintSavebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintSavebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintSavebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintSavebutton.Location = new System.Drawing.Point(848, 640);
            this.PrintSavebutton.Name = "PrintSavebutton";
            this.PrintSavebutton.Size = new System.Drawing.Size(203, 66);
            this.PrintSavebutton.TabIndex = 49;
            this.PrintSavebutton.Text = "PRINT AND SAVE TO DATABASE";
            this.PrintSavebutton.UseVisualStyleBackColor = false;
            this.PrintSavebutton.Click += new System.EventHandler(this.PrintSavebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(843, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "TOTAL ITEMS";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(598, 458);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(374, 33);
            this.dateTimePicker.TabIndex = 50;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(594, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 27);
            this.label2.TabIndex = 54;
            this.label2.Text = "DATE OF PURCHASE";
            // 
            // textBoxCashier
            // 
            this.textBoxCashier.BackColor = System.Drawing.Color.MintCream;
            this.textBoxCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCashier.Location = new System.Drawing.Point(707, 62);
            this.textBoxCashier.Name = "textBoxCashier";
            this.textBoxCashier.Size = new System.Drawing.Size(202, 30);
            this.textBoxCashier.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(595, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 27);
            this.label8.TabIndex = 58;
            this.label8.Text = "CASHIER:";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 789);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCashier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.PrintSavebutton);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.textBoxCustNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTotalItems);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRevenue);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceipt";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receiptdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBoxTotalItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCustNum;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintSavebutton;
        private System.Windows.Forms.DataGridView receiptdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCashier;
        private System.Windows.Forms.Label label8;
    }
}