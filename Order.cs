using System;
using System.Collections.Generic;
using System.Linq;

namespace BV_Burgers.Models
{
    [Serializable]
    class Order 
    {
        public User User { get; set; }
        public List<Node> Goods { get; set; }
        public double Sum { get; set; }


        public Order(User user)
        {
            User = user;
            Goods = new List<Node>();
        }

        public void AddNode(Node node)
        {
            Goods.Add(node);
        }
       
    }

    class Node
    {
        public Goods Good { get; set; }
        public int Count { get; set; }
        public Node(Goods good, int count)
        {
            Good = good;
            Count = count;
        }

    }
}
