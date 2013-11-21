using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.ClientApp.BLL
{
    internal class TableFormat
    {
        internal static string FormatDouble(object value, string format = null)
        {
            if (value == null || value == DBNull.Value)
            {
                return "0";
            }
            double d = 0;
            double.TryParse(value.ToString(), out d);
            return (format == null ? d.ToString() : d.ToString(format));
        }


        internal static string FormatDoubleN2(object value)
        {
            return FormatDouble(value, "N2");
        }

        internal static int ConvertToInt(object value, int defValue = 0)
        {
            return (int)Math.Round(ConvertToDouble(value, defValue));
        }

        internal static double ConvertToDouble(object value, double defValue = 0)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDouble(value);
        }
    }
}
