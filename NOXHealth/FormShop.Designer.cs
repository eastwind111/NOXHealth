
namespace NOXHealth
{
    partial class FormShop
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
            this.lblShop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblShop
            // 
            this.lblShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Geomanist Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblShop.Location = new System.Drawing.Point(299, 178);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(190, 80);
            this.lblShop.TabIndex = 2;
            this.lblShop.Text = "SHOP";
            this.lblShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShop);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShop;
    }
}