using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLibrary
{
    internal static class ConnectionHelper
    {
        //Contains code that runs a connection string from app.config and connecting the program to SQL database.
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
