using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class JobTitleModel
    {
        // Stores the id of the job title.
        public int Id { get; set; }

        // Stores the name of the job title.
        public string Name { get; set; }

        // Stores the department applicable for this job title.
        public DepartmentModel JobTitleDepartment = new();
    }
}
