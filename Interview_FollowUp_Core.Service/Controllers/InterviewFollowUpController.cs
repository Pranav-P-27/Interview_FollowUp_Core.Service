using Microsoft.AspNetCore.Mvc;

namespace Interview_FollowUp_Core.Service.Controllers
{
    public class InterviewFollowUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
