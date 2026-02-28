using CleanArchitecture.Application.UserCases.CreateUser;
using CleanArchitecture.Application.UserCases.GetAllUser;
using CleanArchitecture.Application.UserCases.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllUserResponse>>> GetAllUser()
        {
            var response = await _mediator.Send(new GetAllUserRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserResponse>> CreateUser(CreateUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateUserResponse>> UpdateUser(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id) return BadRequest();

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
