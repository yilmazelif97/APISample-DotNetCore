using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Dtos
{
    /// <summary>
    /// 3600 saniye deperini döndürür
    /// </summary>
    public static class TokenExpireDateHelper
    {
        public static int GetExpireDate = (int)(DateTime.Now.AddHours(1) - DateTime.Now).TotalSeconds;
    }

    //kullanıcıya(end-user) a dönülecek respond değeri
    public class TokenDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int ExpireDatMinutes { get; set; } = TokenExpireDateHelper.GetExpireDate; //expire bilgisi kaç saniye sonra yok olacağı bilgisi
                                                                                                                 


    }
}
