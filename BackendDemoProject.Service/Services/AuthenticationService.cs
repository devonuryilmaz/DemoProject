using BackendDemoProject.Core.Dto;
using BackendDemoProject.Core.Entities;
using BackendDemoProject.Core.Services;
using BackendDemoProject.Core.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(ITokenService tokenService, IUserService userService, IUnitOfWork unitOfWork)
        {
            _tokenService = tokenService;
            _userService = userService;
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<TokenDto>> CreateTokenAsync(LoginDto loginDto)
        {
            if (loginDto == null)
                throw new ArgumentNullException(nameof(loginDto));

            var user = await _userService.GetByIdAsync(loginDto.ID);

            if (user == null)
                return Response<TokenDto>.Fail("Kullanıcı bulunamadı", 400);

            return _tokenService.CreateToken(user);
        }
    }
}
