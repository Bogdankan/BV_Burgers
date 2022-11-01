namespace BV_Burgers
{
    partial class VouchersCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VouchersCategoryForm));
            this.voucherPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // saladPanel
            // 
            this.voucherPanel.BackColor = System.Drawing.Color.Transparent;
            this.voucherPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voucherPanel.Location = new System.Drawing.Point(0, 0);
            this.voucherPanel.Name = "saladPanel";
            this.voucherPanel.Size = new System.Drawing.Size(1283, 756);
            this.voucherPanel.TabIndex = 2;
            // 
            // VouchersCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 756);
            this.Controls.Add(this.voucherPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VouchersCategoryForm";
            this.Text = "VouchersCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel voucherPanel;
    }
}