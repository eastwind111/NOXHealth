
namespace NOXHealth
{
    partial class RegisterForm
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
            this.lblBacktoLogin = new System.Windows.Forms.Label();
            this.lblHaveAcc = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblBacktoLogin
            // 
            this.lblBacktoLogin.AutoSize = true;
            this.lblBacktoLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblBacktoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBacktoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBacktoLogin.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBacktoLogin.ForeColor = System.Drawing.Color.Teal;
            this.lblBacktoLogin.Location = new System.Drawing.Point(323, 643);
            this.lblBacktoLogin.Name = "lblBacktoLogin";
            this.lblBacktoLogin.Size = new System.Drawing.Size(99, 19);
            this.lblBacktoLogin.TabIndex = 21;
            this.lblBacktoLogin.Text = "Back to Login";
            this.lblBacktoLogin.Click += new System.EventHandler(this.lblBacktoLogin_Click);
            // 
            // lblHaveAcc
            // 
            this.lblHaveAcc.AutoSize = true;
            this.lblHaveAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblHaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHaveAcc.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHaveAcc.ForeColor = System.Drawing.Color.Gray;
            this.lblHaveAcc.Location = new System.Drawing.Point(279, 620);
            this.lblHaveAcc.Name = "lblHaveAcc";
            this.lblHaveAcc.Size = new System.Drawing.Size(185, 19);
            this.lblHaveAcc.TabIndex = 22;
            this.lblHaveAcc.Text = "Already Have an Account?";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPassword.Font = new System.Drawing.Font("Geomanist Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.cbShowPassword.Location = new System.Drawing.Point(213, 389);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(131, 23);
            this.cbShowPassword.TabIndex = 20;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Mont Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(41, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(664, 49);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPassword.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(45, 239);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.LightGray;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(43, 266);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(301, 35);
            this.tbPassword.TabIndex = 17;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(43, 167);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 21);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Teal;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Mont Book", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(43, 454);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(662, 49);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.BackColor = System.Drawing.Color.Transparent;
            this.lblGetStarted.Font = new System.Drawing.Font("Geomanist Book", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetStarted.ForeColor = System.Drawing.Color.Teal;
            this.lblGetStarted.Location = new System.Drawing.Point(34, 62);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(342, 59);
            this.lblGetStarted.TabIndex = 13;
            this.lblGetStarted.Text = "Get Started";
            this.lblGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.LightGray;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(43, 191);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(301, 35);
            this.tbUsername.TabIndex = 14;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.LightGray;
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmPassword.Location = new System.Drawing.Point(43, 348);
            this.tbConfirmPassword.Multiline = true;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '●';
            this.tbConfirmPassword.Size = new System.Drawing.Size(301, 35);
            this.tbConfirmPassword.TabIndex = 17;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(45, 321);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(146, 21);
            this.lblConfirmPassword.TabIndex = 18;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWeight.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeight.ForeColor = System.Drawing.Color.Gray;
            this.lblWeight.Location = new System.Drawing.Point(562, 322);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(102, 21);
            this.lblWeight.TabIndex = 30;
            this.lblWeight.Text = "Weight  (Kg)";
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.Color.LightGray;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeight.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbWeight.Location = new System.Drawing.Point(562, 348);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbWeight.Multiline = true;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(141, 35);
            this.tbWeight.TabIndex = 29;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeight.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeight.ForeColor = System.Drawing.Color.Gray;
            this.lblHeight.Location = new System.Drawing.Point(402, 322);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(135, 21);
            this.lblHeight.TabIndex = 28;
            this.lblHeight.Text = "Height   (Meters)";
            // 
            // tbHeight
            // 
            this.tbHeight.BackColor = System.Drawing.Color.LightGray;
            this.tbHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeight.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbHeight.Location = new System.Drawing.Point(402, 348);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbHeight.Multiline = true;
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(135, 35);
            this.tbHeight.TabIndex = 27;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAge.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.Gray;
            this.lblAge.Location = new System.Drawing.Point(402, 240);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 21);
            this.lblAge.TabIndex = 26;
            this.lblAge.Text = "Age";
            // 
            // tbAge
            // 
            this.tbAge.BackColor = System.Drawing.Color.LightGray;
            this.tbAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAge.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAge.Location = new System.Drawing.Point(402, 266);
            this.tbAge.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbAge.Multiline = true;
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(301, 35);
            this.tbAge.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(404, 165);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.LightGray;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Geomanist Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbName.Location = new System.Drawing.Point(404, 191);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 35);
            this.tbName.TabIndex = 23;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.LightGray;
            this.pnlLine.Location = new System.Drawing.Point(373, 165);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(3, 245);
            this.pnlLine.TabIndex = 33;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 720);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblBacktoLogin);
            this.Controls.Add(this.lblHaveAcc);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblGetStarted);
            this.Controls.Add(this.tbUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBacktoLogin;
        private System.Windows.Forms.Label lblHaveAcc;
        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pnlLine;
    }
}