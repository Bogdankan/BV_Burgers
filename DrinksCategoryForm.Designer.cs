namespace BV_Burgers
{
    partial class DrinksCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinksCategoryForm));
            this.drinkPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.drinkPanel.BackColor = System.Drawing.Color.Transparent;
            this.drinkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkPanel.Location = new System.Drawing.Point(0, 0);
            this.drinkPanel.Name = "flowLayoutPanel1";
            this.drinkPanel.Size = new System.Drawing.Size(1283, 756);
            this.drinkPanel.TabIndex = 0;
            // 
            // DrinksCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 756);
            this.Controls.Add(this.drinkPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinksCategoryForm";
            this.Text = "DrinksCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel drinkPanel;
    }
}