using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvcfull_operation.Data;
using mvcfull_operation.Models;

namespace mvcfull_operation.Controllers
{
    public class MvcScafoldModelsController : Controller
    {
        private readonly MvcDbContext _context;

        public MvcScafoldModelsController(MvcDbContext context)
        {
            _context = context;
        }

        // GET: MvcScafoldModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.MvcScafoldModel.ToListAsync());
        }

        // GET: MvcScafoldModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MvcScafoldModel == null)
            {
                return NotFound();
            }

            var mvcScafoldModel = await _context.MvcScafoldModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mvcScafoldModel == null)
            {
                return NotFound();
            }

            return View(mvcScafoldModel);
        }

        // GET: MvcScafoldModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MvcScafoldModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,CreatedDateTime")] MvcScafoldModel mvcScafoldModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mvcScafoldModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mvcScafoldModel);
        }

        // GET: MvcScafoldModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MvcScafoldModel == null)
            {
                return NotFound();
            }

            var mvcScafoldModel = await _context.MvcScafoldModel.FindAsync(id);
            if (mvcScafoldModel == null)
            {
                return NotFound();
            }
            return View(mvcScafoldModel);
        }

        // POST: MvcScafoldModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,CreatedDateTime")] MvcScafoldModel mvcScafoldModel)
        {
            if (id != mvcScafoldModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mvcScafoldModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MvcScafoldModelExists(mvcScafoldModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mvcScafoldModel);
        }

        // GET: MvcScafoldModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MvcScafoldModel == null)
            {
                return NotFound();
            }

            var mvcScafoldModel = await _context.MvcScafoldModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mvcScafoldModel == null)
            {
                return NotFound();
            }

            return View(mvcScafoldModel);
        }

        // POST: MvcScafoldModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MvcScafoldModel == null)
            {
                return Problem("Entity set 'MvcDbContext.MvcScafoldModel'  is null.");
            }
            var mvcScafoldModel = await _context.MvcScafoldModel.FindAsync(id);
            if (mvcScafoldModel != null)
            {
                _context.MvcScafoldModel.Remove(mvcScafoldModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MvcScafoldModelExists(int id)
        {
          return _context.MvcScafoldModel.Any(e => e.Id == id);
        }
    }
}
