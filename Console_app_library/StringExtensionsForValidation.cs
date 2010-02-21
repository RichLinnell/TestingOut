using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Console_app_library
{
    public static class StringExtensionsForValidation
    {
        public static bool Validate(this string nameToValidate)
        {
            return Regex.IsMatch(nameToValidate, @"^\D+$");
        }
    }
}
