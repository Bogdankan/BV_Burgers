﻿namespace BV_Burgers
{
    partial class SetsCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetsCategoryForm));
            this.setPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // saladPanel
            // 
            this.setPanel.BackColor = System.Drawing.Color.Transparent;
            this.setPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setPanel.Location = new System.Drawing.Point(0, 0);
            this.setPanel.Name = "saladPanel";
            this.setPanel.Size = new System.Drawing.Size(1283, 756);
            this.setPanel.TabIndex = 2;
            // 
            // SetsCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 756);
            this.Controls.Add(this.setPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetsCategoryForm";
            this.Text = "SetsCategoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel setPanel;
    }
}