using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Console
{
    class View
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            //the menu item
            int menu = 0;

            while(true)
            {
                System.Console.WriteLine("\t\tTemperature Converter");
                System.Console.WriteLine("======================================================");
                System.Console.WriteLine("1. Celsius to Fahrenheit");
                System.Console.WriteLine("2. Fahrenheit to Celsius");
                System.Console.WriteLine("0. Exit");
                System.Console.WriteLine("------------------------------------------------------");
                System.Console.Write("Input = ");
                
                try
                {
                    menu = Convert.ToInt32(System.Console.ReadLine());
                }
                //in case input is not an Int
                catch (Exception ex)
                {
                    //simulates not a valid input
                    menu = 999;
                }

                System.Console.WriteLine();

                //converts Celsius to Fahrenheit
                if (menu == 1)
                {
                    string CelsiusTemperature = null;

                    System.Console.WriteLine("\t\tCelsius to Fahrenheit");
                    System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");

                    System.Console.Write("Celsius = ");
                    CelsiusTemperature = System.Console.ReadLine();

                    System.Console.WriteLine("Fahrenheit = {0}",controller.ConvertTemperature("Celsius",CelsiusTemperature));

                    System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                }

                //converts Fahrenheit to Celsius
                else if (menu == 2)
                {
                    string FahrenheitTemperature = null;

                    System.Console.WriteLine("\t\tFahrenheit to Celsius");
                    System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");

                    System.Console.Write("Fahrenheit = ");
                    FahrenheitTemperature = System.Console.ReadLine();

                    System.Console.WriteLine("Celsius = {0}",controller.ConvertTemperature("Fahrenheit",FahrenheitTemperature));

                    System.Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                }

                //exits the application
                else if (menu == 0)
                {
                    return;
                }

                //not a valid input
                else
                {
                    System.Console.WriteLine("Not a valid input!");
                }

                System.Console.WriteLine();
                System.Console.ReadKey();
            }
        }
    }
}
