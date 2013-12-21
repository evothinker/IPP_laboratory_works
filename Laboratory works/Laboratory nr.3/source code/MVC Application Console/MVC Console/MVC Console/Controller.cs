using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Console
{
    class Controller
    {
        //converts the temperature
        TemperatureConverter TempConv;
        
        //checks the input data
        DataCheck DatCh;

        //data model
        Model model;

        public Controller()
        {
            TempConv = new TemperatureConverter();
            DatCh = new DataCheck();
            model = new Model();
        }

        public string ConvertTemperature(string type, string input)
        {
            //returned value
            string retVal = null;

            //temporary temperature
            double temperature = 0;

            //if the input temperature is not valid
            if (!DatCh.CheckData(input))
            {
               return "Error";
            }

            //if input temperature is in Celsius
            if (type.Equals("Celsius"))
            {
                double convertedTemperature = 0;

                temperature = Convert.ToDouble(input);
                
                convertedTemperature = TempConv.ConvertCelsiusToFahrenheit(temperature);
                
                model.setCelsius(temperature);
                model.setFahrenheit(convertedTemperature);
                
                retVal = Convert.ToString(convertedTemperature);
            }

            //if input temperature is in Fahrenheit
            else if (type.Equals("Fahrenheit"))
            {
                double convertedTemperature = 0;

                temperature = Convert.ToDouble(input);
                
                convertedTemperature = TempConv.ConvertFahrenheitToCelsius(temperature);
                
                model.setFahrenheit(temperature);
                model.setCelsius(convertedTemperature);
                
                retVal = Convert.ToString(convertedTemperature);
            }

            return retVal;
        }
    }
}
