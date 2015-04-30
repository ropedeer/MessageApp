using System.Linq;
using System.Web.Mvc;
using MessageApp.ServiceReference1;
using MessageWCF;

namespace MessageApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly Service1Client _proxy;

        public MessageController()
        {
            _proxy = new Service1Client();
        }
        
        // GET: Message
        public ActionResult Index()
        {
            var model = GetMessages;
            return View(model);
        }

        private IOrderedEnumerable<MessageModel> GetMessages
        {
            get { return _proxy.GetMessages().OrderByDescending(m => m.DateOfMessage); }
        }
    }
}