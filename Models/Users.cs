using System;
using System.ComponentModel.DataAnnotations;

namespace Hostels.Models
{
    public class Users
    {
        [Key]
        public int UseId { get; set; }

        [Required]
        [MaxLength(60)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public int Age { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public Roles Roles { get; set; }
    }
}
