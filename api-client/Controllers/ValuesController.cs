using api_client.UseCases.Clients;
using communications;
using communications.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IActionResult Get()
        {
            var values = new string[] { "value1", "value2", "value3" };
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            var value = $"value{id}";
            return Ok(value);
        }

        // POST: api/Values
        [HttpPost]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        public ActionResult<ResponseClientJson> Post([FromBody] RequestClientJson request)
        {

           var useCase = new RegisterClientUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
