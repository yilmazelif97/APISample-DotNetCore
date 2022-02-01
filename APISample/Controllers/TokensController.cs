using APISample.Dtos;
using APISample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace APISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly ITokenService _tokenservice;

        public TokensController(ITokenService tokenservice)
        {
            _tokenservice = tokenservice;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] AuthDto model)
        {
            if (model.Username =="mert" && model.Password=="1234" && model.GrandType == GrandType.Password)
            {
                //acces token da saklanacak bilgiler 
                var claims = new List<Claim>
                {
                    new Claim("sub","1"),
                    new Claim("username","mert")
                };

                return Ok(await _tokenservice.GenerateToken(claims));
            }
            //eğer sistemde kayıtlı kullancı değilse hata döner
            return Unauthorized();


        }
    }
}
