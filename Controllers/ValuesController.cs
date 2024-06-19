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
        [HttpGet]
        public string Get2()
        {
            return "helllo2";

        }
        public string devolepment()
        {
            return "helllo2";

        }
    }
}
