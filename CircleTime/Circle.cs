using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    class Circle
    {
        public double Radius { get; set; }
        public double Circumference => Radius * Math.PI * 2;
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            string output = $"Radius: {Radius,2}\n" + $"Circumference: {Circumference,2}\n" + $"Area: {Area,2}";
            return output;
        }

        public double CalculateCircumference()
        {
            return Circumference;
        }
        public double CalculateArea()
        {
            return Area;
        }



    }
}