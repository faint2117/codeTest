using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.models
{
    public class Circle : Shape
    {
        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area => this.Radius * this.Radius;

        public override string Type { get => Constants.Circle; }
    }
}
