using Microsoft.AspNetCore.Mvc;

namespace Tpd.Language.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController: ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Test() {
            return "Language.WebApi";
        }
    }
}
