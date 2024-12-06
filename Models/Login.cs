using System.ComponentModel.DataAnnotations;

namespace slot_scheduler.Models
{
    public class Login
    {

        [Key]
        public string? Email { get; set; }
        public string? Password { get; set; }
     
    }
}
