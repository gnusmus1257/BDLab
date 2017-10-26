using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models.TableViewModel
{
    public class CreateMenuViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public byte[] Photo { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public IFormFile Avatar { get; set; }
    }
}
