using CERAXLAN.Core.Persistence.Repositories;
using CERAXLAN.Core.Security.Entities;
using CERAXLAN.OKR.UserApi.Application.Services.Repositories;
using CERAXLAN.OKR.UserApi.Persistence.Context;

namespace CERAXLAN.OKR.UserApi.Persistence.Repositories
{
    public class UserRepository : EfRepositoryBase<User, UserContext>, IUserRepository
    {
        public UserRepository(UserContext context) : base(context)
        {
        }
    }
}
