using CERAXLAN.Core.Application.Requests;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.CreateUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.DeleteUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.UpdateUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Models;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetByIdUser;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetListUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CERAXLAN.OKR.UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdUserQuery getByIdUserQuery)
        {
            UserDto result = await Mediator.Send(getByIdUserQuery);
            return Ok(result);
        }

        [HttpGet("GetFromAuth")]
        public async Task<IActionResult> GetFromAuth()
        {
            GetByIdUserQuery getByIdUserQuery = new() { Id = GetUserIdFromRequest() };
            UserDto result = await Mediator.Send(getByIdUserQuery);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()//([FromQuery] PageRequest pageRequest)
        {
            PageRequest pageRequest = new PageRequest();
            var getListUserQuery = new GetListUserQuery() { PageRequest = pageRequest };
            UserListModel result = await Mediator.Send(getListUserQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
        {
            CreatedUserDto result = await Mediator.Send(createUserCommand);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
        {
            UpdatedUserDto result = await Mediator.Send(updateUserCommand);
            return Ok(result);
        }

        //[HttpPut("FromAuth")]
        //public async Task<IActionResult> UpdateFromAuth([FromBody] UpdateUserFromAuthCommand updateUserFromAuthCommand)
        //{
        //    updateUserFromAuthCommand.Id = getUserIdFromRequest();
        //    UpdatedUserFromAuthDto result = await Mediator.Send(updateUserFromAuthCommand);
        //    return Ok(result);
        //}

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserCommand deleteUserCommand)
        {
            DeletedUserDto result = await Mediator.Send(deleteUserCommand);
            return Ok(result);
        }
    }
}
