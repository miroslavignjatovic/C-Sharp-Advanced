using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv4Homework
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
