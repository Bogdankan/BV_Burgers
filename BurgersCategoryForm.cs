using BV_Burgers.Controllers;
using BV_Burgers.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BV_Burgers
{
    public partial class BurgersCategoryForm : Form
    {
        GoodsController gc;

        public BurgersCategoryForm()
        {
            InitializeComponent();
        }


        //public void AddGood(Panel p)
        //{           
        //    GoodsPanel.Controls.Add(p);
        //    GoodsPanel.Tag = p;
        //    p.Height = 227;
        //    p.Width = 227;
        //    p.BackColor = Color.Black;
        //    p.BringToFront();
        //    p.Show();
        //}


        private void picBigMac_Click(object sender, EventArgs e)
        {
            gc = new GoodsController();
            string name = label1.Text;
            float price = float.Parse(label3.Text);
            int count = (int)numericUpDown1.Value;
           // gc.GoodAdd(new Food(name, price, count));
            gc.Save();
        }

        private void picBigTasty_Click(object sender, EventArgs e)
        {
            string name = label2.Text;
            float price = float.Parse(label4.Text);
            int count = (int)numericUpDown2.Value;
           // gc.GoodAdd(new Food(name, price, count));
            gc.Save();
        }
    }
}
