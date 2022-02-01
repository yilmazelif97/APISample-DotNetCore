using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace APISample.Services
{

    /// <summary>
    /// acces token ecpire olduğnda üretilecek olan bir string base64 formatında kod. bunu oluşturan userın hesabında refresh token bilgisini saklarız.
    /// ve access token expire olduğunda gidip bu refresh token bu kullanıcı için oluşmuş mu kontrolü yaparak yeni bir acces token üretilmesini sağlar
    /// </summary>
    public static class TokenHelper
    {
        public static string GetToken()
        {
                var randomNumber = new byte[32];
                string refreshToken = ""; //kendin oluşturuyorsun access token almak için belirli aralıklarda haber veriyor gib düşün 

                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomNumber);
                    refreshToken = Convert.ToBase64String(randomNumber);
                }

                return refreshToken;
            }
        



    }
}
