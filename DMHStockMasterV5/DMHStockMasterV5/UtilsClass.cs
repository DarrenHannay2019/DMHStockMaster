using System;

namespace DMHStockMasterV5
{
    class UtilsClass
    {
        public string GetConnString()
        {
           return @"Initial Catalog=DMHStockv4;Data Source=.\\SQLEXPRESS;Persist Security Info=false;Integrated Security=true;";
        }
        public System.DateTime GetSundaysDate(DateTime dteDate)
        {
            return dteDate.AddDays(0 - dteDate.DayOfWeek);
        }
        public string GetBkConnString()
        {
            return @"Initial Catalog=master;Data Source=.\\SQLEXPRESS;Persist Security Info=false;Integrated Security=true;";
        }
        public System.DateTime GetNextSundaysDate(DateTime dteDate)
        {
            return dteDate.AddDays(0 - dteDate.DayOfWeek + 7);
        }
        public string Username()
        {
            return "Admin";
        }
    }
}
