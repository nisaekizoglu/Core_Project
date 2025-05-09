using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListReceiverMessages(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writerMessageManager.GetListSenderMessages(p);
            return View(messageList);
        }
        [Route("MessageDetail/{id}")]
        public IActionResult MessageDetail(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }
        [Route("SenderMessageDetail/{id}")]
        public IActionResult SenderMessageDetail(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetById(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("")]
        [Route("AddMessage")]
        public IActionResult AddMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("AddMessage")]
        public async Task<IActionResult> AddMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " +values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y=>y.Name + " "+ y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
