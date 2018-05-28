using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddConsole
{
    class Adding
    {
        static int AddMe(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter X: number");
            string x_string = Console.ReadLine();
            Console.WriteLine("Enter Y: number");
            string y_string = Console.ReadLine();

            try
            {
                int result = AddMe(int.Parse(x_string) , int.Parse(y_string));
                Console.WriteLine("\r\nAdding result: " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("\r\nPress any key to finish");
                Console.ReadKey();
            }

        }
    }
}
