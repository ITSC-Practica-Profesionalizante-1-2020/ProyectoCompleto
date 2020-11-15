using SharedModels;
using SharedModels.RoomService;
using SharedModels.UserService;
using System;

public class Asistencia : EntityBase
{
    public int Id_Salas { get; set; }
    public Participante Participante { get; set; }
    public DateTime? FechaIngreso { get; set; }
    public DateTime? FechaEgreso { get; set; }
    public Roles Rol_Usuario { get; set; }

}