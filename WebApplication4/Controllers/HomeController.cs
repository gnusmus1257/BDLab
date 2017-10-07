using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Data;
using WebApplication4.Models.TableViewModel;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Service ser = new Service() { description = "sdfngsdfgksng", name = "dfgsdfgsdg", value = 4 };
            //_context.Service.Add(ser);
            //_context.SaveChanges();
            return View(ser);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public ActionResult ServiceTable()
        {
            return View(_context.Service.ToList());
        }

        public ActionResult VisitorsTable()
        {
            return View(_context.Visitor.ToList());
        }

        public ActionResult VisitsTable()
        {
            return View(_context.Visit.ToList());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
