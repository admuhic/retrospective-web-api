using Microsoft.AspNetCore.Mvc;
using RetrospectiveWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetrospectiveWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetrospectiveUserController : ControllerBase
    {
        // POST api/<RetrospectiveUserController>
        [HttpPost("postmessage")]
        public void Post([FromBody] Message message)
        {
            // TODO: Implement post message
        }
    }
}
