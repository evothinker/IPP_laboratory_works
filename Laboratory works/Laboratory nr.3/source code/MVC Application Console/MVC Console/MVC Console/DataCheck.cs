using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Console
{
    class DataCheck
    {
        //checks the input data to be a valid secured range double
        public bool CheckData(string input)
        {
            if (CheckStringAsDouble(input))
                if (CheckInputRange(input))
                {
                    return true;
                }
            return false;
        }

        //checks if the string can be converted to double
        private bool CheckStringAsDouble(string input)
        {
            try
            {
                Convert.ToDouble(input);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        //check it the input is in secure ranges
        private Boolean CheckInputRange(string input)
        {
            if (input.Length < 10)
                return true;

            return false;
        }
    }
}
