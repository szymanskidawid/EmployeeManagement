using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    //Contains different possibilities of validation for form fields.
    internal class ValidationHelper
    {
        //Only allow letters in a field.
        internal static bool AllowLetter (string value)
        {
            bool let = value.All(c => Char.IsLetter(c));

            return let;
        }

        //Only allow letters, spaces and dashes in a field.
        internal static bool AllowLetterSpaceDash(string value)
        {
            bool letSpaceDash = value.All(c => Char.IsLetter(c) || c == ' ' || c == '-');

            return letSpaceDash;
        }

        //Only allow letters, digits, spaces and dashes in a field.
        internal static bool AllowLetterDigitSpaceDash(string value)
        {
            bool letDigSpaceDash = value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-');

            return letDigSpaceDash;
        }

        //Sets a state of a textbox depeding if the field was valid or not.
        internal static void SetTextboxState(TextBox value, Label error, bool state)
        {
            if (state)
            {
                value.BackColor = Color.Red;
                error.Show();
            }

            else
            {
                value.BackColor = Color.White;
                error.Hide();
            }
        }
    }
}
