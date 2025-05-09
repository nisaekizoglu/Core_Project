using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Announcement announcement = announcementManager.TGetById(id);
            return View(announcement);
        }
    }
}
