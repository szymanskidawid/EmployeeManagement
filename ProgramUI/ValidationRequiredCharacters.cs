using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    // Class containing functions that require certain combination of characters in each field.
    internal class ValidationRequiredCharacters
    {
        // Require at least one letter in a field.
        internal static bool RequireLetter(string value)
        {
            bool let = value.Any(c => Char.IsLetter(c));

            return let;
        }

        // Require at least one letter, @ symbol and a dot in a field.
        internal static bool RequireLetterAtDot(string value)
        {
            bool letAtDot = value.Any(c => Char.IsLetter(c) || c == '@' || c == '.');

            return letAtDot;
        }

        // Require at least one digit in a field.
        internal static bool RequireDigit(string value)
        {
            bool dig = value.Any(c => Char.IsDigit(c));

            return dig;
        }

        // Function allowing to choose a specific Require function inside other functions.
        internal static bool SetRequireFunction(string require, string textboxValue)
        {
            if (require == "Letter")
            {
                return RequireLetter(textboxValue);
            }

            if (require == "LetterAtDot")
            {
                return RequireLetterAtDot(textboxValue);
            }

            if (require == "Digit")
            {
                return RequireDigit(textboxValue);
            }

            else
            {
                throw new Exception("Incorrect value provided for SetRequireFunction");
            }
        }
    }
}
