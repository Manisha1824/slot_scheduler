using Microsoft.AspNetCore.Mvc;

namespace slot_scheduler.Controllers
{
    public class SlotController : Controller
    {
        private readonly SlotController context;

        public SlotController(SlotController context)
        {
            this.context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
