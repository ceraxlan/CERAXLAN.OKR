using CERAXLAN.Core.Application.Rules;
using CERAXLAN.Core.CrossCuttingConcerns.Exceptions;
using CERAXLAN.Core.Security.Entities;
using CERAXLAN.Core.Security.Hashing;
using CERAXLAN.OKR.UserApi.Application.Features.Auths.Constants;
using CERAXLAN.OKR.UserApi.Application.Services.Repositories;


namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Rules
{
    public class UserBusinessRules : BaseBusinessRules
    {
        private readonly IUserRepository _userRepository;

        public UserBusinessRules(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task UserIdShouldExistWhenSelected(int id)
        {
            User? result = await _userRepository.GetAsync(b => b.Id == id);
            if (result == null) throw new BusinessException(AuthMessages.UserDontExists);
        }

        public Task UserShouldBeExist(User? user)
        {
            if (user is null) throw new BusinessException(AuthMessages.UserDontExists);
            return Task.CompletedTask;
        }

        public Task UserPasswordShouldBeMatch(User user, string password)
        {
            if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                throw new BusinessException(AuthMessages.PasswordDontMatch);
            return Task.CompletedTask;
        }
    }
}
