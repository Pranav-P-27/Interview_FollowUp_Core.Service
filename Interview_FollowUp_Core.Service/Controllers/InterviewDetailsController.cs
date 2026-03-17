using Microsoft.AspNetCore.Mvc;


namespace Interview_FollowUp_Core.Service.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InterviewDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
