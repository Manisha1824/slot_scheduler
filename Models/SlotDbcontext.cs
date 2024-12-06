using Microsoft.EntityFrameworkCore;

namespace slot_scheduler.Models
{
    public class SlotDbcontext:DbContext
    {
        public SlotDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Login> loginDetails { get; set; }
        public DbSet<RegisterUser> registerDetails { get; set; }
        public DbSet<SlotDetails> SlotDetails { get; set; }
        //public DbSet<SlotForm> SlotformDetails { get; set; }
    }
}
