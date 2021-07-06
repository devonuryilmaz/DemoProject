using BackendDemoProject.Core.Dto;
using BackendDemoProject.Core.Entities;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Core.Services
{
    public interface ITokenService
    {
        Response<TokenDto> CreateToken(User user);
    }
}
