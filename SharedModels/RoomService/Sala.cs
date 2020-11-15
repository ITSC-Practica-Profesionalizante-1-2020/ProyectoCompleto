using SharedModels;
using SharedModels.RoomService;
using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Sala : EntityBase
{
    public string NombreSala { get; set; }
    public DateTime? FechaBaja { get; set; }
    public DateTime? FechaUltimoUso { get; set; }
    public TimeSpan? TiempoAcumuladoUso { get; set; }
 
    public string PasswordSala { get; set; }
    public bool? ControlAsistencia { get; set; }
    public bool? EsPersistente { get; set; }

}