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
        private static void SetTextboxState(TextBox value, Label info, bool isValid)
        {
            if (isValid)
            {
                value.BackColor = Color.Green;
                info.ForeColor = Color.Green;           
            }

            else
            {
                value.BackColor = Color.Red;
                info.ForeColor = Color.Red;
            }
        }

        //Boolean used to set Validation State.
        private static bool isValid = true;

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
        internal static async void UserInputValidation(TextBox text, int minCharacters, int maxCharacters, 
            Label infoLabel, string textboxToString, string allow, string require)
        {
            if (text.Text.Length < minCharacters || text.Text.Length > maxCharacters || 
                !ValidationAllowedCharacters.SetAllowFunction(allow, textboxToString) ||
                !ValidationRequiredCharacters.SetRequireFunction(require, textboxToString))
            {    
                SetIsValid(false);
                SetTextboxState(text, infoLabel, false);
            }

            else
            {
                SetTextboxState(text, infoLabel, true);
            }
        }
    }
}
