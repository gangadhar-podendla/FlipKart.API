using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlipKart.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get() {
            return "helllo";

        }
    }
}
