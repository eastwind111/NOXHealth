
namespace NOXHealth
{
    partial class FormSetting
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
            this.lblSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSetting
            // 
            this.lblSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Geomanist Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSetting.Location = new System.Drawing.Point(275, 177);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(264, 80);
            this.lblSetting.TabIndex = 2;
            this.lblSetting.Text = "SETTING";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSetting);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetting;
    }
}