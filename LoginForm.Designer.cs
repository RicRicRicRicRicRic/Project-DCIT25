namespace CoffeeShop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtboxUserName = new System.Windows.Forms.TextBox();
            this.txtboxUserPassword = new System.Windows.Forms.TextBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.Clearbttn = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPlaceholderPassword = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPlaceholderName = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.labelEmporAd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxUserName
            // 
            this.txtboxUserName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtboxUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUserName.Location = new System.Drawing.Point(523, 328);
            this.txtboxUserName.Name = "txtboxUserName";
            this.txtboxUserName.Size = new System.Drawing.Size(490, 46);
            this.txtboxUserName.TabIndex = 13;
            this.txtboxUserName.TextChanged += new System.EventHandler(this.txtboxUserName_TextChanged);
            // 
            // txtboxUserPassword
            // 
            this.txtboxUserPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtboxUserPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUserPassword.Location = new System.Drawing.Point(523, 422);
            this.txtboxUserPassword.Name = "txtboxUserPassword";
            this.txtboxUserPassword.Size = new System.Drawing.Size(490, 46);
            this.txtboxUserPassword.TabIndex = 16;
            this.txtboxUserPassword.UseSystemPasswordChar = true;
            this.txtboxUserPassword.TextChanged += new System.EventHandler(this.txtboxUserPassword_TextChanged);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Wingdings 2", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Location = new System.Drawing.Point(1, -5);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(38, 45);
            this.Close_Button.TabIndex = 17;
            this.Close_Button.Text = "S";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.Close_Button);
            this.panel2.Location = new System.Drawing.Point(1499, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 37);
            this.panel2.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdmin.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdmin.FlatAppearance.BorderSize = 2;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(766, 645);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(245, 56);
            this.buttonAdmin.TabIndex = 49;
            this.buttonAdmin.Text = "ADMIN";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1536, 864);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmployee.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEmployee.FlatAppearance.BorderSize = 2;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmployee.Location = new System.Drawing.Point(523, 645);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(245, 56);
            this.buttonEmployee.TabIndex = 50;
            this.buttonEmployee.Text = "EMPLOYEE";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // Clearbttn
            // 
            this.Clearbttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Clearbttn.BackColor = System.Drawing.Color.Crimson;
            this.Clearbttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clearbttn.FlatAppearance.BorderSize = 2;
            this.Clearbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbttn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clearbttn.Location = new System.Drawing.Point(766, 521);
            this.Clearbttn.Name = "Clearbttn";
            this.Clearbttn.Size = new System.Drawing.Size(160, 56);
            this.Clearbttn.TabIndex = 51;
            this.Clearbttn.Text = "CLEAR";
            this.Clearbttn.UseVisualStyleBackColor = false;
            this.Clearbttn.Click += new System.EventHandler(this.Clearbttn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelName.Location = new System.Drawing.Point(517, 294);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 31);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "User ID";
            // 
            // labelPlaceholderPassword
            // 
            this.labelPlaceholderPassword.AutoSize = true;
            this.labelPlaceholderPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaceholderPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholderPassword.ForeColor = System.Drawing.Color.Silver;
            this.labelPlaceholderPassword.Location = new System.Drawing.Point(530, 426);
            this.labelPlaceholderPassword.Name = "labelPlaceholderPassword";
            this.labelPlaceholderPassword.Size = new System.Drawing.Size(234, 37);
            this.labelPlaceholderPassword.TabIndex = 56;
            this.labelPlaceholderPassword.Text = "Enter Password";
            this.labelPlaceholderPassword.Click += new System.EventHandler(this.labelPlaceholderPassword_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.FlatAppearance.BorderSize = 2;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(523, 521);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(160, 56);
            this.LoginButton.TabIndex = 57;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelPassword.Location = new System.Drawing.Point(517, 388);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(124, 31);
            this.labelPassword.TabIndex = 58;
            this.labelPassword.Text = "Password";
            // 
            // labelPlaceholderName
            // 
            this.labelPlaceholderName.AutoSize = true;
            this.labelPlaceholderName.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaceholderName.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholderName.ForeColor = System.Drawing.Color.Silver;
            this.labelPlaceholderName.Location = new System.Drawing.Point(530, 332);
            this.labelPlaceholderName.Name = "labelPlaceholderName";
            this.labelPlaceholderName.Size = new System.Drawing.Size(202, 37);
            this.labelPlaceholderName.TabIndex = 59;
            this.labelPlaceholderName.Text = "Enter User ID";
            this.labelPlaceholderName.Click += new System.EventHandler(this.labelPlaceholderName_Click);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.checkBoxPassword.Location = new System.Drawing.Point(523, 466);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(208, 34);
            this.checkBoxPassword.TabIndex = 61;
            this.checkBoxPassword.Text = "Show Password";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // labelEmporAd
            // 
            this.labelEmporAd.AutoSize = true;
            this.labelEmporAd.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmporAd.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelEmporAd.Location = new System.Drawing.Point(517, 612);
            this.labelEmporAd.Name = "labelEmporAd";
            this.labelEmporAd.Size = new System.Drawing.Size(233, 31);
            this.labelEmporAd.TabIndex = 62;
            this.labelEmporAd.Text = "Select a Login type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1256, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 92);
            this.button1.TabIndex = 63;
            this.button1.Text = "INSTA LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1215, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 92);
            this.button2.TabIndex = 64;
            this.button2.Text = "INSTA LOGIN ADMIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1536, 864);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEmporAd);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.labelPlaceholderName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.labelPlaceholderPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Clearbttn);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtboxUserPassword);
            this.Controls.Add(this.txtboxUserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxUserName;
        private System.Windows.Forms.TextBox txtboxUserPassword;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button Clearbttn;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPlaceholderPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPlaceholderName;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label labelEmporAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}