using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Burgers
{
    public partial class GoodIcon : Form
    {
        public string GoodName
        { 
            set
            {
                this.goodName.Text = value;
            }
        }
        public double GoodPrice
        { 
            set
            {
                this.goodPrice.Text = value.ToString() + " грн";
            }
        }
        public Image GoodIM 
        {
            set
            {
                this.goodPic.BackgroundImage = value;
            }
        }

        public GoodIcon()
        {
            InitializeComponent();
        }
        public GoodIcon(string name, double price, Image image)
        {
            this.goodName.Text = name;
            this.goodPrice.Text = price.ToString() + " грн";
            this.goodPic.BackgroundImage = image;
            InitializeComponent();
        }
    }
}
