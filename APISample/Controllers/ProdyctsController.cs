using APISample.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Controllers
{
    //bir sayfada iki get fonk olamaz dediği zaman bu çözüm yolunu kullanabilirsin action ekleme. MVC mantığına dönüyor böyle yapınca 

    //[Route("api/[controller]/[action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdyctsController : ControllerBase
    {

        [HttpGet("product")] //üstteki routeı ellemeden yönlendirmeleri burdan yapman gerekiyor
        public List<ProductDto> GetProduct()
        {
            return new List<ProductDto>();
        }


        [HttpGet("product2")] //statik tanımlama bunlar yukarıdaki api/controller/product2 olur url şekli
        public IActionResult GetProducts()
        {
            //actionları IAvction tipinde genelde işaretlenir. eğer bir get isteği ise ok result ile 200 status code dönülür. 

            var model = new List<ProductDto>
            {
                new ProductDto
                {
                    Id=Guid.NewGuid().ToString(),
                    Name="P1",
                    Price=10,
                    Stock=20
                },

                new ProductDto
                {
                    Id=Guid.NewGuid().ToString(),
                    Name="P2",
                    Price=40,
                    Stock=20
                }
            };

            //httpget işlemlerinde return ok dönülür başarılı olduğuna dair işlemin 
            return Ok();
        }

        //bu şekilde id deeri dışarıdan dinamik olarak alınabiliyor. --> Attribute routing
        [HttpGet("v1/{id?}")]

        //routeda id tanımlamadan sadece id yi tanımlayıp uery string tarzında da alabilirsin 
        public IActionResult GetProductbyId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            return Ok(new ProductDto
            {
                Id = id,
                Name = "deneme",
                Price = 3,
                Stock = 3
            });
        }

        [HttpPost("create-prodycts-v1")]
        public IActionResult CreateProduct([FromBody] ProductDto model )
        {
            //frombody attriubute ile apite gönderilen dosyayı application-json formatında alınır.
            //eğer www.urlformencoded şejlinde alınacak ise fromform kullanılır.
            //farklı şekillerde post ile veri taşınabilir
            //fromheader, fromquery, gibi

            return Created($"api/prodycts/v1/{model.Id}", model);


        }

        [HttpPost("create-v2")]
        public IActionResult CreateProduct2([FromForm] ProductDto model)
        {
            //frombody attriubute ile apite gönderilen dosyayı application-json formatında alınır.
            //eğer www.urlformencoded şejlinde alınacak ise fromform kullanılır.
            //farklı şekillerde post ile veri taşınabilir
            //fromheader, fromquery, gibi

            return Created($"api/prodycts/v1/{model.Id}", model);


        }

        //get ve post için headerden bilgi gönderebilirsin
        //posttan 5 tane veri yollama şekli var, fromform-fromquery-fromheader-frombody-fromroute






    }

    

}
