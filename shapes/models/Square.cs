using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.models
{
    public class Square : Shape
    {
        public Square(double side, string color) : base(color)
        {
            Side = side;
        }

        public double Side { get; set; }

        public override double Area => this.Side * this.Side;

        public override string Type { get => Constants.Square; }
    }
}
