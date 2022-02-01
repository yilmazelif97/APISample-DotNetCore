using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Dtos
{

    /// <summary>
    /// end-userdan authenticate olurken alınacak değerler
    /// grand-type izin tipi oluyor yani username ve password ile resorce owner bazlı izin default olarak set edildi. 
    /// </summary>
    public class AuthDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string GrandType { get; set; } = "password";

    }

    public static class GrandType
    {
        public const string Password = "password";
        public const string ClientCredentials = "client-credentials";
    }

}
