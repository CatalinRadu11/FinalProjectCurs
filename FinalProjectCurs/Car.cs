using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{
    public class Car
    {
        //public FuelType Fuel => FuelType.Benzina;
        public CarModel Model { get; set; }

        public int MakeYear { get; set; }
        public int Price { get; set; }

        public Car (CarModel model, int makeyear, int price)
        {
            this.Model = model;
            this.MakeYear = makeyear;
            this.Price = price;
        }
    }
}
