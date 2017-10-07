using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.Models.TableViewModel;

namespace WebApplication4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.Service> Service { get; set; }
        public DbSet<WebApplication4.Models.Visitors> Visitor { get; set; }
        public DbSet<WebApplication4.Models.Visits> Visit { get; set; }
        public DbSet<WebApplication4.Models.TableViewModel.ServiceViewModel> ServiceViewModel { get; set; }
    }
}
