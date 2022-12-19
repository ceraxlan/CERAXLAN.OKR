using CERAXLAN.Core.Security.Entities;

namespace CERAXLAN.OKR.UserApi.Application.Services.UserService
{
    public interface IUserService
    {
        public Task<User?> GetByEmail(string email);
        public Task<User> GetById(int id);
        public Task<User> Update(User user);
    }
}
