using CERAXLAN.Core.Application.Pipelines.Authorization;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using MediatR;

using static CERAXLAN.OKR.UserApi.Application.Features.Users.Constants.OperationClaims;
using static CERAXLAN.OKR.UserApi.Domain.Constants.OperationClaims;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<DeletedUserDto>, ISecuredRequest
    {
        public int Id { get; set; }
        public string[] Roles => new[] { Admin, UserDelete };
    }
}
