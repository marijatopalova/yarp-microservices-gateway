using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMusic() => Ok(new { Message = "Music Service: Music List" });
    }
}
