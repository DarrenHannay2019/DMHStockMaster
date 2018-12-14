using System;

namespace DMHStockMasterV5
{
    public class UtilsClass
    {
        protected string text;
        protected string GetConnString(int ID)
        {
            if (ID == 0)
            {
                text = @"Initial Catalog=DMHStockv4;Data Source=.\\SQLEXPRESS;Persist Security Info=false;Integrated Security=true;";
            }
            else
            {
                text = @"Initial Catalog=master;Data Source=.\\SQLEXPRESS;Persist Security Info=false;Integrated Security=true;";
            }
            return text;
        }
        public System.DateTime GetSundaysDate(DateTime dteDate)
        {
            return dteDate.AddDays(0 - dteDate.DayOfWeek);
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
