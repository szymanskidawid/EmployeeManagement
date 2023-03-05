using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProgramLibrary
{
    public class DropDownLists
    {
        // Get a list of Countries that can be added into a DropDown
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

        // String array of Genders that can be added into a DropDown
        public static string[] GenderList = { "Male", "Female", "Other" };

        // Get a  string array of Currency symbols that can be added into a DropDown
        public static string[] CurrencyList = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(culture => culture.NumberFormat.CurrencySymbol).Distinct().ToArray(); // TODO - Learn more
    }
}


