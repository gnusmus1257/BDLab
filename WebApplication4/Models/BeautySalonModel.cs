using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace WebApplication4.Models
{

    public class Service
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public byte[] Photo { get; set; }
    }

    public class Visitors
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public int PhoneNumber { get; set; }
        public int Discount { get; set; }
    }

    public class Visits
    {
        public int ID { get; set; }
        
        [Required]
        public Visitors Visitor { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public Service Service { get; set; }
        public string Master { get; set; }
    }
}
