using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.TableViewModel
{
    public class DetailsVisitViewModel
    {
        public int ID { get; set; }
        public Visitors Visitor { get; set; }
        public DateTime Date { get; set; }
        public Service Service { get; set; }
        public string Master { get; set; }
        public List<int> idList { get; set; }
    }
}
