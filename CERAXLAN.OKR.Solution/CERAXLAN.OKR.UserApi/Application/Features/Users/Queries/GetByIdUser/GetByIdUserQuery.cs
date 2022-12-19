using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using MediatR;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetByIdUser
{
    public class GetByIdUserQuery : IRequest<UserDto>
    {
        public int Id { get; set; }
    }
}
