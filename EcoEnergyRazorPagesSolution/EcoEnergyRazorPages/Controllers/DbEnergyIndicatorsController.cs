using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcoEnergyRazorPages.Data;
using EcoEnergyRazorPages.Model;
using EcoEnergyRazorPages.Tools;
using System.Diagnostics;

namespace EcoEnergyRazorPages.Controllers
{
    [Route("DbEnergyIndicators")]
    public class DbEnergyIndicatorsController : Controller
    {
        private readonly AppDbContext _context;

        public DbEnergyIndicatorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DbEnergyIndicators
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.EnergyIndicators.ToListAsync());
        }

        // GET: DbEnergyIndicators/Details/5
        [HttpGet]
        [Route("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbEnergyIndicator = await _context.EnergyIndicators
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbEnergyIndicator == null)
            {
                return NotFound();
            }

            return View(dbEnergyIndicator);
        }

        // GET: DbEnergyIndicators/Create
        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DbEnergyIndicators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([Bind("Id,Year,CDEEBC_ProdNeta,CCAC_GasolinaAuto,CDEEBC_DemandaElectr,CDEEBC_ProdDisp")] DbEnergyIndicator dbEnergyIndicator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dbEnergyIndicator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dbEnergyIndicator);
        }

        // GET: DbEnergyIndicators/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbEnergyIndicator = await _context.EnergyIndicators.FindAsync(id);
            if (dbEnergyIndicator == null)
            {
                return NotFound();
            }
            return View(dbEnergyIndicator);
        }

        // POST: DbEnergyIndicators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Year,CDEEBC_ProdNeta,CCAC_GasolinaAuto,CDEEBC_DemandaElectr,CDEEBC_ProdDisp")] DbEnergyIndicator dbEnergyIndicator)
        {
            if (id != dbEnergyIndicator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dbEnergyIndicator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DbEnergyIndicatorExists(dbEnergyIndicator.Id))
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
            return View(dbEnergyIndicator);
        }

        // GET: DbEnergyIndicators/Delete/5
        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbEnergyIndicator = await _context.EnergyIndicators
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbEnergyIndicator == null)
            {
                return NotFound();
            }

            return View(dbEnergyIndicator);
        }

        // POST: DbEnergyIndicators/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dbEnergyIndicator = await _context.EnergyIndicators.FindAsync(id);
            if (dbEnergyIndicator != null)
            {
                _context.EnergyIndicators.Remove(dbEnergyIndicator);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbEnergyIndicatorExists(int id)
        {
            return _context.EnergyIndicators.Any(e => e.Id == id);
        }
        [HttpPost]
        [Route("")]
        public IActionResult Restore()
        {
            const string csvFile = "indicadors_energetics_cat.csv";
            const string csvPath = @"ModelData\" + csvFile;

            Debug.WriteLine("?: Restore Db");

            List<FileEnergyIndicator> fileEnerInd = FilesHelper.ReadCsv<FileEnergyIndicator>(csvPath);

            foreach (DbEnergyIndicator dbEnergyInd in _context.EnergyIndicators)
            {
                _context.Remove(dbEnergyInd);
            }

            foreach (FileEnergyIndicator energInd in fileEnerInd)
            {
                DbEnergyIndicator dbEnergyInd = new DbEnergyIndicator()
                {
                    Year = energInd.Data.Year,
                    CDEEBC_ProdNeta = energInd.CDEEBC_ProdNeta,
                    CCAC_GasolinaAuto = energInd.CCAC_GasolinaAuto,
                    CDEEBC_DemandaElectr = energInd.CDEEBC_DemandaElectr,
                    CDEEBC_ProdDisp = energInd.CDEEBC_ProdDisp
                };
                _context.Add(dbEnergyInd);
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
