using APISample.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Services
{
    public class JwtTokenService : ITokenService
    {

        private readonly IConfiguration _configuration;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// json web token library kullanılacak
        /// JWT ile Token oluşturulur burda 
        /// </summary>
        /// <returns></returns>
        public async Task<TokenDto> GenerateToken(IEnumerable<Claim> claims)
        {
            //kuallcnı ile alaklı bilgilerin üzerinde tutulduğu nesne claimtype ve claimvalue olarak key-value pair şeklinde tutulur
            var token = new JwtSecurityToken
              (
                  issuer: _configuration["JWT:issuer"],
                  audience: _configuration["JWT:audience"],
                  claims: claims,
                  expires: DateTime.UtcNow.AddMinutes(1),
                  notBefore: DateTime.UtcNow,
                  signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SigningKey"])),
                          SecurityAlgorithms.HmacSha256)
              );

            var model = new TokenDto
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                RefreshToken = TokenHelper.GetToken()

        };

            return await Task.FromResult(model);



    }
    }
}
