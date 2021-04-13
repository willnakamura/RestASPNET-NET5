using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestASPNET_NET5.Business;
using RestASPNET_NET5.Data.VO;

namespace RestASPNET_NET5.Controller
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonVO personVO)
        {
            if (personVO == null) return BadRequest();
            return Ok(_personBusiness.Create(personVO));
        }

        [HttpPut]
        public IActionResult Put([FromBody] PersonVO personVO)
        {
            if (personVO == null) return BadRequest();
            return Ok(_personBusiness.Update(personVO));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
