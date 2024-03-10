using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Client
{
    public static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.CursorVisible = false;
        Facade facade = new Facade();

        facade.Operation1();
        facade.Operation2();

        Console.ReadKey();
    }
}
