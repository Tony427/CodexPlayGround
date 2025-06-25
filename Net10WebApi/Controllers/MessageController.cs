using Microsoft.AspNetCore.Mvc;
using Net10WebApi.Services;

namespace Net10WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _service;
        public MessageController(IMessageService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_service.GetMessages());
        }

        [HttpPost]
        public IActionResult Post([FromBody] string message)
        {
            _service.AddMessage(message);
            return CreatedAtAction(nameof(Get), null);
        }
    }
}
