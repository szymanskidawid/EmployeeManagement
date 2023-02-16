using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public double Salary { get; set; }
    }
}
