using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var facade = new Facade();

            facade.Operation1();
            Console.WriteLine();
            facade.Operation2();

            Console.ReadKey();
        }
    }
}
