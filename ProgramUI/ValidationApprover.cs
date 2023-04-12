using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    //Contains different possibilities of validation for form fields.
    internal class ValidationApprover
    {
        //Sets a state of a textbox depeding if the field was valid or not.
        private static void SetTextboxState(TextBox value, Label error, bool isValid)
        {
            if (isValid)
            {
                value.BackColor = Color.White;
                error.Hide();            
            }

            else
            {
                value.BackColor = Color.Red;
                error.Show();
            }
        }

        //Boolean used to set Validation State.
        private static bool isValid = new();

        //Sets a state of a Validation State boolean.
        internal static void SetIsValid(bool state)
        {
            isValid = state;
        }

        //Returns a value of Validation State boolean.
        internal static bool GetIsValid()
        {
            return isValid;
        }

        //Function validating user input for each TextBox.
        internal static void UserInputValidation(TextBox text, int minCharacters, int maxCharacters, Label errorLabel, string textboxToString, string allow)
        {
            if (text.Text.Length == minCharacters || text.Text.Length > maxCharacters || !ValidationAllowedCharacters.SetAllowFunction(allow, textboxToString))
            {
                SetIsValid(false);
                SetTextboxState(text, errorLabel, false);               
            }

            else
            {
                SetTextboxState(text, errorLabel, true);
            }
        }
    }
}
