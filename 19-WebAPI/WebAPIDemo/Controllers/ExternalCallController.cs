using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.ExternalCall;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalCallController : ControllerBase
    {
        private readonly IExternalData _data;

        public ExternalCallController(IExternalData data)
        {
            _data = data;
        }

        // api(externalcall/id
        [HttpGet("{id}")] public async Task<ActionResult<Person>> GetById(int id)
        {
            var response = await _data.GetById(id);
            return response;
        }
    }
}
