using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    // Class containing functions that require certain combination of characters in each field.
    internal static class ValidationRequiredCharacters
    {
        // Require at least one letter in a field.
        internal static bool RequireLetter(string value)
        {
            return value.Any(c => Char.IsLetter(c));
        }

        // Require at least one letter, @ symbol and a dot in a field.
        internal static bool RequireLetterAtDot(string value)
        {
            return value.Any(c => Char.IsLetter(c) || c == '@' || c == '.');
        }

        // Require at least one digit in a field.
        internal static bool RequireDigit(string value)
        {
            return value.Any(c => Char.IsDigit(c));
        }

        // Function allowing to choose a specific Require function inside other functions.
        internal static bool SetRequireFunction(string require, string textboxValue)
        {
            switch (require)
            {
                case "Letter":
                    return RequireLetter(textboxValue);

                case "LetterAtDot":
                    return RequireLetterAtDot(textboxValue);

                case "Digit":
                    return RequireDigit(textboxValue);

                default:
                    throw new Exception("Incorrect value provided for SetRequireFunction");
            }
        }
    }
}
