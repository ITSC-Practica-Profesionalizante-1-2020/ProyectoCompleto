using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class Usuario : EntityBase
    {
        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public IdentityUser IdentityUsuario { get; set; }
    }
}
