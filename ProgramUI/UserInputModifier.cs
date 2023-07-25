using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    internal static class UserInputModifier
    {
        // Function that capitalizes first letter of user input.
        internal static void CapitalizeFirstLetter(TextBox textBox)
        {
            string input = textBox.Text;
            if (!string.IsNullOrEmpty(input))
            {
                textBox.Text = char.ToUpper(input[0]) + input.Substring(1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
