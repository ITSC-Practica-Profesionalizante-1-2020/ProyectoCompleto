using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class UserEMPRESA : EntityBase
    {

        
        public Empresa Empresa { get; set; }
      
        public Cliente Cliente { get; set; }
    }
}
