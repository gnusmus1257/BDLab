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
    public class VisitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisitsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Visits
        public async Task<IActionResult> Index()
        {
            List<Visits> list = await _context.Visit.Include(t => t.Service).Include(x => x.Visitor).ToListAsync();
            return View(list);
        }

        // GET: Visits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visit
                .SingleOrDefaultAsync(m => m.ID == id);
            if (visits == null)
            {
                return NotFound();
            }
            List<int> list = new List<int>();
            foreach (var item in _context.Visit)
            {
                list.Add(item.ID);
            }
            var temp = new DetailsVisitViewModel()
            {
                ID = visits.ID,
                Date = visits.Date,
                Master = visits.Master,
                Service = visits.Service,
                Visitor = visits.Visitor, 
                idList = list
            };
            return View(temp);
        }

        // GET: Visits/Create
        public IActionResult Create()
        {
            VisitCreateViewModel model = new VisitCreateViewModel();
            model.Services = _context.Service.ToList();
            model.Visitors = _context.Visitor.ToList();
            return View(model);
        }

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VisitCreateViewModel visits)
        {
            if (ModelState.IsValid)
            {
                var temp = new Visits()
                {
                    Date = visits.Date,
                    Visitor = _context.Visitor.First(x => x.FIO == visits.Visitor),
                    Master = visits.Master,
                    Service = _context.Service.First(x => x.name == visits.Service)
                };
                _context.Add(temp);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(visits);
        }

        // GET: Visits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visit.SingleOrDefaultAsync(m => m.ID == id);
            if (visits == null)
            {
                return NotFound();
            }
            return View(visits);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Date,Master")] Visits visits)
        {
            if (id != visits.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitsExists(visits.ID))
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
            return View(visits);
        }

        // GET: Visits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visits = await _context.Visit
                .SingleOrDefaultAsync(m => m.ID == id);
            if (visits == null)
            {
                return NotFound();
            }

            return View(visits);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visits = await _context.Visit.SingleOrDefaultAsync(m => m.ID == id);
            _context.Visit.Remove(visits);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VisitsExists(int id)
        {
            return _context.Visit.Any(e => e.ID == id);
        }
    }
}
