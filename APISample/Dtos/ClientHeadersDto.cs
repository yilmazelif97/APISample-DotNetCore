using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Dtos
{
    public class ClientHeadersDto
    {

        //post ya da get isteğinde header üzerinden okuma yapılacak ise headerdan okunacak olan değerlerin fromheader attribute ı ile işaretlemen gerekir. 
        [FromHeader]
        public string ClientId { get; set; }

        [FromHeader]
        public string ClientSecret { get; set; }


    }
}
