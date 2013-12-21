using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Console
{
    class Model
    {
        //Temperature in Celsius
        private double Celsius;

        //Temperature in Fahrenheit
        private double Fahrenheit;

        public Model()
        {
            Celsius = 0;
            Fahrenheit = 0;
        }

        public void setCelsius(double C)
        {
            Celsius = C;
        }

        public void setFahrenheit(double F)
        {
            Fahrenheit = F;
        }

        public double getCelsius()
        {
            return Celsius;
        }

        public double getFahrenheit()
        {
            return Fahrenheit;
        }
    }
}
