using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SharedModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class Cliente : Usuario
    {

        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string CUIL { get; set; }
        [Required]
        public DateTime FechaNac { get; set; }

        public string Foto { get; set; }
        


    }
}