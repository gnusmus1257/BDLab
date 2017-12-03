using System;
using System.ComponentModel.DataAnnotations;

namespace BDLab26
{
    public class Service
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int value { get; set; }
        public byte[] Photo { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return name + " " + description + " " + value;
        }
    }

    public class Visitors
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public int PhoneNumber { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return FIO + " " + PhoneNumber + " " + Discount;
        }
    }

    public class Visits
    {
        public int ID { get; set; }
        [Required]
        public string Visitor { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Service { get; set; }
        public string Master { get; set; }
    }
}