using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(ColourType colour)
        {
            _colour = colour;
            while (true)
            {
                bool isSquareX = false;
                bool isSquareY = false;
                for (int i = 0; i < 4; i++)
                    AddPoint();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (_points[i]._X == _points[j]._X && _points[i]._Y == _points[j]._Y)
                            continue;
                        if (_points[i]._X == _points[j]._X)
                            isSquareX = true;
                        if (_points[i]._Y == _points[j]._Y)
                            isSquareY = true;
                    }
                }
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
                if (isSquareX && isSquareY && lengthA==lengthB)
                    break;
                Console.WriteLine("Podana figura nie jest kwadratem!\nSpróbuj jeszcze raz");
                for (int i = 0; i < 4; i++)
                    _points[i] = null;
            }
        }
        public new double CalculateArea()
        {
            double length = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (_points[i]._X == _points[j]._X)
                        length = Math.Sqrt(Math.Pow(_points[i]._X + _points[j]._X, 2) + Math.Pow(_points[i]._Y + _points[j]._Y, 2));

                }
                if (length > 0)
                    break;
            }
            double res = length * length;
            return res;
        }
    }
}
