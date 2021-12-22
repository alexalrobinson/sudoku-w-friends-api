using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SudokuAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SudokuController : ControllerBase
    {

        private readonly ILogger<SudokuController> _logger;

        public SudokuController(ILogger<SudokuController> logger)
        {
            _logger = logger;
        }

        [HttpPut("{sessionid}/addnote")]
        public ObjectResult AddNote([FromRoute] Guid sessionid)
        {
            // Add note to specified box
        }

        [HttpPut("{sessionid}/assert")]
        public ObjectResult AssertValue([FromRoute] Guid sessionid)
        {
            // Add value to specified box, ends session if matches solution
        }
    }
}
