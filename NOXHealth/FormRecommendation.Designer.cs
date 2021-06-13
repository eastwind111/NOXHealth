
namespace NOXHealth
{
    partial class FormRecommendation
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.Controls.Add(this.lblRecommendation);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 450);
            this.panelDesktop.TabIndex = 13;
            // 
            // lblRecommendation
            // 
            this.lblRecommendation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecommendation.AutoSize = true;
            this.lblRecommendation.Font = new System.Drawing.Font("Geomanist Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecommendation.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRecommendation.Location = new System.Drawing.Point(104, 190);
            this.lblRecommendation.Name = "lblRecommendation";
            this.lblRecommendation.Size = new System.Drawing.Size(582, 80);
            this.lblRecommendation.TabIndex = 2;
            this.lblRecommendation.Text = "RECOMMENDATION";
            this.lblRecommendation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRecommendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormRecommendation";
            this.Text = "FormRecommendation";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblRecommendation;
    }
}