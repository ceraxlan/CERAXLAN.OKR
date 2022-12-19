using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Models
{
    public class UserListModel : BasePageableModel
    {
        public IList<UserListDto> Items { get; set; }
    }
}
