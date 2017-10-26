using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Menu
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public double Weight { get; set; }
        public byte [] Photo { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }

    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int TableNumber { get; set; }
        public string FIO { get; set; }
    }

    public class OrderContent
    {
        public int ID { get; set; }
        public Order Order { get; set; }
        public Menu Dish { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
    }
}
