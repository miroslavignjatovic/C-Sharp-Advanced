using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv3Homework
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Type { get; set; }   
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }   
        
        public virtual void PrintVehicle()
        {
            Console.WriteLine($"{ID}, {Type}, {YearOfProduction}");
        }
    }
}
