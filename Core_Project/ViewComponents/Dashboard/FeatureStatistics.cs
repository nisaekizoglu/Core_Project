using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        Context c = new Context();
        
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2=c.Messages.Count();
            ViewBag.v3=c.Experiences.Count();
            ViewBag.v4=c.Services.Count();
            return View();
        }
    }
}
