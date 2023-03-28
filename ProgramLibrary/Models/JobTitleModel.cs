using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary.Models
{
    public class JobTitleModel
    {
        // Stores the id, name and a department for the Job Title.
        public int Id { get; set; }
        public string JobTitleName { get; set; }
        public string JobTitleDepartment { get; set; }
        public string IsSupervisor;
    }
}
