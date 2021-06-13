
namespace NOXHealth
{
    partial class UserDataEditForm
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
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbNewAge = new System.Windows.Forms.TextBox();
            this.tbNewHeight = new System.Windows.Forms.TextBox();
            this.tbNewWeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewAge = new System.Windows.Forms.Label();
            this.lblNewHeight = new System.Windows.Forms.Label();
            this.lblNewWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNewName
            // 
            this.tbNewName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbNewName.Location = new System.Drawing.Point(71, 133);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(235, 27);
            this.tbNewName.TabIndex = 0;
            // 
            // tbNewAge
            // 
            this.tbNewAge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbNewAge.Location = new System.Drawing.Point(71, 207);
            this.tbNewAge.Name = "tbNewAge";
            this.tbNewAge.Size = new System.Drawing.Size(235, 27);
            this.tbNewAge.TabIndex = 1;
            // 
            // tbNewHeight
            // 
            this.tbNewHeight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbNewHeight.Location = new System.Drawing.Point(71, 285);
            this.tbNewHeight.Name = "tbNewHeight";
            this.tbNewHeight.Size = new System.Drawing.Size(235, 27);
            this.tbNewHeight.TabIndex = 2;
            // 
            // tbNewWeight
            // 
            this.tbNewWeight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbNewWeight.Location = new System.Drawing.Point(71, 370);
            this.tbNewWeight.Name = "tbNewWeight";
            this.tbNewWeight.Size = new System.Drawing.Size(235, 27);
            this.tbNewWeight.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Geomanist Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(71, 454);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(235, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Geomanist Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Teal;
            this.btnCancel.Location = new System.Drawing.Point(71, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(235, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNewName.Location = new System.Drawing.Point(71, 111);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(84, 19);
            this.lblNewName.TabIndex = 6;
            this.lblNewName.Text = "New Name";
            // 
            // lblNewAge
            // 
            this.lblNewAge.AutoSize = true;
            this.lblNewAge.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewAge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNewAge.Location = new System.Drawing.Point(71, 185);
            this.lblNewAge.Name = "lblNewAge";
            this.lblNewAge.Size = new System.Drawing.Size(71, 19);
            this.lblNewAge.TabIndex = 7;
            this.lblNewAge.Text = "New Age";
            // 
            // lblNewHeight
            // 
            this.lblNewHeight.AutoSize = true;
            this.lblNewHeight.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewHeight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNewHeight.Location = new System.Drawing.Point(71, 263);
            this.lblNewHeight.Name = "lblNewHeight";
            this.lblNewHeight.Size = new System.Drawing.Size(144, 19);
            this.lblNewHeight.TabIndex = 8;
            this.lblNewHeight.Text = "New Height  (Meter)";
            // 
            // lblNewWeight
            // 
            this.lblNewWeight.AutoSize = true;
            this.lblNewWeight.Font = new System.Drawing.Font("Geomanist Book", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewWeight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNewWeight.Location = new System.Drawing.Point(71, 348);
            this.lblNewWeight.Name = "lblNewWeight";
            this.lblNewWeight.Size = new System.Drawing.Size(127, 19);
            this.lblNewWeight.TabIndex = 9;
            this.lblNewWeight.Text = "New Weight  (Kg)";
            // 
            // UserDataEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 637);
            this.Controls.Add(this.lblNewWeight);
            this.Controls.Add(this.lblNewHeight);
            this.Controls.Add(this.lblNewAge);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbNewWeight);
            this.Controls.Add(this.tbNewHeight);
            this.Controls.Add(this.tbNewAge);
            this.Controls.Add(this.tbNewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDataEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDataEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDataEditForm_FormClosed);
            this.Load += new System.EventHandler(this.UserDataEditForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserDataEditForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbNewAge;
        private System.Windows.Forms.TextBox tbNewHeight;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewAge;
        private System.Windows.Forms.Label lblNewHeight;
        private System.Windows.Forms.Label lblNewWeight;
        private System.Windows.Forms.TextBox tbNewWeight;
    }
}