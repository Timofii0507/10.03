using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var car = new Car();

            Console.WriteLine("Опис: {0}", car.GetDescription());
            Console.WriteLine("Ціна: {0}", car.GetPrice());

            var carWithAirConditioning = new AirConditioningDecorator(car);

            Console.WriteLine("\nОпис: {0}", carWithAirConditioning.GetDescription());
            Console.WriteLine("Ціна: {0}", carWithAirConditioning.GetPrice());

            var carWithGPS = new GPSDecorator(carWithAirConditioning);

            Console.WriteLine("\nОпис: {0}", carWithGPS.GetDescription());
            Console.WriteLine("Ціна: {0}", carWithGPS.GetPrice());
        }
    }
}
