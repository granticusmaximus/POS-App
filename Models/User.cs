using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_app.Models
{
    public class User
    {
        [Key]
        public int UID {get;set;}
        public string Password {get;set;}

        [ForeignKey("UserRole")]
        public int? ID {get;set;}
        public virtual UserRole AssignedRole {get;set;}
    }
}