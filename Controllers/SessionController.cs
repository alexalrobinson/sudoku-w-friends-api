using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SudokuAPI.Models;

namespace SudokuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {

        private readonly ILogger<SessionController> _logger;

        public SessionController(ILogger<SessionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ObjectResult GetSession([FromRoute] Guid id)
        {
            // return all information related to the session
        }

        [HttpPost]
        public ObjectResult CreateNewSession([FromBody] SessionRequest request)
        {
            // generate a new session GUID and add starting user, return SessionResponse object
        }

        [HttpPut]
        public ObjectResult JoinSession([FromBody] string name)
        {
            // add user to session if session not locked
        }
    }
}
