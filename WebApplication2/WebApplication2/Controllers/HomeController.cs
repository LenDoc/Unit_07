using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    int firstVal = 10;
        //    int secondVal = 2;
        //    int result = firstVal / secondVal;

        //    ViewBag.Message = "Отладка приложения ASP.NET MVC!";

        //    return View(result);
        //}
        public interface IEmailSender
        {
            void SendEmail();
        }
        public class MyEmailSender : IEmailSender
        {
            public void SendEmail() { }
        }

        public class PasswordResetHelper
        {
            public void ResetPassword()
            {
                IEmailSender mySender = new MyEmailSender();
                // ...вызов методов интерфейса для конфигурировании настроек электронной почты... 
                mySender.SendEmail();
            }
        }
        [HttpGet]
        public ViewResult AdminController()
        {
            return View();
        }

    }
    //IEmailSender sender = new MyEmailSender();
    //helper = new PasswordResetHelper(sender);


}