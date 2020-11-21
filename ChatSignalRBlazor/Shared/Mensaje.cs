using System;
using System.Collections.Generic;
using System.Text;

namespace ChatSignalRBlazor.Shared
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public DateTime? Fecha_Hora { get; set; }
        public int? SalaId { get; set; }
        public int? ParticipanteId { get; set; }
    }
}
