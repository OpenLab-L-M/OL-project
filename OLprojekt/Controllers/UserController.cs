using Microsoft.AspNetCore.Mvc;
using OLprojekt.Models;

namespace OLprojekt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApplicationUser _extraction;

        public UserController(ILogger<UserController> logger, ApplicationUser extraction)
        {
            _extraction = extraction;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = new UserInfo
            {
                Xp = 1000,
                Guild = "internetovy Warriory"
            };
            return Ok(User);
        }

    }
}
