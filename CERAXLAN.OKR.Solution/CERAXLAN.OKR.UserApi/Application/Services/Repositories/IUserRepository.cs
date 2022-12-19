using CERAXLAN.Core.Persistence.Repositories;
using CERAXLAN.Core.Security.Entities;

namespace CERAXLAN.OKR.UserApi.Application.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}
