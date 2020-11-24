using SharedModels.RoomService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SharedModels.ChatService
{
    public class Mensaje : EntityBase
    {
        public int? EmisorId { get; set; }
        [ForeignKey("EmisorId")]
        public Participante ParticipanteEmisor { get; set; }
        public int? ReceptorId { get; set; }
        [ForeignKey("ReceptorId")]
        public Participante ParticipanteReceptor { get; set; }
        public int? SalaId { get; set; }
        [ForeignKey("SalaId")]
        public Sala Sala { get; set; }
        public string? Contenido { get; set; }
        public DateTime? Hora_Fecha_Envio { get; set; }
        public string? Url_Archivo { get; set; }
        public bool Privado { get; set; }
    }
}