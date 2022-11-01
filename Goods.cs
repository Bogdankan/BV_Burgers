using System;
using System.Collections.Generic;

namespace BV_Burgers.Models
{
    [Serializable]
    public class Goods
    {
        private string _goodName;

        private double _price;

        public string GoodType { get; }

        public int Count { get; set; }

        public double Price
        {     
            get
            {
                return _price; ;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public string GoodName
        {
            get
            {
                return _goodName;
            }
            set
            {
                if (value != null)
                {
                    _goodName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public Goods(string goodname, double price, string type)
        {
            GoodName = goodname;
            Price = price;
            GoodType = type;
        }

    }
}
