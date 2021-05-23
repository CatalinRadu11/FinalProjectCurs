using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Fuel { get; set; }
        public int Price { get; set; }

        public Car(string model, int year, string fuel, int price)
        {
            this.Model = model;
            this.Year = year;
            this.Fuel = fuel;
            this.Price = price;
        }
    }
}
