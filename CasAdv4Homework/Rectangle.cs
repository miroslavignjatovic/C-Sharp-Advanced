using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasAdv4Homework
{
    public  class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
