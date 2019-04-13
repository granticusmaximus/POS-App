using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pos_app.Models
{
    public class UserRole
    {
        [Key]
        public int URID {get;set;}
        public string RoleTitle {get;set;}

    }
}