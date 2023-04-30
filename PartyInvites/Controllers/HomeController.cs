using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";

            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {

            if (ModelState.IsValid)
            {
                // Нужно отправить данные нового гостя по электронной почте 
                // организатору вечеринки.
                //MailMessage message = new MailMessage();
                //message.From = new MailAddress(guest.Email);
                //message.To.Add(new MailAddress("lotosofhellforyou@gmail.com"));
                //message.Subject = "Ответ на приглашение";
                //message.Body = $"Имя: {guest.Name}\nEmail: {guest.Email}\nТелефон: {guest.Phone}\nПримет участие: {guest.WillAttend}";

                //SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                //smtpClient.UseDefaultCredentials = false;
                //smtpClient.Credentials = new System.Net.NetworkCredential("guest@gmail.com", "password");
                //smtpClient.EnableSsl = true;
                //smtpClient.Send(message);
                return View("Thanks", guest);
            }
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}