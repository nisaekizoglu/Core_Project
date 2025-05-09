using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        SendMessageManager messageManger = new SendMessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //mesajın kaydedildiği anı veritabanına yansıtmak için
        //    p.Status = true;
        //    messageManger.TAdd(p);
        //    return View();
        //}
    
    }
}
