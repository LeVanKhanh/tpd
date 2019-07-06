using Microsoft.AspNetCore.Mvc;
using Tpd.MultiLanguage;

namespace Tpd.Example.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IResourceStore _resourceStore;
        public TestController(IResourceStore resourceStore)
        {
            _resourceStore = resourceStore;
        }

        [HttpGet]
        public ActionResult TestGet()
        {
            return Ok("Example");
        }

        [HttpGet]
        [Route("GetLanguage")]
        public ActionResult<string> GetLanguage(string culture, string name)
        {
            return _resourceStore[culture, name];
        }
    }
}
