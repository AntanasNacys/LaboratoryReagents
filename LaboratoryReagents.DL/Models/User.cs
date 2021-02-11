using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryReagents.DL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(20)]
        public string Username { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        

    }
}
