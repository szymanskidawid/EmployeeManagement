using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProgramLibrary.Models;
using System.Data;
using Dapper;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace ProgramLibrary
{
    public class SqlConnector
    {
        // Create a new employee and save it to the database.
        public static void CreateEmployee(string firstName, string lastName, string DOB,
            string gender, string email, string telephone, string address1,
            string address2, string postcode, string town, string country,
            string jobTitle, string contractStart, string contractEnd, string salary, string currency)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                EmployeeModel model = new()
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
                    Salary = salary,
                    Currency = currency
                };

                //Save data from C# variables into SQL variables
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
                p.Add("@Currency", model.Currency);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployees_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        // Create a new department and save it to the database.
        public static void CreateDepartment(string departmentName, string departmentLocation)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                DepartmentModel model = new()
                {
                    DepartmentName = departmentName,
                    DepartmentLocation = departmentLocation,
                };
                //Save data from C# variables into SQL variables
                var p = new DynamicParameters();
                p.Add("@DepartmentName", model.DepartmentName);
                p.Add("@DepartmentLocation", model.DepartmentLocation);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDepartments_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        // Create a new job title and save it to the database.
        public static void CreateJobTitle(string jobTitleName, string jobTitleDepartment, string isSupervisor)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                JobTitleModel model = new()
                {
                    JobTitleName = jobTitleName,
                    JobTitleDepartment = jobTitleDepartment,
                    IsSupervisor = isSupervisor
                };
                //Save data from C# variables into SQL variables
                var p = new DynamicParameters();
                p.Add("@JobTitleName", model.JobTitleName);
                p.Add("@JobTitleDepartment", model.JobTitleDepartment);
                p.Add("@IsSupervisor", model.IsSupervisor);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spJobTitles_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        // Get a list of all Employees from the database.
        public static List<EmployeeModel> GetEmployees_All()
        {
            List<EmployeeModel> list = new();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                list = connection.Query<EmployeeModel>("dbo.spEmployees_GetAll").ToList();
            }

            return list;
        }

        // Get a list of all Departments from the database.
        public static List<DepartmentModel> GetDepartments_All()
        {
            List<DepartmentModel> list = new();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                list = connection.Query<DepartmentModel>("dbo.spDepartments_GetAll").ToList();
            }

            return list;
        }

        // Get a list of all Job Titles from the database.
        public static List<JobTitleModel> GetJobTitles_All()
        {
            List<JobTitleModel> list = new();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                list = connection.Query<JobTitleModel>("dbo.spJobTitles_GetAll").ToList();
            }

            return list;
        }

        //Displays an Employees table from SQL into a DataGridView
        public static DataTable DisplayEmployees()
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                SqlDataAdapter adapter = new();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM dbo.Employees", connection);
                DataTable table = new();
                adapter.Fill(table);

                return table;
            }
        }

    }
}
