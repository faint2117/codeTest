using shapes.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        public static List<Shape> ShapesList { get; set; }
        static void Main(string[] args)
        {
            string menuOption;
            bool run = true;
            ShapesList = new List<Shape>();

            while (run)
            {
                Console.WriteLine("Please introduce the command or * to close the program");
                menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "*":
                        run = false;
                        break;
                    default:
                        var inputs = menuOption.ToLower().Split(' ');
                        switch (inputs[0])
                        {
                            case "add":
                                parseShape(inputs, ShapesList);
                                break;
                            case "list":
                                ShowShapes(inputs, ShapesList);
                                break;
                            default:
                            Console.WriteLine("Input invalid");
                                break;
                        }
                        break;
                }
            }
        }

        static Shape parseShape(string[] value, List<Shape> list)
        {
            var parameters = value[3].Split(',');
            switch (value[1])
            {
                case Constants.Square:
                    list.Add(new Square(double.Parse(parameters[0]), value[2]));
                    break;
                case Constants.Circle:
                    list.Add(new Square(double.Parse(parameters[0]), value[2]));
                    break;
                case Constants.Triangule:
                    list.Add(new Triangule(double.Parse(parameters[0]), double.Parse(parameters[1]), value[2]));
                    break;
                case Constants.Rectangle:
                    list.Add(new Rectangle(double.Parse(parameters[0]), double.Parse(parameters[1]), value[2]));
                    break;
                case Constants.Trapezoid:
                    list.Add(new Trapezoid(double.Parse(parameters[0]), double.Parse(parameters[1]), double.Parse(parameters[2]), value[2]));
                    break;
                default:
                    Console.WriteLine("Input invalid");
                    break;
            }
            return null;
        }

        static void ShowShapes(string[] value, List<Shape> list)
        {
            if (value.Length == 2)
            {
                list= list.Where(shape => shape.Type.Equals(value[1], StringComparison.OrdinalIgnoreCase)).ToList();
            }

            list = list.OrderBy(x => x.Area).ThenBy(x => x.Color).ToList();
            list.ForEach(shape => Console.WriteLine("{0} {1} {2}", shape.Type, shape.Area, shape.Color));
        }
    }
}
