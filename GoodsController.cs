using BV_Burgers.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BV_Burgers.Controllers
{
    class GoodsController : Controller
    {
        public List<Goods> Goods { get; set; }

        public Goods CurrentGood { get; private set; }

        public bool IsCurrentGood { get; private set; } = false;

        public GoodsController()
        {
            Goods = new List<Goods>();
        }

        public GoodsController(string goodName)
        {
            Goods = GetData();
            CurrentGood = Goods.SingleOrDefault(g => g.GoodName == goodName);
            if (CurrentGood != null)
            {
                IsCurrentGood = true;
            }
        }

        public void Save()
        {
            Save("goods.dat", Goods);
        }

        public List<Goods> GetData()
        {
            return Load<List<Goods>>("goods.dat") ?? new List<Goods>();
        }

        public void Delete(string goodname)
        {
            CurrentGood = Goods.SingleOrDefault(g => g.GoodName == goodname);
            Goods.Remove(CurrentGood);
            Save();
        }

        public void Change(string good, string name, double price)
        {
            CurrentGood = Goods.SingleOrDefault(g => g.GoodName == good);
            Goods.Remove(CurrentGood);
            CurrentGood.GoodName = name;
            CurrentGood.Price = price;
            Goods.Add(CurrentGood);
            Save();
        }

        public double CalculatePrice(List<Goods> goods)
        {
            double sum = 0;
            foreach (Goods item in goods)
            {
                sum += item.Price * item.Count;
            }
            return sum;
        }


        public void GoodAdd(Goods good)
        {
            Goods.Add(good);
            Save();
        }

        private void SetCurrentGood(List<Goods> goods)
        {
            CurrentGood = goods.Last<Goods>();
            IsCurrentGood = true;
        }

        public void AddGood(GoodIcon gdIc, FlowLayoutPanel panel)
        {
            gdIc.TopLevel = false;
            panel.Controls.Add(gdIc);
            panel.Tag = gdIc;
            gdIc.BringToFront();
            gdIc.Show();
        }
    }
}
