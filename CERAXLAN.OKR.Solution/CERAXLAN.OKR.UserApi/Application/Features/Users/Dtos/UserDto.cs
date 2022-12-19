using CERAXLAN.OKR.UserApi.Application.Common;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos
{
    public class UserDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
