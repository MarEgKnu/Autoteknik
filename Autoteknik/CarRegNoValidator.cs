using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class CarRegNoValidator : IValidator
    {
        public bool Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return Regex.IsMatch(input, "^[A-Z]{2}\\d{3,5}$");
        }
        //public bool Validate(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return false;
        //    }
        //    else if (input.Length < 5 || 7 < input.Length) 
        //    {
        //        return false;
        //    }
        //    else if (!Char.IsLetter(input[0]) || Char.IsLower(input[0]) || !Char.IsLetter(input[1]) || Char.IsLower(input[1]))
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i < input.Length; i++)
        //    {
        //        if (!Char.IsNumber(input[i])) 
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
