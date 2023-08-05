using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv3Homework
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"{YearOfProduction}, {Color}");
        }
    }
}
