using System;

namespace AreaShapesLib
{
    public class AreaShapes
    {
        public double СircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double TriangleArea(double a, double b, double c)
        {
            double p, S;

            p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
