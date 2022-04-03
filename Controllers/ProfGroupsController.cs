using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CallCenterV1.Data;
using CallCenterV1.Models;

namespace CallCenterV1.Controllers
{
    public class ProfGroupsController : Controller
    {
        private readonly SchoolContext _context;

        public ProfGroupsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: ProfGroups
        public async Task<IActionResult> Index()
        {
            var schoolContext = _context.ProfGroups.Include(p => p.Group).Include(p => p.Prof);
            return View(await schoolContext.ToListAsync());
        }

        // GET: ProfGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profGroup = await _context.ProfGroups
                .Include(p => p.Group)
                .Include(p => p.Prof)
                .FirstOrDefaultAsync(m => m.ProfID == id);
            if (profGroup == null)
            {
                return NotFound();
            }

            return View(profGroup);
        }

        // GET: ProfGroups/Create
        public IActionResult Create()
        {
            ViewData["GroupID"] = new SelectList(_context.Groups, "Id", "Nom");
            ViewData["ProfID"] = new SelectList(_context.Profs, "Id", "nom");
            return View();
        }

        // POST: ProfGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfID,GroupID")] ProfGroup profGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(profGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupID"] = new SelectList(_context.Groups, "Id", "Nom", profGroup.GroupID);
            ViewData["ProfID"] = new SelectList(_context.Profs, "Id", "nom", profGroup.ProfID);
            return View(profGroup);
        }

        // GET: ProfGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profGroup = await _context.ProfGroups.FindAsync(id);
            if (profGroup == null)
            {
                return NotFound();
            }
            ViewData["GroupID"] = new SelectList(_context.Groups, "Id", "Nom", profGroup.GroupID);
            ViewData["ProfID"] = new SelectList(_context.Profs, "Id", "nom", profGroup.ProfID);
            return View(profGroup);
        }

        // POST: ProfGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfID,GroupID")] ProfGroup profGroup)
        {
            if (id != profGroup.ProfID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(profGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfGroupExists(profGroup.ProfID))
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
            ViewData["GroupID"] = new SelectList(_context.Groups, "Id", "Nom", profGroup.GroupID);
            ViewData["ProfID"] = new SelectList(_context.Profs, "Id", "nom", profGroup.ProfID);
            return View(profGroup);
        }

        // GET: ProfGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profGroup = await _context.ProfGroups
                .Include(p => p.Group)
                .Include(p => p.Prof)
                .FirstOrDefaultAsync(m => m.ProfID == id);
            if (profGroup == null)
            {
                return NotFound();
            }

            return View(profGroup);
        }

        // POST: ProfGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var profGroup = await _context.ProfGroups.FindAsync(id);
            _context.ProfGroups.Remove(profGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfGroupExists(int id)
        {
            return _context.ProfGroups.Any(e => e.ProfID == id);
        }
    }
}
