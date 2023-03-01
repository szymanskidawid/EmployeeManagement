using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class EmployeeModel
    {
        // Stores the id of the employee.
        public int Id { get; set; }

        // Stores the first name of the employee.
        public string FirstName { get; set; }

        // Stores the last name of the employee.
        public string LastName { get; set; }

        // Stores the date of birth of the employee.
        public string DateOfBirth { get; set; }

        // Stores the gender of the employee.
        public string Gender { get; set; }

        // Stores the email address of the employee.
        public string EmailAddress { get; set; }

        // Stores the phone number of the employee.
        public string TelephoneNumber { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Postcode { get; set; }

        public string Town { get; set; }

        public string Country { get; set; }

        // Stores the list of job titles available for the employee.
        public string JobTitles { get; set; }

    // Stores the contract start date of the employee.
    public string ContractStart { get; set; }

        // Stores the contract end date of the employee.
        public string ContractEnd { get; set; }

        // Stores the salary of the employee.
        public double Salary { get; set; }

        /*public EmployeeModel(string firstName, string lastName, string DOB, 
            string gender, string email, string telephone, string address1, 
            string address2, string postcode, string town, string country, 
            string jobTitle, string contractStart, string contractEnd, string salary)
        {
            string employeeFirstNameValue = "";
            FirstName = employeeFirstNameValue;
            string employeeLastNameValue = "";
            LastName = employeeLastNameValue;
            string employeeBirthValue = "";
            DateOfBirth = employeeBirthValue;
            string employeeGenderDropDown = "";
            Gender = employeeGenderDropDown;
            string employeeEmailValue = "";
            EmailAddress = employeeEmailValue;
            string employeeTelephoneValue = "";
            TelephoneNumber = employeeTelephoneValue;
            string employeeAddress1Value = "";
            Address1 = employeeAddress1Value;
            string employeeAddress2Value = "";
            Address2 = employeeAddress2Value;
            string employeePostcodeValue = "";
            Postcode = employeePostcodeValue;
            string employeeTownValue = "";
            Town = employeeTownValue;
            string employeeCountryDropDown = "";
            Country = employeeCountryDropDown;
            string employeeJobTitleDropDown = "";
            JobTitles = employeeJobTitleDropDown;
            string employeeContractStartValue = "";
            ContractStart = employeeContractStartValue;
            string employeeContractEndValue = "";
            ContractEnd = employeeContractEndValue;
            double employeeSalaryValue = 0;
            Salary = employeeSalaryValue;
        }*/
    }
}
