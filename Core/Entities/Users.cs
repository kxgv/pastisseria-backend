using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Users
    {
        public int Id {get; set;}
        public string Name { get; set;} = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; }
        public required string Password { get; set;}

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; } // Nombre de usuario único

        public bool IsAdmin { get; set; } = false;
    }
}
