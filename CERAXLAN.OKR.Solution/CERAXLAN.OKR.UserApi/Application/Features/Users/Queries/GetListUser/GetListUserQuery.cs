using CERAXLAN.Core.Application.Requests;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Models;
using MediatR;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetListUser
{
    public class GetListUserQuery : IRequest<UserListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
