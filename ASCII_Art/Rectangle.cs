using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape, IFigure
    {
        public Rectangle(ColourType colour) : base(colour)
        {
            while (true)
            {
                bool isRactangleX = false;
                bool isRactangleY = false;
                for (int i = 0; i < 4; i++)
                    AddPoint();
                for (int i=0; i<4; i++)
                {
                    for (int j=0; j<4; j++)
                    {
                        if (_points[i]._X == _points[j]._X && _points[i]._Y == _points[j]._Y)
                            continue;
                        if (_points[i]._X == _points[j]._X)
                            isRactangleX = true;
                        if (_points[i]._Y == _points[j]._Y)
                            isRactangleY = true;
                    }
                }
                if (isRactangleX && isRactangleY)
                    break;
                Console.WriteLine("Podana figura nie jest prostokątem!\nSpróbuj jeszcze raz");
                for (int i = 0; i < 4; i++)
                    _points[i] = null;
            }
        }
        public Rectangle() { }
        public double CalculateArea()
        {
            double lengthA = 0;
            double lengthB = 0;
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    if (_points[i]._X==_points[j]._X)
                        lengthA = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                    if (_points[i]._Y==_points[j]._Y)
                        lengthB = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                }
                if (lengthA > 0 && lengthB > 0)
                    break;
            }
            double res = lengthA*lengthB;
            return res;
        }
        public double CalcLengthOfDiagonal()
        {
            double lengthA = 0;
            double lengthB = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_points[i]._X == _points[j]._X)
                        lengthA = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                    if (_points[i]._Y == _points[j]._Y)
                        lengthB = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                }
                if (lengthA > 0 && lengthB > 0)
                    break;
            }
            double res = Math.Sqrt(Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2));
            return res;
        }
        public override string Display()
        {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)_colour;
            Console.WriteLine("\n\n\n");
            double lengthA = 0;
            double lengthB = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_points[i]._X == _points[j]._X)
                        lengthA = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                    if (_points[i]._Y == _points[j]._Y)
                        lengthB = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));
                }
                if (lengthA > 0 && lengthB > 0)
                    break;
            }
            double height = 0;
            double width = 0;
            if (lengthA>=lengthB)
            {
                width = lengthA*2.0;
                height = lengthB;
            }
            else if (lengthB>lengthA)
            {
                width = lengthB*2.0;
                height = lengthA;
            }
            //else if (lengthA==lengthB) //jeżeli kwadrat to ze względu na szerokość znaków dałem pmnożenie przez 2 szerokości, tylko po to by wygładało jak kwadrat w konsoli
            //{
            //    width = lengthA * 2.0;
            //    height = lengthB;
            //}
            for (int i=0;i<height;i++)
            {
                Console.Write('\t');
                for (int j=0;j<width;j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return $"\nPole = {CalculateArea()}\nPrzękatna = {CalcLengthOfDiagonal()}";
        }
    }
}
