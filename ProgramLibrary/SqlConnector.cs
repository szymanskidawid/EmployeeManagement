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

        private const string db = "EmployeeManagement";

        /// <summary>
        /// Create a new employee and save it to the database.
        /// </summary>
        /// 
        public void CreateEmployee(string firstName, string lastName, string DOB,
            string gender, string email, string telephone, string address1,
            string address2, string postcode, string town, string country,
            string jobTitle, string contractStart, string contractEnd, string salary)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                EmployeeModel model = new EmployeeModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = DOB,
                    Gender = gender,
                    EmailAddress = email,
                    TelephoneNumber = telephone,
                    Address1 = address1,
                    Address2 = address2,
                    Postcode = postcode,
                    Town = town,
                    Country = country,
                    JobTitles = jobTitle,
                    ContractStart = contractStart,
                    ContractEnd = contractEnd,
                    Salary = salary
                };

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
            using (IDbConnection connection = new SqlConnection(db))
            {
                var p = new DynamicParameters();
                p.Add("@DepartmentName", model.DepartmentName);
                p.Add("@DepartmentEmployees", model.DepartmentEmployees);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDepartment_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        /// <summary>
        /// Create a new job title and save it to the database.
        /// </summary>
        public void CreateJobTitle(JobTitleModel model)
        {
            
        }

        
    }
}
