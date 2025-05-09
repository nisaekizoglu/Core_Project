using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        ContactManager contactManger = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManger.TGetList();
            return View(values);
        }
    }
}
