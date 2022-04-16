using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hostels.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(10)]
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
