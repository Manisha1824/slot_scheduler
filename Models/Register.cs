using System.ComponentModel.DataAnnotations;

namespace slot_scheduler.Models
{
    public class RegisterUser
    {
   
        public int Id { get; set; }

        public string? Username { get; set; }
        [Key]
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
