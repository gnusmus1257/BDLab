using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.OrderContentViewModel
{
    public class OrderContentCreateViewModel
    {
        public int ID { get; set; }
        public int Order { get; set; }
        public string Dish { get; set; }
        public int Count { get; set; }
        public int Value { get; set; }
        public List<Order> Orders { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
