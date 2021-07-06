using BackendDemoProject.Core.Dto;
using BackendDemoProject.Core.Entities;
using BackendDemoProject.Core.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SharedLibrary.Configurations;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BackendDemoProject.Service.Services
{
    public class TokenService : ITokenService
    {
        private readonly CustomTokenOptions _customTokenOptions;

        public TokenService(IOptions<CustomTokenOptions> customTokenOptions)
        {
            _customTokenOptions = customTokenOptions.Value;
        }

        private string CreateRefreshToken()
        {
            var numberByte = new Byte[32];

            using var random = RandomNumberGenerator.Create();

            random.GetBytes(numberByte);

            return Convert.ToBase64String(numberByte);
        }

        public Response<TokenDto> CreateToken(User user)
        {
            var accessTokenExpiration = DateTime.Now.AddMinutes(_customTokenOptions.AccessTokenExpiration);
            var refreshTokenExpiration = DateTime.Now.AddMinutes(_customTokenOptions.RefreshTokenExpiration);

            // Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_customTokenOptions.SecurityKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.ID.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenaa = tokenHandler.CreateToken(tokenDescriptor);

            var tokenDto = new TokenDto
            {
                AccessToken = tokenHandler.WriteToken(tokenaa),
                RefreshToken = CreateRefreshToken(),
                AccesTokenExpiration = accessTokenExpiration,
                RefreshTokenExpiration = refreshTokenExpiration
            };

            return Response<TokenDto>.Success(tokenDto, 200);
        }
    }
}
