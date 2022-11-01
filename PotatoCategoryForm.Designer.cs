namespace BV_Burgers
{
    partial class PotatoCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PotatoCategoryForm));
            this.potatoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // drinkPanel
            // 
            this.potatoPanel.BackColor = System.Drawing.Color.Transparent;
            this.potatoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potatoPanel.Location = new System.Drawing.Point(0, 0);
            this.potatoPanel.Name = "drinkPanel";
            this.potatoPanel.Size = new System.Drawing.Size(1283, 756);
            this.potatoPanel.TabIndex = 1;
            // 
            // PotatoCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 756);
            this.Controls.Add(this.potatoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PotatoCategoryForm";
            this.Text = "PotatoCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel potatoPanel;
    }
}