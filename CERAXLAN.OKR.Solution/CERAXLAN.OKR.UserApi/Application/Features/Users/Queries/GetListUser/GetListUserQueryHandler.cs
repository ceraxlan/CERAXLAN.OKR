using AutoMapper;
using CERAXLAN.Core.Persistence.Paging;
using CERAXLAN.Core.Security.Entities;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Models;
using CERAXLAN.OKR.UserApi.Application.Services.Repositories;
using MediatR;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetListUser
{
    public class GetListUserQueryHandler : IRequestHandler<GetListUserQuery, UserListModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetListUserQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserListModel> Handle(GetListUserQuery request, CancellationToken cancellationToken)
        {
            IPaginate<User> users = await _userRepository.GetListAsync(index: request.PageRequest.Page,
                                                                       size: request.PageRequest.PageSize);
            UserListModel mappedUserListModel = _mapper.Map<UserListModel>(users);
            return mappedUserListModel;
        }
    }
}
