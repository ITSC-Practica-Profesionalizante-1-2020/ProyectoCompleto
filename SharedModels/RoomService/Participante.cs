using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModels.RoomService
{

    public class Participante :EntityBase
    {
        //public string Email { get; set; }
        
        public string Token { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public List<Asistencia> Asistencia { get; set; }
        //[NotMapped]
        //public List<Sala> Salas { get; set; }
        public Roles Rol { get; set; }
        public Cliente Cliente{ get; set; }
        
    }
    public enum Roles
    {
        Propietario = 1,
        Administrador = 2,
        Invitado = 3,
        Oyente = 4
    };

}

