using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv3Homework
{
    public static class Db
    {
        public static List<Vehicle> vehicles = new List<Vehicle>();
        
    }
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle) 
        {
            if (vehicle.ID == 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction == 0)
            {
                return false;
            }

            return true;
        }
    }

       
}
