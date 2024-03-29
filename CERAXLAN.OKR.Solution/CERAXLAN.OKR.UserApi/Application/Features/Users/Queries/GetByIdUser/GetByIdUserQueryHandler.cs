﻿using AutoMapper;
using CERAXLAN.Core.Security.Entities;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Dtos;
using CERAXLAN.OKR.UserApi.Application.Features.Users.Rules;
using CERAXLAN.OKR.UserApi.Application.Services.Repositories;
using MediatR;

namespace CERAXLAN.OKR.UserApi.Application.Features.Users.Queries.GetByIdUser
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;

        public GetByIdUserQueryHandler(IUserRepository userRepository, IMapper mapper,
                                       UserBusinessRules userBusinessRules)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
        }


        public async Task<UserDto> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            await _userBusinessRules.UserIdShouldExistWhenSelected(request.Id);

            User? user = await _userRepository.GetAsync(b => b.Id == request.Id);
            UserDto userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
