using BV_Burgers.Controllers;
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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();

            listView.SmallImageList = imageList1;
        }

        private void AddItem()
        {
            GoodsController gc = new GoodsController();
            gc.Goods = gc.GetData();
            int i = 1;
            double price = 0;
            //while (i < 10)
            //{
            //    gc.GoodAdd(new Models.Goods("Product" + i, 56.77, 3 + i));
            //    i++;

            //}
            foreach (var good in gc.Goods)
            {

                ListViewItem lvi = new ListViewItem
                {
                    Text = $"{good.GoodName} | {good.Price} грн | {good.Count} штук",
                    ImageIndex = 0
                };
           //     price += good.Price;
                listView.Items.Add(lvi);
            }
           // label2.Text = $"{price} грн";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void RemoveItem()
        {
            if (listView.Items.Count > 0)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    listView.Items.Remove(item);
                }
            }
        }
    }
}
