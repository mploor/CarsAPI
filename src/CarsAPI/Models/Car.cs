using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Nickname { get; set; }

        public Car(int id, int year, string make, string model, string imageUrl, string description, string nickname)
        {
            Id = id;
            Year = year;
            Make = make;
            Model = model;
            ImageUrl = imageUrl;
            Description = description;
            Nickname = nickname;
        }
    }
}
