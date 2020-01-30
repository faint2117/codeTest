using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.models
{
    public class Triangule : Shape
    {
        public Triangule(double baseS, double height, string color) : base(color)
        {
            Base = baseS;
            Height = height;
        }

        public double Base { get; set; }

        public double Height { get; set; }

        public override double Area => this.Base * this.Height / 2;

        public override string Type { get => Constants.Triangule; }
    }
}
