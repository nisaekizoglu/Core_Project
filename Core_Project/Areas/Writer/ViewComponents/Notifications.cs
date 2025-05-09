using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.ViewComponents
{
    public class Notifications : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
