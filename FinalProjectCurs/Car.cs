using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{

    [Serializable]
    public class Car
    {
        public FuelType Fuel { get; set; }
        public CarModel Model { get; set; }

        public int MakeYear { get; set; }
        public int Price { get; set; }
        public string Colour { get; set; }
        public string Transmission { get; set; }


        public Car(CarModel model, int makeyear, int price, string colour, string transmission, FuelType fuel)
        {
            this.Model = model;
            this.MakeYear = makeyear;
            this.Price = price;
            this.Colour = colour;
            this.Transmission = transmission;
            this.Fuel = fuel;

        }
    }
}
