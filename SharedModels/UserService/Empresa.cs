using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class Empresa : Usuario
    {
        [Required]
        public string RazonSocial { get; set; }
        [Required]
        public string CUIT { get; set; } //CUIT EMPRESARIAL 
        public DateTime FechaInicioActividades { get; set; }
        [Required]
       
        public string Logo { get; set; }


    }
}
