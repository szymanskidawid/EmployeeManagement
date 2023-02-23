using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProgramLibrary.Models;

namespace ProgramLibrary
{
    internal class SqlConnector
    {
        // Initialize connection to the database.
        SqlConnection connection = new();

        private const string db = "EmployeeManagement";     

        /// <summary>
        /// Create a new employee and save it to the database.
        /// </summary>
        public static void CreateEmployee(EmployeeModel model)
        {
            //EmployeeModel em = new();
        }

        /// <summary>
        /// Create a new department and save it to the database.
        /// </summary>
        public static void CreateDepartment(DepartmentModel model)
        {
            //DepartmentModel dm = new();
        }

        /// <summary>
        /// Create a new job title and save it to the database.
        /// </summary>
        public static void CreateJobTitle(JobTitleModel model)
        {
            //JobTitleModel jm = new();
        }
    }
}
