﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Noested.Data;
using Noested.Models;

namespace Noested.Controllers
{
    public class ChecklistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChecklistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Checklists
        public async Task<IActionResult> Index()
        {
              return _context.Checklist != null ? 
                          View(await _context.Checklist.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Checklist'  is null.");
        }

        // GET: Checklists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Checklist == null)
            {
                return NotFound();
            }

            var checklist = await _context.Checklist
                .FirstOrDefaultAsync(m => m.SjekklisteID == id);
            if (checklist == null)
            {
                return NotFound();
            }

            return View(checklist);
        }

        // GET: Checklists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Checklists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SjekklisteID,OrdreNr,GodkjentAv,UtarbeidetAv,MekBremser,MekTrommellager,MekOpplagringPTO,MekWire,MekKjedestrammer,MekPinionlager,MekClutch,MekKjedehjulkiler,HydSylinder,HydSlanger,HydHydraulikkblokk,HydTankolje,HydGirboksolje,HydBremsesylinder,ElLedningsnett,ElRadio,ElKnappekasse,TrykkSjekkBar,TestVinsj,TestTrekkraft,TestBremsekraft,Kommentar,Signatur,DatoFullfort")] Checklist checklist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(checklist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(checklist);
        }

        // GET: Checklists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Checklist == null)
            {
                return NotFound();
            }

            var checklist = await _context.Checklist.FindAsync(id);
            if (checklist == null)
            {
                return NotFound();
            }
            return View(checklist);
        }

        // POST: Checklists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SjekklisteID,OrdreNr,GodkjentAv,UtarbeidetAv,MekBremser,MekTrommellager,MekOpplagringPTO,MekWire,MekKjedestrammer,MekPinionlager,MekClutch,MekKjedehjulkiler,HydSylinder,HydSlanger,HydHydraulikkblokk,HydTankolje,HydGirboksolje,HydBremsesylinder,ElLedningsnett,ElRadio,ElKnappekasse,TrykkSjekkBar,TestVinsj,TestTrekkraft,TestBremsekraft,Kommentar,Signatur,DatoFullfort")] Checklist checklist)
        {
            if (id != checklist.SjekklisteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checklist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChecklistExists(checklist.SjekklisteID))
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
            return View(checklist);
        }

        // GET: Checklists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Checklist == null)
            {
                return NotFound();
            }

            var checklist = await _context.Checklist
                .FirstOrDefaultAsync(m => m.SjekklisteID == id);
            if (checklist == null)
            {
                return NotFound();
            }

            return View(checklist);
        }

        // POST: Checklists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Checklist == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Checklist'  is null.");
            }
            var checklist = await _context.Checklist.FindAsync(id);
            if (checklist != null)
            {
                _context.Checklist.Remove(checklist);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChecklistExists(int id)
        {
          return (_context.Checklist?.Any(e => e.SjekklisteID == id)).GetValueOrDefault();
        }
    }
}
