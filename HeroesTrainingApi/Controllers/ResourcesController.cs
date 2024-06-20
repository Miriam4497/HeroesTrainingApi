using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace HeroesTrainingApi.Controllers
{
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        [HttpGet("api/resources")]
        [Authorize()]
        public IActionResult GetResources()
        {
            return Ok($"protected resources, username: {User.Identity!.Name}");
        }
    }
}