using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProgramLibrary.Models;
using System.Data;
using Dapper;

namespace ProgramLibrary
{
    public class SqlConnector
    {
        // Initialize connection to the database.
        SqlConnection connection = new();

        private const string db = "EmployeeManagement";     

        /// <summary>
        /// Create a new employee and save it to the database.
        /// </summary>
        public void CreateEmployee(EmployeeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(db))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@DateOfBirth", model.DateOfBirth);
                p.Add("@Gender", model.Gender);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@TelephoneNumber", model.TelephoneNumber);
                p.Add("@Address1", model.Address1);
                p.Add("@Address2", model.Address2);
                p.Add("@Postcode", model.Postcode);
                p.Add("@Town", model.Town);
                p.Add("@Country", model.Country);
                p.Add("@JobTitle", model.JobTitles);
                p.Add("@ContractStart", model.ContractStart);
                p.Add("@ContractEnd", model.ContractEnd);
                p.Add("@Salary", model.Salary);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployees_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        /// <summary>
        /// Create a new department and save it to the database.
        /// </summary>
        public void CreateDepartment(DepartmentModel model)
        {
            
        }

        /// <summary>
        /// Create a new job title and save it to the database.
        /// </summary>
        public void CreateJobTitle(JobTitleModel model)
        {
            
        }
    }
}
