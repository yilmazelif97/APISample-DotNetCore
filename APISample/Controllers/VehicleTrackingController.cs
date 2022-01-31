using APISample.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Controllers
{
    public class VehicleTrackingController: ControllerBase
    {

        [HttpPost("tracking-location")]
        public IActionResult Track([FromQuery] VehicleLocationDto model, [FromHeader] string trackid)
        {
            return Ok();
        }


    }
}

//dosya isimlendirmeleri yaparken verinin geldiği yer se mesela query, header gibi bunların bilgisini isimlenidmrede yap