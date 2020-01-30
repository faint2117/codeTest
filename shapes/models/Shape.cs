using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes.models
{
    public abstract class Shape
    {
        public Shape(string color)
        {
            this.Color = color;
        }

        public string Color { get; set; }

        public abstract double Area { get; }

        public abstract string Type { get; }
    }
}
