
namespace NOXHealth
{
    partial class FormRecipe
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
            this.lblRecipe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecipe
            // 
            this.lblRecipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Geomanist Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipe.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRecipe.Location = new System.Drawing.Point(290, 176);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(218, 80);
            this.lblRecipe.TabIndex = 1;
            this.lblRecipe.Text = "RECIPE";
            this.lblRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecipe);
            this.Name = "FormRecipe";
            this.Text = "FormRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipe;
    }
}