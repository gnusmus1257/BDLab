using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.TableViewModel
{
    public class VisitCreateViewModel
    {
        public int ID { get; set; }
        public List<Visitors> Visitors { get; set; }
        public DateTime Date { get; set; }
        public List<Service> Services { get; set; }
        public string Master { get; set; }
        public string Service { get; set; }
        public string  Visitor { get; set; }
    }
}
