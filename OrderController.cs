using BV_Burgers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV_Burgers.Controllers
{
    class OrderController : Controller, IOrder
    {
        public List<Order> Orders { get; set; }
        public Order CurrentOrder { get; private set; }

        public OrderController()
        {
            Orders = new List<Order>();
        }

        private double GetSum(Order order)
        {
            double res = 0;
            foreach (var item in order.Goods)
            {
                res += item.Good.Price * item.Count;
            }
            return res;
        }

        public void AddToOrders(Order order)
        {
            order.Sum = GetSum(order);
            Orders.Add(order);
            Save();
        }

        public void DeleteFromOrders(Order order)
        {
            CurrentOrder = Orders.SingleOrDefault(o => o.Sum == order.Sum);
            Orders.Remove(CurrentOrder);
            Save();
        }

        private List<Order> Load()
        {
            return Load<List<Order>>("orders.dat") ?? new List<Order>();
        }
        
        private void Save()
        {
            Save("orders.dat", Orders);
        }

        public void AddToOrder(Goods good, int count)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromOrder(Goods good, int count)
        {
            throw new NotImplementedException();
        }
    }
}
