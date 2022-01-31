using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Dtos
{
    public class AuthController : ControllerBase
    {


        [HttpPost("client-credentials")]
        public IActionResult ValidateCreditCredentials([FromHeader] ClientHeadersDto model)
        {
            //frombody attriubute ile apite gönderilen dosyayı application-json formatında alınır.
            //eğer www.urlformencoded şejlinde alınacak ise fromform kullanılır.
            //farklı şekillerde post ile veri taşınabilir
            //fromheader, fromquery, gibi

            //eğer client_credentials gibi api ya configurasyon amaçlı data gönderilecek ise bu durumda FromHeader kullanılır. FromHeaderdan gönderilen veriler için OK türünde result döner. sunucuya data elimde var ben bu kişiyim diye belirtmek için fromheaderdan veri gönderilir. 

            //apide olmayan yeni bir kaynak açmak için Created 201 result döndürülür

            return Ok(model);


        }


    }
}
