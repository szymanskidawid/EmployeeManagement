using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class DepartmentModel
    {
        // Stores the id and other information of the department.
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentLocation { get; set; }
    }
}
