namespace BV_Burgers
{
    partial class GoodIcon
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.goodPrice = new System.Windows.Forms.Label();
            this.goodName = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.goodPic = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tomato;
            this.panel3.Controls.Add(this.goodPrice);
            this.panel3.Controls.Add(this.goodName);
            this.panel3.Controls.Add(this.numericUpDown);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 361);
            this.panel3.TabIndex = 2;
            // 
            // goodPrice
            // 
            this.goodPrice.AutoSize = true;
            this.goodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodPrice.Location = new System.Drawing.Point(7, 307);
            this.goodPrice.Name = "goodPrice";
            this.goodPrice.Size = new System.Drawing.Size(88, 36);
            this.goodPrice.TabIndex = 4;
            this.goodPrice.Text = "Цена";
            // 
            // goodName
            // 
            this.goodName.AutoSize = true;
            this.goodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodName.Location = new System.Drawing.Point(9, 283);
            this.goodName.Name = "goodName";
            this.goodName.Size = new System.Drawing.Size(97, 24);
            this.goodName.TabIndex = 2;
            this.goodName.Text = "Название";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown.Location = new System.Drawing.Point(160, 305);
            this.numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(114, 53);
            this.numericUpDown.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
            this.panel4.Controls.Add(this.goodPic);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 277);
            this.panel4.TabIndex = 0;
            // 
            // goodPic
            // 
            this.goodPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goodPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodPic.Location = new System.Drawing.Point(0, 0);
            this.goodPic.Name = "goodPic";
            this.goodPic.Size = new System.Drawing.Size(314, 277);
            this.goodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goodPic.TabIndex = 0;
            this.goodPic.TabStop = false;
            // 
            // GoodIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodIcon";
            this.Text = "GoodIcon";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label goodPrice;
        private System.Windows.Forms.Label goodName;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox goodPic;
    }
}