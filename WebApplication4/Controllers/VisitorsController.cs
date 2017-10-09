using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Models.TableViewModel;

namespace WebApplication4.Controllers
{
    public class VisitorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisitorsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Visitors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Visitor.ToListAsync());
        }

        // GET: Visitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitor
                .SingleOrDefaultAsync(m => m.ID == id);
            if (visitors == null)
            {
                return NotFound();
            }
            List<int> list = new List<int>();
            foreach (var item in _context.Visitor)
            {
                list.Add(item.ID);
            }
            var temp = new DetailVisitorViewModel()
            {
                ID = visitors.ID,
                FIO=visitors.FIO,
                Discount = visitors.Discount,
                PhoneNumber = visitors.PhoneNumber,
                idList = list
            };
            return View(temp);
        }


        public ActionResult GetCountVisits (int id)
        {
            var visitor = _context.Visitor.FirstOrDefault(x => x.ID == id);
            if (visitor==null||visitor.ID!=id)
            {
                return NotFound();
            }
            var countVisit = GetCountVisit(_context.Visit.ToList(), visitor);
            if (countVisit==0)
            {
                visitor.Discount = 1;
                _context.Update(visitor);
                _context.SaveChanges();
            }
            List<int> list = new List<int>();
            foreach (var item in _context.Visitor)
            {
                list.Add(item.ID);
            }
            var temp = new DetailVisitorViewModel()
            {
                ID = visitor.ID,
                FIO = visitor.FIO,
                Discount = visitor.Discount,
                PhoneNumber = visitor.PhoneNumber,
                idList = list,
                CountVisit = countVisit
            };
            return View("Details",temp);
        }

        private int GetCountVisit(List<Visits> list, Visitors visitor)
        {
            int countVisit = 0;
            foreach (var item in list)
            {
                if (item.Visitor == visitor)
                {
                    countVisit++;
                }
            }
            return countVisit;
        }

        // GET: Visitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Visitors visitors)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.Visitor.FirstOrDefault(x => x.PhoneNumber == visitors.PhoneNumber);
                if (temp != null && temp.PhoneNumber == visitors.PhoneNumber)
                {
                    return RedirectToAction("Index");
                }
                _context.Add(visitors);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(visitors);
        }

        // GET: Visitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitor.SingleOrDefaultAsync(m => m.ID == id);
            if (visitors == null)
            {
                return NotFound();
            }
            return View(visitors);
        }

        // POST: Visitors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PhoneNumber,Discount")] Visitors visitors)
        {
            if (id != visitors.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitorsExists(visitors.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(visitors);
        }

        // GET: Visitors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitors = await _context.Visitor
                .SingleOrDefaultAsync(m => m.ID == id);
            if (visitors == null)
            {
                return NotFound();
            }

            return View(visitors);
        }

        // POST: Visitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitors = await _context.Visitor.SingleOrDefaultAsync(m => m.ID == id);
            _context.Visitor.Remove(visitors);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VisitorsExists(int id)
        {
            return _context.Visitor.Any(e => e.ID == id);
        }
    }
}
