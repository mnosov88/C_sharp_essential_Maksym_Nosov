using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1_task1
{
    class Circle
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public double GetCircumference()
        {
            double length = 2 * Math.PI * Radius;
            return length;
        }
    }
}
