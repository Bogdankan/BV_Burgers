using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BV_Burgers.Models;

namespace BV_Burgers
{
    interface IOrder
    {
        public void AddToOrder(Goods good, int count);
        public void DeleteFromOrder(Goods good, int count);

    }
}
