using System;

namespace Geometry
{
    public class Geometry
    {
        public static double TriangleArea(double a, double b) => (.5 * a * b);

        public static double Hypo(double sideA, double sideB) => Math.Sqrt((sideA + sideA) * (sideB + sideB));
    }
}
