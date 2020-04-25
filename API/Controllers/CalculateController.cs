using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalculateController(IMediator mediator)
        {
            _mediator = mediator;
        }


    }
}
