using BusinessLayer.Concrete;
using Core_Project.ViewComponents.Contact;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message p)
        {
            SendMessageManager messageManger = new SendMessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesajın kaydedildiği anı veritabanına yansıtmak için
            p.Status = true;
            messageManger.TAdd(p);
            return PartialView();
        }
    }
}
