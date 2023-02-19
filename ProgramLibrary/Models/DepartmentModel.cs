using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class DepartmentModel
    {
        // Stores the id of the department.
        public int Id { get; set; }

        // Stores the name of the department.
        public string DepartmentName { get; set; }

        // Stors the list of all employees working in this department.
        public List<EmployeeModel> DepartmentEmployees { get; set; } = new List<EmployeeModel>();
    }
}
