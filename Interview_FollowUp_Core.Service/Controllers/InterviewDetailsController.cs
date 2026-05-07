using Interview_FollowUp_Core.Service.Repository;
using Microsoft.AspNetCore.Mvc;


namespace Interview_FollowUp_Core.Service.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InterviewDetailsController : Controller
    {
        private readonly IInterviewRepository _repo;

        public InterviewDetailsController(IInterviewRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetInterviews()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);
        }
    }
}
