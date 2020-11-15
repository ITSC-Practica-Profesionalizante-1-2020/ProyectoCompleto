using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.RoomService
{
    public class SalaParticipante : EntityBase
    {
        
        public Sala Sala { get; set; }
        public Participante Participante { get; set; }

    }
}
