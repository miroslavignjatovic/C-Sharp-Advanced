using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv3Homework
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countries { get; set; }

        public override void PrintVehicle()
        { 
            Console.WriteLine($"{Type}, {Countries}");
        }
    }
}
