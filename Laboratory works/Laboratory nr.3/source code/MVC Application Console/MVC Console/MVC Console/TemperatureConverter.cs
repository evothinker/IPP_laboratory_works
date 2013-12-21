using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Console
{
    public class TemperatureConverter
    {
        //converts Celsius to Fahrenheit
        public double ConvertCelsiusToFahrenheit(double C)
        {
            return (C * 1.8) + 32;
        }

        //converts Fahrenheit to Celsius
        public double ConvertFahrenheitToCelsius(double F)
        {
            return (F - 32) * 0.5;
        }

    }
}
