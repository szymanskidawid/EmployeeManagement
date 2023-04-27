using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    //Class containing functions that allow certain combination of characters in each field.
    internal class ValidationAllowedCharacters
    {
        //Only allow letters in a field.
        internal static bool AllowLetter(string value)
        {
            bool let = value.All(c => Char.IsLetter(c));

            return let;
        }

        //Only allow letters and digits in a field.
        internal static bool AllowLetterDigit(string value)
        {
            bool letDig = value.All(c => Char.IsLetterOrDigit(c));

            return letDig;
        }

        //Only allow letters, spaces and dashes in a field.
        internal static bool AllowLetterDigitSpace(string value)
        {
            bool letDigSpace = value.All(c => Char.IsLetterOrDigit(c) || c == ' ');

            return letDigSpace;
        }

        //Only allow letters, digits, spaces and dashes in a field.
        internal static bool AllowLetterDigitSpaceDash(string value)
        {
            bool letDigSpaceDash = value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-');

            return letDigSpaceDash;
        }

        //Only allow letters, digits, spaces, dashes, dots and @ symbol in a field (for email address).
        internal static bool AllowLetterDigitSpaceDashDotAt(string value)
        {
            bool letDigSpaceDashDotAt = value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-' || c == '.' || c == '@');

            return letDigSpaceDashDotAt;
        }

        //Only allow letters, spaces and dashes in a field.
        internal static bool AllowLetterSpaceDash(string value)
        {
            bool letSpaceDash = value.All(c => Char.IsLetter(c) || c == ' ' || c == '-');

            return letSpaceDash;
        }

        //Only allow letters and dashes in a field.
        internal static bool AllowLetterDash(string value)
        {
            bool letDigSpaceDash = value.All(c => Char.IsLetter(c) || c == '-');

            return letDigSpaceDash;
        }

        //Only allow digits and spaces in a field.
        internal static bool AllowDigitSpace(string value)
        {
            bool digSpace = value.All(c => Char.IsDigit(c) || c == ' ');

            return digSpace;
        }

        //Only allow digits and pluses in a field.
        internal static bool AllowDigitPlus(string value)
        {
            bool digPlus = value.All(c => Char.IsDigit(c) || c == '+');

            return digPlus;
        }

        //Function allowing to choose a specific Allow function inside other functions.
        internal static bool SetAllowFunction(string allow, string textboxValue)
        {
            if (allow == "Letter")
            {
                return AllowLetter(textboxValue);
            }

            if (allow == "LetterDigit")
            {
                return AllowLetterDigit(textboxValue);
            }

            if (allow == "LetterDigitSpace")
            {
                return AllowLetterDigitSpace(textboxValue);
            }

            if (allow == "LetterDigitSpaceDash")
            {
                return AllowLetterDigitSpaceDash(textboxValue);
            }

            if (allow == "LetterDigitSpaceDashDotAt")
            {
                return AllowLetterDigitSpaceDashDotAt(textboxValue);
            }

            if (allow == "LetterSpaceDash")
            {
                return AllowLetterSpaceDash(textboxValue);
            }

            if (allow == "LetterDash")
            {
                return AllowLetterDash(textboxValue);
            }

            if (allow == "DigitSpace")
            {
                return AllowDigitSpace(textboxValue);
            }

            if (allow == "DigitPlus")
            {
                return AllowDigitPlus(textboxValue);
            }

            else
            {
                throw new Exception("Incorrect value provided for SetAllowFunction");
            }
        }
    }
}
