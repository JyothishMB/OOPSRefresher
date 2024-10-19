using MediatorDemo.Application.Employees.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployeeById([FromRoute]int id)
        {
            var result = _mediator.Send(new GetEmployeeQuery() { Id = id });
            return Ok(result);
        }
    }
}
