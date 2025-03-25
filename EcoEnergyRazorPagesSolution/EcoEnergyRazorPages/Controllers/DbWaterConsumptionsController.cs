using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcoEnergyRazorPages.Data;
using EcoEnergyRazorPages.Model;

namespace EcoEnergyRazorPages.Controllers
{
    [Route("DbWaterConsumptions")]
    public class DbWaterConsumptionsController : Controller
    {
        private readonly AppDbContext _context;

        public DbWaterConsumptionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DbWaterConsumptions
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.WaterConsumptions.ToListAsync());
        }

        // GET: DbWaterConsumptions/Details/5
        [HttpGet]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbWaterConsumption = await _context.WaterConsumptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbWaterConsumption == null)
            {
                return NotFound();
            }

            return View(dbWaterConsumption);
        }

        // GET: DbWaterConsumptions/Create
        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DbWaterConsumptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([Bind("Id,RegionCode,RegionName,Year,HouseholdConsumptionPerCapita")] DbWaterConsumption dbWaterConsumption)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dbWaterConsumption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dbWaterConsumption);
        }

        // GET: DbWaterConsumptions/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbWaterConsumption = await _context.WaterConsumptions.FindAsync(id);
            if (dbWaterConsumption == null)
            {
                return NotFound();
            }
            return View(dbWaterConsumption);
        }

        // POST: DbWaterConsumptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RegionCode,RegionName,Year,HouseholdConsumptionPerCapita")] DbWaterConsumption dbWaterConsumption)
        {
            if (id != dbWaterConsumption.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dbWaterConsumption);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DbWaterConsumptionExists(dbWaterConsumption.Id))
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
            return View(dbWaterConsumption);
        }

        // GET: DbWaterConsumptions/Delete/5
        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbWaterConsumption = await _context.WaterConsumptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbWaterConsumption == null)
            {
                return NotFound();
            }

            return View(dbWaterConsumption);
        }

        // POST: DbWaterConsumptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dbWaterConsumption = await _context.WaterConsumptions.FindAsync(id);
            if (dbWaterConsumption != null)
            {
                _context.WaterConsumptions.Remove(dbWaterConsumption);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbWaterConsumptionExists(int id)
        {
            return _context.WaterConsumptions.Any(e => e.Id == id);
        }
    }
}
