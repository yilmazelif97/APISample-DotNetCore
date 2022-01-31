using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Dtos
{
    public class VehicleLocationDto
    {
        [FromQuery]
        public string Latitude { get; set; }

        [FromQuery]
        public string Longtitude { get; set; }

        [FromQuery]
        public string TrackingNumber { get; set; }

    }
}
