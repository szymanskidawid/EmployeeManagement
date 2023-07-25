using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramLibrary
{
    public static class DropDownLists
    {
        // Get a list of Countries that can be added into a DropDown.
        public static List<string> CountryList()
        {
            List<string> CultureList = new List<string>();

            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);

                if (!CultureList.Contains(GetRegionInfo.EnglishName))
                {
                    CultureList.Add(GetRegionInfo.EnglishName);
                }
            }

            CultureList.Sort();

            return CultureList;
        }

        // String array of Genders that can be added into a DropDown.
        public static string[] GenderList = { "Male", "Female", "Other" };

        // String array of Currency symbols that can be added into a DropDown.
        public static string[] CurrencyList = { "zł", "$", "€", "£", "CHF", "kr", };

        // String array of Yes/No options for the Supervisor DropDown.
        public static string[] IsSupervisorList = { "Yes", "No" };

        // String array of Categories to edit that can be added into a DropDown.
        public static string[] EditCategoryList = { "Employee", "Department", "Job Title" };
    }
}


