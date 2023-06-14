using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class EmployeeModel
    {
        // Stores id and other information about the employee.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string JobTitle { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public string Salary { get; set; }
        public string Currency { get; set; }
    }
}
