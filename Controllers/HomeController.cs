using Microsoft.AspNetCore.Mvc;
using slot_scheduler.Models;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace slot_scheduler.Controllers
{
    public class HomeController : Controller
    {
        private readonly SlotDbcontext context;

        public HomeController(SlotDbcontext dbcontext)
        {
            this.context = context;

        }
        //public IActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Login(string username, string password)
        //{
        //    var users = context.registerDetails.FirstOrDefault(x => x.Username == username);
        //    var pass = context.registerDetails.FirstOrDefault(x => x.Password == password);

        //    if (users != null && pass != null)
        //    {

        //        return RedirectToAction("SlotDetails", "Home");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("CustomError", "Invalid username or password");
        //    }
        //    return RedirectToAction("Login", "Home");
        //}
        //public IActionResult Registeration()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Add(RegisterUser user_Register)
        //{


        //    await context.registerDetails.AddAsync(user_Register);
        //    await context.SaveChangesAsync();
        //    return RedirectToAction("LoginPage", "Insepection");
        //}
        //public IActionResult SlotDetails()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult SlotDetails(string toEmail, IFormFile fileToAttach)
        //{
        //    try
        //    {
        //        // Retrieve email credentials from secure storage
        //        string fromEmail = "divyaparihar18@gmail.com"; // Replace with your email
        //        string mailPassword = ""; // Replace with your email password

        //        // Construct the email body
        //        string mailBody = GetEmailBody();

        //        // Email subject and title
        //        string mailTitle = "Slot Scheduler";
        //        string mailSubject = "Request for Slot Scheduler";

        //        // Create the mail message
        //        using (MailMessage message = new MailMessage(new MailAddress(fromEmail, mailTitle), new MailAddress(toEmail)))
        //        {
        //            message.Subject = mailSubject;
        //            message.Body = mailBody;
        //            message.IsBodyHtml = true;

        //            // Add the attachment
        //            message.Attachments.Add(new Attachment(fileToAttach.OpenReadStream(), fileToAttach.FileName));

        //            // Configure SMTP client and send email
        //            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
        //            {
        //                smtp.EnableSsl = true;
        //                smtp.Credentials = new NetworkCredential(fromEmail, mailPassword);
        //                smtp.Send(message);
        //            }

        //            // Set success message
        //            ViewBag.emailsentmessage = "Email sent successfully";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception or handle it appropriately
        //        ViewBag.emailsentmessage = "Failed to send email: " + ex.Message;
        //    }

        //    return View();
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
