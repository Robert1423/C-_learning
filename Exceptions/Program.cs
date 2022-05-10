using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "log.txt";
            using (FileStream fs = File.Open(filename, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    {
                        Console.WriteLine("Podaj liczbę: ");
                    }

                    int x;
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        int res = 10 / x;
                        throw new ApplicationException("ApplicationException Error");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        sw.WriteLine(exc.Message);
                    }
                    Random random = new Random();
                    x = random.Next();
                    OptionProcessor optionProcessor = new OptionProcessor();
                    Console.WriteLine("Przez catch do InvalidProcessingParameterException");
                    try
                    {
                        optionProcessor.Process(x);
                    }
                    catch (InvalidProcessingParameterException exc) when (x % 3 == 0)
                    {
                        Console.WriteLine("Błąd! Podzielne przez 3");
                        Console.WriteLine(exc.Message());
                        sw.WriteLine("Błąd! Podzielne przez 3\n" + exc.Message());
                    }
                    catch (InvalidProcessingParameterException exc)
                    {
                        Console.WriteLine(exc.Message());
                        sw.WriteLine(exc.Message());
                    }
                    finally
                    {
                        Console.WriteLine($"Pseudo-losowa wartość: {x}");
                        sw.WriteLine(x);
                    }
                    Console.WriteLine("Przez dziediczenie");
                    x = random.Next();
                    try
                    {
                        optionProcessor.Process(x);
                    }
                    catch (ApplicationException exc) when (x % 3 == 0)
                    {
                        Console.WriteLine("Błąd! Podzielne przez 3");
                        Console.WriteLine(exc.Message());
                        sw.WriteLine("Błąd! Podzielne przez 3\n" + exc.Message());
                    }
                    catch (ApplicationException exc)
                    {
                        Console.WriteLine(exc.Message());
                        sw.WriteLine(exc.Message());
                    }
                    finally
                    {
                        Console.WriteLine($"Pseudo-losowa wartość: {x}");
                        sw.WriteLine(x);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
