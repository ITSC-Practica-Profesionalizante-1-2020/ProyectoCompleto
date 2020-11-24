using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.Data;
using SharedModels.ChatService;

namespace ChatService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        private readonly DataContext _context;

        public MensajesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Mensajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensajes()
        {
            return await _context.Mensajes.Include(p => p.ParticipanteEmisor).ToListAsync();
        }

        // GET: api/Mensajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mensaje>> GetMensaje(int id)
        {
            var mensaje = await _context.Mensajes.FindAsync(id);

            if (mensaje == null)
            {
                return NotFound();
            }

            return mensaje;
        }

        // GET: api/Mensajes/Cantidad/(IdSala)
        [HttpGet("Cantidad/{idsala}")]
        public Task<Int32> GetMensajeCount(int idsala)
        {
            return _context.Mensajes.Where(s => s.SalaId == idsala).CountAsync();
        }

        // GET: api/Mensajes/cantidadpart/?
        [HttpGet("cantidadpart/{idsala}")]
        public dynamic GetCountPorPart(int idsala)
        {
            var lista = (from m in _context.Mensajes
                    where m.SalaId == idsala
                    group m by m.EmisorId into grupo
                    select new
                    {
                        Emisor = grupo.Key,
                        TotalEnviados = grupo.Count()
                    }).ToList();

            if (lista == null)
            {
                return NotFound();
            }

            return lista;
        }

        // GET: api/Mensajes/bysala/5
        [HttpGet("bysala/{id}", Name = "bysala")]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensajeSala(int id)
        {
            var mensaje = _context.Mensajes.Where(s => s.SalaId == id).ToListAsync();

            if (mensaje == null)
            {
                return NotFound();
            }
            return await mensaje;
        }

        // GET: api/Mensajes/bypartsala/(id de sala)/(id de participante)
        [HttpGet("bypartsala/{salaid}/{partid}", Name = "bypartsala")]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensajeParticipanteSala(int salaid, int partid)
        {
            var mensaje = _context.Mensajes.Where(s => s.SalaId == salaid)
                                            .Where(p => p.EmisorId == partid)
                                            .ToListAsync();

            if (mensaje == null)
            {
                return NotFound();
            }
            return await mensaje;
        }

        // PUT: api/Mensajes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensaje(int id, Mensaje mensaje)
        {
            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            _context.Entry(mensaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensajeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Mensajes/(id de sala)/(id participante)
        [HttpPost("{salaid}/{partid}")]
        public async Task<ActionResult<Mensaje>> PostMensaje(int salaid, int partid, Mensaje mensaje)
        {
            if (!SalaExists(salaid))
            {
                return NotFound();
            }
            else if(!ParticipanteExists(partid))
            {
                return NotFound();
            }
            else
            {
                _context.Mensajes.Add(mensaje);
                mensaje.DateCreated = DateTime.Now;
                mensaje.DateModified = DateTime.Now;
                mensaje.Hora_Fecha_Envio = DateTime.Now;
                mensaje.SalaId = salaid;
                mensaje.EmisorId = partid;

                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMensaje", new { id = mensaje.Id }, mensaje);
            }
        }


        // DELETE: api/Mensajes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mensaje>> DeleteMensaje(int id)
        {
            var mensaje = await _context.Mensajes.FindAsync(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            _context.Mensajes.Remove(mensaje);
            await _context.SaveChangesAsync();

            return mensaje;
        }

        private bool ParticipanteExists(int id)
        {
            return _context.Participantes.Any(e => e.Id == id);
        }

        private bool SalaExists(int id)
        {
            return _context.Salas.Any(e => e.Id == id);
        }

        private bool MensajeExists(int id)
        {
            return _context.Mensajes.Any(e => e.Id == id);
        }
    }
}
