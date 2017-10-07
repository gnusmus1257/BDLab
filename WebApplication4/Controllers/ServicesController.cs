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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebApplication4.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            return View(await _context.Service.ToListAsync());
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .SingleOrDefaultAsync(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }
            List<int> list = new List<int>();
            foreach (var item in _context.Service)
            {
                list.Add(item.ID);
            }
            var temp = new DetailsServiceViewModel()
            {
                ID=service.ID,
                description = service.description,
                name = service.name,
                value = service.value,
                Photo = service.Photo,
                idList = list
            };
            return View(temp);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateServiceViewModel service)
        {
            if (ModelState.IsValid)
            {
                var temp = _context.Service.FirstOrDefault(x => x.name == service.name);
                if (temp!=null && temp.name==service.name|| service.Avatar==null)
                {
                    return RedirectToAction("Index");
                }

                var binaryReader = new BinaryReader(service.Avatar.OpenReadStream());
                _context.Add(new Service()
                {
                    description=service.description,
                    name=service.name,
                    Photo= binaryReader.ReadBytes((int)service.Avatar.Length),
                    value=service.value
                });
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service.SingleOrDefaultAsync(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CreateServiceViewModel service)
        {
            if (id != service.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var binaryReader = new BinaryReader(service.Avatar.OpenReadStream());
                    _context.Update(new Service()
                    {
                        ID=id,
                        description = service.description,
                        name = service.name,
                        Photo = binaryReader.ReadBytes((int)service.Avatar.Length),
                        value = service.value
                    });
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.ID))
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
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Service
                .SingleOrDefaultAsync(m => m.ID == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Service.SingleOrDefaultAsync(m => m.ID == id);
            _context.Service.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ServiceExists(int id)
        {
            return _context.Service.Any(e => e.ID == id);
        }
    }
}
