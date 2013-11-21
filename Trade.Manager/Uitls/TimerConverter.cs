using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Manager.Uitls
{
    public class TimerConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(string val)
        {
            int index = val.IndexOf('/');
            char split = '/';
            if (index <= 0)
            {
                index = val.IndexOf('-');
                split = '-';
            }
            var arrs = val.Split(split);
            string format = "";
            foreach (var arr in arrs)
            {
                if (arr.Length == 1)
                {
                    format += string.Format("0{0}", arr) + split;
                }
                else
                {
                    format += arr + split;
                }
            }
            if (format[format.Length - 1] == split)
            {
                format = format.Remove(format.Length - 1, 1);
            }
            return DateTime.Parse(format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string FormatTime(string val)
        {
            return val.Replace("\t", "");
        }
    }
}
