using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Models.OrderContentViewModel;

namespace WebApplication4.Controllers
{
    public class OrderContentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderContentsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OrderContents
        public async Task<IActionResult> Index()
        {
            List<OrderContent> list = await _context.OrderContent.Include(t => t.Order).Include(x => x.Dish).ToListAsync();
            return View(list);
        }

        // GET: OrderContents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderContent = await _context.OrderContent
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderContent == null)
            {
                return NotFound();
            }

            return View(orderContent);
        }

        // GET: OrderContents/Create
        public IActionResult Create()
        {
            OrderContentCreateViewModel model = new OrderContentCreateViewModel();
            model.Menus = _context.Menu.ToList();
            model.Orders = _context.Order.ToList();
            return View(model);
        }

        // POST: OrderContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderContentCreateViewModel orderContent)
        {
            if (ModelState.IsValid)
            {
                var temp = new OrderContent()
                {
                    Count = orderContent.Count,
                    Order = _context.Order.First(x => x.ID == orderContent.Order),
                    Dish = _context.Menu.First(x => x.Name == orderContent.Dish),
                    Value = orderContent.Value
                };
                _context.Add(temp);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(orderContent);
        }

        // GET: OrderContents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderContent = await _context.OrderContent.SingleOrDefaultAsync(m => m.ID == id);
            if (orderContent == null)
            {
                return NotFound();
            }
            return View(orderContent);
        }

        // POST: OrderContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Count,Value")] OrderContent orderContent)
        {
            if (id != orderContent.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderContentExists(orderContent.ID))
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
            return View(orderContent);
        }

        // GET: OrderContents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderContent = await _context.OrderContent
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderContent == null)
            {
                return NotFound();
            }

            return View(orderContent);
        }

        // POST: OrderContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderContent = await _context.OrderContent.SingleOrDefaultAsync(m => m.ID == id);
            _context.OrderContent.Remove(orderContent);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OrderContentExists(int id)
        {
            return _context.OrderContent.Any(e => e.ID == id);
        }
    }
}
