using System;
using System.Collections.Generic;
using backend_labo01_auto.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend_labo01_auto.Controllers
{
    [ApiController]
    [Route("api")]
    public class CarController : ControllerBase
    {
        private static List<Brand> _brands;
        private static List<CarModel> _carModels;

        public CarController()
        {
            
        }

        
        
    }
}
