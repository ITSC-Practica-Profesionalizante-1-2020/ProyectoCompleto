using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class UserEMPRESA : EntityBase
    {

        [Required]
        public int IdEmpresa { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public Empresa Empresa { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
    }
}
