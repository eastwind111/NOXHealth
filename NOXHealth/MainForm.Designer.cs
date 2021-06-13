
namespace NOXHealth
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnShop = new FontAwesome.Sharp.IconButton();
            this.btnRecipe = new FontAwesome.Sharp.IconButton();
            this.btnRec = new FontAwesome.Sharp.IconButton();
            this.btnGraph = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo2 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Teal;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.btnRecipe);
            this.panelMenu.Controls.Add(this.btnRec);
            this.panelMenu.Controls.Add(this.btnGraph);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 725);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Snow;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.Snow;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 665);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Snow;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSetting.IconColor = System.Drawing.Color.Snow;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 440);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(220, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnShop
            // 
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.ForeColor = System.Drawing.Color.Snow;
            this.btnShop.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnShop.IconColor = System.Drawing.Color.Snow;
            this.btnShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShop.IconSize = 32;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(0, 380);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShop.Size = new System.Drawing.Size(220, 60);
            this.btnShop.TabIndex = 5;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecipe.FlatAppearance.BorderSize = 0;
            this.btnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipe.ForeColor = System.Drawing.Color.Snow;
            this.btnRecipe.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnRecipe.IconColor = System.Drawing.Color.Snow;
            this.btnRecipe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecipe.IconSize = 32;
            this.btnRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipe.Location = new System.Drawing.Point(0, 320);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRecipe.Size = new System.Drawing.Size(220, 60);
            this.btnRecipe.TabIndex = 4;
            this.btnRecipe.Text = "Recipe";
            this.btnRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecipe.UseVisualStyleBackColor = true;
            this.btnRecipe.Click += new System.EventHandler(this.btnRecipe_Click);
            // 
            // btnRec
            // 
            this.btnRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.ForeColor = System.Drawing.Color.Snow;
            this.btnRec.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.btnRec.IconColor = System.Drawing.Color.Snow;
            this.btnRec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRec.IconSize = 32;
            this.btnRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRec.Location = new System.Drawing.Point(0, 260);
            this.btnRec.Name = "btnRec";
            this.btnRec.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRec.Size = new System.Drawing.Size(220, 60);
            this.btnRec.TabIndex = 3;
            this.btnRec.Text = "Recommendation";
            this.btnRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraph.FlatAppearance.BorderSize = 0;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.ForeColor = System.Drawing.Color.Snow;
            this.btnGraph.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnGraph.IconColor = System.Drawing.Color.Snow;
            this.btnGraph.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGraph.IconSize = 32;
            this.btnGraph.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.Location = new System.Drawing.Point(0, 200);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGraph.Size = new System.Drawing.Size(220, 60);
            this.btnGraph.TabIndex = 2;
            this.btnGraph.Text = "Profile";
            this.btnGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Snow;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnDashboard.IconColor = System.Drawing.Color.Snow;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLogo2);
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo2
            // 
            this.lblLogo2.AutoSize = true;
            this.lblLogo2.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo2.Font = new System.Drawing.Font("Geomanist Book", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogo2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblLogo2.Location = new System.Drawing.Point(24, 80);
            this.lblLogo2.Name = "lblLogo2";
            this.lblLogo2.Size = new System.Drawing.Size(160, 16);
            this.lblLogo2.TabIndex = 1;
            this.lblLogo2.Text = "Your Healthy Food Advisor";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogo.Font = new System.Drawing.Font("Geomanist Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Snow;
            this.lblLogo.Location = new System.Drawing.Point(17, 42);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(180, 41);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "NOX Health";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.panelTitlebar.Controls.Add(this.btnExit);
            this.panelTitlebar.Controls.Add(this.lblUsername);
            this.panelTitlebar.Controls.Add(this.lblTitleChildForm);
            this.panelTitlebar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitlebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(220, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(967, 80);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            this.panelTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(922, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Geomanist Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.LightCyan;
            this.lblUsername.Location = new System.Drawing.Point(815, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 22);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Geomanist Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.LightCyan;
            this.lblTitleChildForm.Location = new System.Drawing.Point(61, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(60, 22);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Aquamarine;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Aquamarine;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Snow;
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(967, 645);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.MouseHover += new System.EventHandler(this.panelDesktop_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Geomanist Book", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(143, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOX Health is an application that can help you live a healthier life the way you " +
    "need it.\r\nNOX Health provide healthy food recommendations based on\r\nuser informa" +
    "tion such as age, height, and weight.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Geomanist Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(144, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to NOX Health";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 725);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnShop;
        private FontAwesome.Sharp.IconButton btnRecipe;
        private FontAwesome.Sharp.IconButton btnRec;
        private FontAwesome.Sharp.IconButton btnGraph;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Label lblLogo2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}