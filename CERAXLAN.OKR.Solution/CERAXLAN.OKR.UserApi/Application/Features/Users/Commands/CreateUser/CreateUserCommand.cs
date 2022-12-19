using CERAXLAN.Core.Application.Pipelines.Authorization;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using MediatR;

using static CERAXLAN.OKR.UserApi.Application.Features.Users.Constants.OperationClaims;
using static CERAXLAN.OKR.UserApi.Domain.Constants.OperationClaims;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<CreatedUserDto>, ISecuredRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string[] Roles => new[] { Admin, UserAdd };
    }
}
