using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarsAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsAPI.API
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        static List<Car> _cars = new List<Car>
        {
            new Car(1, 1937, "Delahaye", "135", "http://motoburg.com/images/delahaye-135-03.jpg", "The Delahaye 135 raced in many races across Europe, and could achieve up to 110hp.", "Coupe des Alpes"),
            new Car(2, 1963, "Jaguar", "E-Type", "http://cdn2.autoexpress.co.uk/sites/autoexpressuk/files/8/30/250412hero.jpg", "The Jaguar E-Type is considered one of the most attractive cars ever made, and included many advanced features and excellent performance.", "XK-E in North America"),
            new Car(3, 1953, "Rolls Royce", "Silver Dawn", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Rolls_Royce_Silver_Dawn_1953_4566cc.JPG/1920px-Rolls_Royce_Silver_Dawn_1953_4566cc.JPG", "The Silver Dawn featured an in-line six cylinder engine and a 4 speed gearbox", "Dawn"),
            new Car(4, 1966, "Austin Healey", "3000", "http://www.remarkablecars.com/main/austin-healey/austin-healey-00010.jpg", "The 3000 Mark III featured a 150hp engine, and was raced in circuits around the world.", "Big Healey"),
            new Car(5, 1955, "Chevrolet", "Bel Air", "http://coolridesonline.net/wp-content/uploads/2015/10/STABIL-Rick-Boutwell-1955-Chevrolet-Bel-Air-Hardtop.jpg", "The Bel Air had a V8 engine option, which could achieve up to 180hp.", "Bel Air")
        };

        [HttpGet]
        public List<Car> Get()
        {
            return _cars;
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            Car returnCar = null;
            foreach (Car car in _cars)
            {
                if (car.Id == id)
                {
                    returnCar = car;
                }
            }
            return returnCar;
        }
    }
}
