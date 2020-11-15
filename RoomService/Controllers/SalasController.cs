using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL.Data;

namespace RoomService.Controllers
{
    [Route("api/[controller]")]
    public class SalasController : ControllerBase
    {
        private readonly DataContext context;

        public SalasController(DataContext context)
        {
            this.context = context;
        }

    
        public ActionResult<IEnumerable<Sala>> Index()
        {
            return context.Salas.ToList();
        }

        //// GET: Salas/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sala = await _context.Salas
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (sala == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sala);
        //}

        //// GET: Salas/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}


        [Route("PostSalas")]
        [HttpPost]

        //public async Task<IActionResult> Create(Sala sala)
        public string Create(Sala sala)
        {
            context.Salas.Add(sala);
            context.SaveChanges();
            return "Ok";

        }

        //// GET: Salas/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sala = await _context.Salas.FindAsync(id);
        //    if (sala == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(sala);
        //}

        //// POST: Salas/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("NombreSala,FechaBaja,FechaUltimoUso,TiempoAcumuladoUso,PasswordSala,ControlAsistencia,EsPersistente,Id,DateCreated,DateModified")] Sala sala)
        //{
        //    if (id != sala.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(sala);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SalaExists(sala.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(sala);
        //}

        //// GET: Salas/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sala = await _context.Salas
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (sala == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(sala);
        //}

        //// POST: Salas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var sala = await _context.Salas.FindAsync(id);
        //    _context.Salas.Remove(sala);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SalaExists(int id)
        //{
        //    return _context.Salas.Any(e => e.Id == id);
        //}
    }
}
