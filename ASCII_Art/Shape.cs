using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        protected Point[] _points = new Point[4];
        protected ColourType _colour;

        public Shape(ColourType colour=ColourType.White)
        {
            _colour = colour;
        }
        public virtual string Display()
        {
            return "Shape";
        }
        public void AddPoint()
        {
            Console.Write("Podaj współrzędne punktu:\nX: ");
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
            Point point = new Point(x, y);
            for (int i =0; i < _points.Length; i++)
            {
                if (_points[i]==null)
                {
                    _points[i] = point;
                    break;
                }
            }
        }
    }
}
