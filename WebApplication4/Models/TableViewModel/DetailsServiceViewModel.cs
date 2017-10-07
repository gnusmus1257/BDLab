using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.TableViewModel
{
    public class DetailsServiceViewModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public byte[] Photo { get; set; }
        public List<int> idList { get; set; }
    }
}
