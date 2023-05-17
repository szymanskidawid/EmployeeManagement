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
        // Login system that accepts user input and returns whether it matches available logins in SQL table.
        public static bool LoginSystem(string login, string password)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                string query = "SELECT COUNT(*) FROM dbo.LoginTable WHERE username = @username AND password = @password";

                var p = new DynamicParameters();
                p.Add("@username", login);
                p.Add("@password", password);

                //count value increases to 1 if passed variables match with any dbo.LoginTable entry
                int count = (int)connection.ExecuteScalar(query, p); 

                bool isValid = (count > 0);

                return isValid;
            }
        }

        // Create a new employee and save it to the database.
        public static void CreateEmployee(string firstName, string lastName, string DOB,
            string gender, string email, string telephone, string address1,
            string postcode, string town, string country,string jobTitle, 
            string contractStart, string contractEnd, string salary, string currency)
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
                    Postcode = postcode,
                    Town = town,
                    Country = country,
                    JobTitle = jobTitle,
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
                p.Add("@Postcode", model.Postcode);
                p.Add("@Town", model.Town);
                p.Add("@Country", model.Country);
                p.Add("@JobTitle", model.JobTitle);
                p.Add("@ContractStart", model.ContractStart);
                p.Add("@ContractEnd", model.ContractEnd);
                p.Add("@Salary", model.Salary);
                p.Add("@Currency", model.Currency);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployees_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        // Edit an existing employee and save it to the database.
        public static void EditEmployee(int id, string firstName, string lastName, string DOB,
            string gender, string email, string telephone, string address1,
            string postcode, string town, string country, string jobTitle,
            string contractStart, string contractEnd, string salary, string currency)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                EmployeeModel model = new()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = DOB,
                    Gender = gender,
                    EmailAddress = email,
                    TelephoneNumber = telephone,
                    Address1 = address1,
                    Postcode = postcode,
                    Town = town,
                    Country = country,
                    JobTitle = jobTitle,
                    ContractStart = contractStart,
                    ContractEnd = contractEnd,
                    Salary = salary,
                    Currency = currency
                };

                //Save data from C# variables into SQL variables
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@DateOfBirth", model.DateOfBirth);
                p.Add("@Gender", model.Gender);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@TelephoneNumber", model.TelephoneNumber);
                p.Add("@Address1", model.Address1);
                p.Add("@Postcode", model.Postcode);
                p.Add("@Town", model.Town);
                p.Add("@Country", model.Country);
                p.Add("@JobTitle", model.JobTitle);
                p.Add("@ContractStart", model.ContractStart);
                p.Add("@ContractEnd", model.ContractEnd);
                p.Add("@Salary", model.Salary);
                p.Add("@Currency", model.Currency);

                connection.Execute("dbo.spEmployees_Update", p, commandType: CommandType.StoredProcedure);
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

        // Edit an existing department and save it to the database.
        public static void EditDepartment(int id, string departmentName, string departmentLocation)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                DepartmentModel model = new()
                {
                    Id = id,
                    DepartmentName = departmentName,
                    DepartmentLocation = departmentLocation
                };

                //Edit data from C# variables into SQL variables
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@DepartmentName", model.DepartmentName);
                p.Add("@DepartmentLocation", model.DepartmentLocation);

                connection.Execute("dbo.spDepartments_Update", p, commandType: CommandType.StoredProcedure);
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

        // Edit an existing job title and save it to the database.
        public static void EditJobTitle(int id, string jobTitleName, string jobTitleDepartment, string isSupervisor)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnString("EmployeeManagement")))
            {
                JobTitleModel model = new JobTitleModel
                {
                    Id = id,
                    JobTitleName = jobTitleName,
                    JobTitleDepartment = jobTitleDepartment,
                    IsSupervisor = isSupervisor
                };

                //Edit data from C# variables into SQL variables
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                p.Add("@JobTitleName", model.JobTitleName);
                p.Add("@JobTitleDepartment", model.JobTitleDepartment);
                p.Add("@IsSupervisor", model.IsSupervisor);

                connection.Execute("dbo.spJobTitles_Update", p, commandType: CommandType.StoredProcedure);
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
