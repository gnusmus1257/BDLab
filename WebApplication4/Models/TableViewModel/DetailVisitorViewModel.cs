using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.TableViewModel
{
    public class DetailVisitorViewModel
    {
        public int ID { get; set; }
        public string FIO {get;set;}
        public int PhoneNumber { get; set; }
        public int Discount { get; set; }
        public List<int> idList { get; set; }
    }
}
