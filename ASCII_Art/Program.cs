using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            ColourType selectColor;
            while (true)
            {
                Console.WriteLine("Wybierz kształt:\n1 - Okrąg (Obwód koła\n2 - Koło\n3 - Prostokąt\n4 - Kwadrat\n5 - Trójkąt\n0 - koniec");
                x = GetNumber();
                switch (x)
                {
                    case 1: selectColor = GetColour();
                        Cirumference circfr = new Cirumference(selectColor);
                        Console.WriteLine(circfr.Display());
                        Console.ReadLine();
                        break;
                    case 2:
                        selectColor = GetColour();
                        Circle circ = new Circle(selectColor);
                        Console.WriteLine(circ.Display());
                        Console.ReadLine();
                        break;
                    case 3:
                        selectColor = GetColour();
                        Rectangle rec = new Rectangle(selectColor);
                        Console.WriteLine(rec.Display());
                        Console.ReadLine();
                        break;
                    case 4:
                        selectColor = GetColour();
                        Square sq = new Square(selectColor);
                        Console.WriteLine(sq.Display());
                        Console.ReadLine();
                        break;
                    case 5:
                        selectColor = GetColour();
                        Triangle tr = new Triangle(selectColor);
                        Console.WriteLine(tr.Display());
                        Console.ReadLine();
                        break;
                    default:
                        if (x != 0)
                            Console.WriteLine("Błędny wybór");
                        break;
                }
                if (x == 0)
                    break;
                Console.Clear();
            }
        }
        public static int GetNumber()
        {
            while (true)
            {
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    return x;
                }
                catch
                {
                    Console.WriteLine("Podana wartosc nie jest liczba!");
                }
            }
        }
        public static ColourType GetColour()
        {
            Console.WriteLine("Wybierz kolor:\n1- Biały\n2 - Magenta\n3 - Niebieski\n4 - Czerwony");
            Console.WriteLine("5 - Zielony\n6 - Żółty\n7 - Szary\n8 - Cyjan");
            int x = 0;
            while (x < 1 || x > 8)
            {
                x = GetNumber();
                if (x < 1 || x > 8)
                    Console.WriteLine("Błędny wybór!");
            }
            if (x == 1)
            {
                return ColourType.White;
            }
            else if (x == 2)
            {
                return ColourType.Magenta;
            }
            else if (x == 3)
            {
                return ColourType.Blue;
            }
            else if (x == 4)
            {
                return ColourType.Red;
            }
            else if (x == 5)
            {
                return ColourType.Green;
            }
            else if (x == 6)
            {
                return ColourType.Yellow;
            }
            else if (x == 7)
            {
                return ColourType.Gray;
            }
            else
            {
                return ColourType.Cyan;
            }
        }
    }
}
