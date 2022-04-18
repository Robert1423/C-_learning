using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape, IFigure
    {
        private double[] _Angles = new double[3];
        public Triangle(ColourType colour) : base(colour)
        {
            Console.WriteLine("Podaj współrzędne podstawy:");
            for (int i = 0; i < 2; i++)
                AddPoint();
            Console.WriteLine("Podaj wartości kątów przy podstawie: ");
            int count = 0;
            while (true)
            {
                if (count == 2)
                {
                    _Angles[2] = 180 - (_Angles[0] + _Angles[1]);
                    break;
                }
                Console.Write($"Kąt {count + 1}: ");
                double x;
                try
                {
                    x = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Błąd!\nWprowadzono niepoprawne wartości");
                    continue;
                }
                _Angles[count] = x;
                count++;
            }
        }
        public double CalculateHeight()
        {
            double lengthA = Math.Sqrt(Math.Pow(_points[0]._X + _points[1]._X, 2) + Math.Pow(_points[0]._Y + _points[1]._Y, 2));
            double heightB = Math.Sin((3.141592654 / 180) * _Angles[1]) * lengthA;
            double lengthC = heightB / Math.Sin((3.141592654 / 180) * _Angles[2]);
            return Math.Sin((3.141592654 / 180) * _Angles[0]) * lengthC; //wysokość na wprowadzoną podstawę
        }
        public double CalculateArea()
        {
            double lengthA = Math.Sqrt(Math.Pow(_points[0]._X + _points[1]._X, 2) + Math.Pow(_points[0]._Y + _points[1]._Y, 2));
            double height = CalculateHeight();
            return ((double)lengthA * (double)height) *0.5;
        }
        public override string Display()
        {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)_colour;
            //Obliczenia boków i wysokości wykonane w ten sam sposób w Excelu dają inne wyniki, np. przy równobocznym w Excelu wszystko wychodzi tak jak powinno tutaj nie, nie wiem dlaczego
            double lengthA = Math.Sqrt(Math.Pow(_points[0]._X + _points[1]._X, 2) + Math.Pow(_points[0]._Y + _points[1]._Y, 2));
            double heightB = Math.Sin((3.141592654 / 180.0) * _Angles[1]) * lengthA;
            double lengthC = heightB / Math.Sin((3.141592654 - 180) * _Angles[2]);
            double heightA = Math.Sin((3.141592654 / 180.0) * _Angles[0]) * lengthC;
            double lengthB = heightA / Math.Sin((3.141592654 / 180) * _Angles[1]);
            double heightC = Math.Sin((3.141592654 / 180.0) * _Angles[2]) * lengthB;
            double width, height, widthA, widthB; //Do wyrysowanie trojkata najdłuższa podstawa, wysokość i przeciecie wysokości z podstawą
            //Jeżeli dlugości mniejsze niż zero, zamiana na dodatnie
            if (lengthA < 0)
                lengthA *= -1;
            if (lengthB < 0)
                lengthB *= -1;
            if (lengthC < 0)
                lengthC *= -1;
            if (heightA < 0)
                heightA *= -1;
            if (heightB < 0)
                heightB *= -1;
            if (heightC < 0)
                heightC *= -1;
            if (lengthA > lengthB)
            {
                if (lengthA > lengthC)
                {
                    width = lengthA;
                    height = heightA;
                    widthA = Math.Sqrt(Math.Pow(lengthC, 2) - Math.Pow(height, 2));
                    widthB = Math.Sqrt(Math.Pow(lengthB, 2) - Math.Pow(height, 2));
                }
                else
                {
                    width = lengthC;
                    height = heightC;
                    widthA = Math.Sqrt(Math.Pow(lengthB, 2) - Math.Pow(height, 2));
                    widthB = Math.Sqrt(Math.Pow(lengthA, 2) - Math.Pow(height, 2));
                }
            }
            else
            {
                if (lengthB > lengthC)
                {
                    width = lengthB;
                    height = heightB;
                    widthA = Math.Sqrt(Math.Pow(lengthA, 2) - Math.Pow(height, 2));
                    widthB = Math.Sqrt(Math.Pow(lengthC, 2) - Math.Pow(height, 2));
                }
                else
                {
                    width = lengthC;
                    height = heightB;
                    widthA = Math.Sqrt(Math.Pow(lengthB, 2) - Math.Pow(height, 2));
                    widthB = Math.Sqrt(Math.Pow(lengthA, 2) - Math.Pow(height, 2));
                }
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < height-1; i++)
            {
                Console.Write('\t');
                for (int j = 0; j < width*2; j++)//piksele w konsoli są wyższe niż szersze, więc żeby to jakoś wyglądało wydłużam szerokość do rysowania
                {
                    if (j >= widthA - i / (height/widthA)&& j <= widthA + i * (widthB / height))
                        Console.Write("█");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            return $"\nPole: {CalculateArea()}, Wysokość: {height}";
        }

    }
}
