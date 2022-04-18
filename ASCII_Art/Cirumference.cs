using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cirumference : Shape
    {
        private Point _centerPoint;

        public Cirumference(ColourType colour) : base(colour)
        {
            Console.Write("Podaj współrzędne środka:\nX: ");
            int x, y;
            while (true)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Podana wartość nie jest liczbą!");
                }
            }
            Console.Write("Y: ");
            while (true)
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Podana wartość nie jest liczbą!");
                }
            }
            _centerPoint = new Point(x, y);
            AddPoint();
        }
        public override string Display()
        {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)_colour;
            double r = Math.Sqrt(Math.Pow(_centerPoint._X + _points[0]._X, 2) + Math.Pow(_centerPoint._Y + _points[0]._Y, 2));
            for (int i = 0; i < (2*r); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < (2*r); j++)
                {
                    double dx = j - r-1;
                    double dy = i - r-1;
                    double d = Math.Sqrt(dx * dx + dy * dy);
                    if (d < r&&d>r-2)
                        Console.Write("█");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return $"Obwód wynosi {2 * (int)r}PI";
        }
    }
}
