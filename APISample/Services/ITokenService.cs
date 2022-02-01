using APISample.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APISample.Services
{
    public interface ITokenService
    {
        /// <summary>
        /// TokenDto response dönecek olan method 
        /// </summary>
        /// <returns></returns>
        Task<TokenDto> GenerateToken(IEnumerable<Claim> claims);

    }
}
