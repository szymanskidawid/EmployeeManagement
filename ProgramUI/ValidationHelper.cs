using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    //Contains different possibilities of validation for form fields.
    internal class ValidationHelper
    {
        /// <summary>
        /// FOR FUTURE TESTING
        /// </summary>
        private const string Requirement = "";

        //Only allow letters in a field.
        private static bool AllowLetter (string value)
        {
            bool let = value.All(c => Char.IsLetter(c));

            return let;
        }

        //Only allow letters, spaces and dashes in a field.
        private static bool AllowLetterSpaceDash(string value)
        {
            bool letSpaceDash = value.All(c => Char.IsLetter(c) || c == ' ' || c == '-');

            return letSpaceDash;
        }

        //Only allow letters, digits, spaces and dashes in a field.
        private static bool AllowLetterDigitSpaceDash(string value)
        {
            bool letDigSpaceDash = value.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '-');

            return letDigSpaceDash;
        }

        //Sets a state of a textbox depeding if the field was valid or not.
        private static void SetTextboxState(TextBox value, Label error, bool state)
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

        //Boolean used to set Validation State.
        private static bool setState = new();

        //Sets a state of a Validation State boolean.
        internal static void SetValidationState(bool state)
        {
            setState = state;
        }

        //Returns a value of Validation State boolean.
        internal static bool GetValidationState()
        {
            return setState;
        }

        //Function validating user input for each TextBox.
        internal static void UserInputValidation(TextBox text, int minCharacters, int maxCharacters, Label errorLabel, string textboxToString)
        {
            if (text.Text.Length == minCharacters || text.Text.Length > maxCharacters || !ValidationHelper.AllowLetterDigitSpaceDash(textboxToString))
            {
                SetValidationState(false);
                SetTextboxState(text, errorLabel, true);               
            }

            else
            {
                SetTextboxState(text, errorLabel, false);
            }
        }
    }
}
