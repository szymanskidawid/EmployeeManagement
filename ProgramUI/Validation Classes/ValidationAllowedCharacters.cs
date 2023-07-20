using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    // Class containing functions that allow certain combination of characters in each field.
    internal class ValidationAllowedCharacters
    {
        // Only allow letters in a field.
        internal static bool AllowLetter(string value)
        {
            return value.All(c => Char.IsLetter(c));
        }

        // Only allow letters and digits in a field.
        internal static bool AllowLetterDigit(string value)
        {
            return value.All(c => Char.IsLetterOrDigit(c));
        }

        // Only allow letters, digits and spaces in a field.
        internal static bool AllowLetterDigitSpace(string value)
        {
            return value.All(c => Char.IsLetterOrDigit(c) || c == ' ');
        }

        // Only allow letters, digits, spaces and dashes in a field.
        internal static bool AllowLetterDigitSpaceDash(string value)
        {
            return value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-');
        }

        // Only allow letters, digits, spaces, dashes, dots and "@" symbol in a field (for email address).
        internal static bool AllowLetterDigitSpaceDashDotAt(string value)
        {
            return value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == '.' || c == '@');
        }

        // Only allow letters, spaces and dashes in a field.
        internal static bool AllowLetterSpaceDash(string value)
        {
            return value.All(c => Char.IsLetter(c) || c == ' ' || c == '-');
        }

        // Only allow letters and dashes in a field.
        internal static bool AllowLetterDash(string value)
        {
            return value.All(c => Char.IsLetter(c) || c == '-');
        }

        // Only allow digits in a field.
        internal static bool AllowDigit(string value)
        {
            return value.All(c => Char.IsDigit(c));
        }
        
        // Only allow digits and spaces in a field.
        internal static bool AllowDigitSpace(string value)
        {
            return value.All(c => Char.IsDigit(c) || c == ' ');
        }

        // Only allow digits and pluses in a field.
        internal static bool AllowDigitPlus(string value)
        {
            return value.All(c => Char.IsDigit(c) || c == '+');
        }

        // Function allowing to choose a specific Allow function inside other functions.
        internal static bool SetAllowFunction(string allow, string textboxValue)
        {
            switch(allow)
            {
                case "Letter":
                    return AllowLetter(textboxValue);

                case "LetterDigit":
                    return AllowLetterDigit(textboxValue);

                case "LetterDigitSpace":
                    return AllowLetterDigitSpace(textboxValue);

                case "LetterDigitSpaceDash":
                    return AllowLetterDigitSpaceDash(textboxValue);

                case "LetterDigitSpaceDashDotAt":
                    return AllowLetterDigitSpaceDashDotAt(textboxValue);

                case "LetterSpaceDash":
                    return AllowLetterSpaceDash(textboxValue);

                case "LetterDash":
                    return AllowLetterDash(textboxValue);

                case "Digit":
                    return AllowDigit(textboxValue);

                case "DigitSpace":
                    return AllowDigitSpace(textboxValue);

                case "DigitPlus":
                    return AllowDigitPlus(textboxValue);

                default:
                    throw new Exception("Incorrect value provided for SetAllowFunction");
            }
        }
    }
}
