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
        public enum Gender { Select, Female, Male }

        // Stores the email address of the employee.
        public string EmailAddress { get; set; }

        // Stores the phone number of the employee.
        public string PhoneNumber { get; set; }

        // Stores the list of job titles available for the employee.
        public List<JobTitleModel> JobTitles = new List<JobTitleModel>();

        // Stores the contract start date of the employee.
        public string ContractStartDate { get; set; }

        // Stores the contract end date of the employee.
        public string ContractEndDate { get; set; }

        // Stores the salary of the employee.
        public double Salary { get; set; }
    }
}
