using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Global_Classes
{
    public class ClsFormat
    {

       public static string ShortDate(DateTime date)
       {
            return date.ToString("MM/dd/yyyy");
       }

        //public static string ShortDate()
        //{
        //    return ShortDate(DateTime.Now);
        //}

        //public static string ShortTime()
        //{
        //    StringBuilder s = new StringBuilder(DateTime.Now.ToString("t"));

        //    if(DateTime.Now.ToString("tt") == "AM")
        //    {
        //        s.Replace("AM", "مساءاً  ");
        //    }
        //    else
        //    {
        //        s.Replace("AM", "صباحاً  ");
        //    }

        //    return s.ToString();
        //}


    }
}
