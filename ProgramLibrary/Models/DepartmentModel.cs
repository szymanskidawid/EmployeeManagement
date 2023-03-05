using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class DepartmentModel
    {
        // Stores the id, name and employees of the department.
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<EmployeeModel> DepartmentEmployees { get; set; } = new List<EmployeeModel>();
    }
}
