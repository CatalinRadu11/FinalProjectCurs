using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectCurs
{

    [Serializable]
    public class Client
    {
        public Car Model { get; set; }
        public String Nume { get; set; }

        public DateTime DataInceput { get; set; }

        public DateTime DataFinal { get; set; }

        public Client()
        {

        }

        public Client(String Nume, Car Model, DateTime di, DateTime df)
        {
            this.Model = Model;
            this.Nume = Nume;
            this.DataFinal = df;
            this.DataInceput = di;
        }

    }
}
