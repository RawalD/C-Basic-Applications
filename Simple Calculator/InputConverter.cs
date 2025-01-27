﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Calculator
{
    public class InputConverter
    {
        public double convertToNumeric(string argTextInput)
        {
            double convertedNumber;

            if(!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("expected Numeric Value");
            }

            return convertedNumber;
        }
    }
}
