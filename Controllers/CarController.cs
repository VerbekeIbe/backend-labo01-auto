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

        // constructor
        public CarController()
        {
            if(_brands == null)
            {
                _brands = new List<Brand>();
                _brands.Add(new Brand(){
                    BrandId = 1, Name = "Volvo", Country = "Zweden"
                });
                _brands.Add(new Brand(){
                    BrandId = 2, Name = "Opel", Country = "Duitsland"
                });
                _brands.Add(new Brand(){
                    BrandId = 3, Name = "Citroën", Country = "Frankrijk"
                });
            }


            if(_carModels == null)
            {
                _carModels = new List<CarModel>();
                _carModels.Add(new CarModel(){
                    CarModelId = 1, Name = "Xc40", Brand = "Volvo"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 2, Name = "Xc60", Brand = "Volvo"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 3, Name = "Xc90", Brand = "Volvo"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 4, Name = "Astra", Brand = "Opel"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 5, Name = "Corsa", Brand = "Opel"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 6, Name = "Mokka", Brand = "Opel"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 7, Name = "Berlingo", Brand = "Citroën"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 8, Name = "Picasso", Brand = "Citroën"
                });
                _carModels.Add(new CarModel(){
                    CarModelId = 9, Name = "Cactus", Brand = "Citroën"
                });
            }
        }

        //API-Routes
        

        
    }
}
