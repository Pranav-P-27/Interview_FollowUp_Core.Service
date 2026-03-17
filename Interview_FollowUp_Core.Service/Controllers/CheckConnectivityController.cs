using Interview_FollowUp_Core.Service.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Interview_FollowUp_Core.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckConnectivityController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly CheckConnectivity _checkConnectivity;


        public CheckConnectivityController(IConfiguration configuration, CheckConnectivity checkConnectivity)
        {
            _configuration = configuration;
            _checkConnectivity = checkConnectivity;
        }

        [HttpGet("check-connection")]
        public IActionResult CheckConnection()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            bool isConnected = _checkConnectivity.CheckDatabaseConnection(connectionString);

            if (isConnected)
            {
                return Ok("Database Connected Successfully");
            }
            else
            {
                return StatusCode(500, "Database Connection Failed");
            }
        }

    }

}
