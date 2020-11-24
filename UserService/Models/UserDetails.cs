using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class UserDetails
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public string CUIL { get; set; }

        public DateTime FechaNac { get; set; }

        public string Direccion { get; set; }

        public string Provincia { get; set; }

        public string Pais { get; set; }

        public string Foto { get; set; }

        public int IdEmpresa { get; set; }

    }
}
