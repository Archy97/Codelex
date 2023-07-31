using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * (double)radius * 2;
            throw new NotImplementedException();
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return (double)(width * length);
            throw new NotImplementedException();
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)(ground * h * 0.5m);
            throw new NotImplementedException();
        }
    }
}
