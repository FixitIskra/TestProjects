using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatConsole
{
    class TextFormatConsole
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Formatowanie waluty z C: {0:C}", 777.7777);
            System.Console.WriteLine("Formatowanie dziesiętne z D2: {0:D2}", 777);
            System.Console.WriteLine("Formatowanie dziesiętne z D9: {0:D9}", 777);
            System.Console.WriteLine("Formatowanie wykładnicze z E: {0:E}", 777.7777);
            System.Console.WriteLine("Formatowanie przecinkowe z F2: {0:F2}", 777.7777);
            System.Console.WriteLine("Formatowanie przecinkowe z F9: {0:F9}", 777.7777);
            System.Console.WriteLine("Formatowanie ogólne z G: {0:G}", 777.7777);
            System.Console.WriteLine("Formatowanie podstawowy format liczbowy z N: {0:N}", 777.7777);
            System.Console.WriteLine("Formatowanie heksadecymalne z X: {0:X}", 7779);
            System.Console.ReadLine();
            System.Console.WriteLine("\aDzownek z \\a \a\a\a\a\a", 7779);
            System.Console.WriteLine("\bBackspace z \\b");
            System.Console.WriteLine("\tTabulacja w poziomie z \\t");
            System.Console.WriteLine("\vTabulacja w pionie z \\v \v\v");
            System.Console.WriteLine(" Cudzysłów \' i Backslash \\");
            System.Console.ReadLine();

        }
    }
}
