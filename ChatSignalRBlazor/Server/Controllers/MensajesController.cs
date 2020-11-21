using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChatSignalRBlazor.Server.Data;
using ChatSignalRBlazor.Shared;
using ChatSignalRBlazor.Server.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace ChatSignalRBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        private readonly ChatSignalRBlazorServerContext _context;

        private readonly IHubContext<BroadcastHub> _hubContext;

        public MensajesController(ChatSignalRBlazorServerContext context, IHubContext<BroadcastHub> hubContext)
        {
            _context = context;

            _hubContext = hubContext;
        }

        // GET: api/mensajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensaje()
        {
            return await _context.Mensaje.ToListAsync();
        }

        // GET: api/mensajes/5  
        [HttpGet("{id}")]
        public async Task<ActionResult<Mensaje>> GetMensaje(int id)
        {
            var mensaje = await _context.Mensaje.FindAsync(id);

            if (mensaje == null)
            {
                return NotFound();
            }

            return mensaje;
        }

        // GET: api/Mensajes/bysala/5
        [HttpGet("bysala/{id}", Name = "bysala")]
        public async Task<ActionResult<IEnumerable<Mensaje>>> GetMensajeSala(int id)
        {
            var mensaje = _context.Mensaje.Where(s => s.SalaId == id).ToListAsync();

            if (mensaje == null)
            {
                return NotFound();
            }
            return await mensaje;
        }

        // POST: api/mensajes 
        [HttpPost]
        public async Task<ActionResult> PostMensaje(Mensaje mensaje)
        {
            _context.Mensaje.Add(mensaje);
            try
            {
                mensaje.Fecha_Hora = DateTime.Now;
                await _context.SaveChangesAsync();
                await _hubContext.Clients.All.SendAsync("ReceiveMessage");
            }
            catch (DbUpdateException)
            {
                if (MensajeExists(mensaje.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // DELETE: api/mensajes/5  
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mensaje>> DeleteMensaje(int id)
        {
            var mensaje = await _context.Mensaje.FindAsync(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            _context.Mensaje.Remove(mensaje);
            await _context.SaveChangesAsync();

            await _hubContext.Clients.All.SendAsync("ReceiveMessage");

            return mensaje;
        }

        private bool MensajeExists(int id)
        {
            return _context.Mensaje.Any(e => e.Id == id);
        }
    }
}  