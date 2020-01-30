using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.models
{
    public class Trapezoid : Shape
    {
        public Trapezoid(double base1, double base2, double height, string color) : base(color)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public double Base1 { get; set; }

        public double Base2 { get; set; }

        public double Height { get; set; }

        public override double Area => (this.Base1 + this.Base2)* this.Height / 2;

        public override string Type { get => Constants.Trapezoid; }
    }
}
