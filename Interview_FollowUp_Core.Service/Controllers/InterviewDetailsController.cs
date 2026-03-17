using Microsoft.AspNetCore.Mvc;


namespace Interview_FollowUp_Core.Service.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InterviewDetailsController : Controller
    {
       


        [HttpGet]
        public IActionResult GetInterviewDetails()
        {
            
            return Ok("Interview details fetched successfully.");
        }
    }
}
