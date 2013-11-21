using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading;
using System.Drawing;


namespace Trade.Collector
{
    internal class PriceCompare
    {
        internal string GetRowName(DataRow row)
        {
            return row[1].ToString();
        }

        internal string[] RowToArray(DataRow row)
        {
            object[] array = row.ItemArray;
            string[] rowValues = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                object value = array[i];
                if (i == 0)
                {
                    Bitmap bmp = value as Bitmap;
                    if (bmp == null)
                    {
                        rowValues[i] = "A";
                        continue;
                    }
                    Color color = bmp.GetPixel(7, 8);

                    if (color.R - color.G > 90 && color.R - color.B > 90)
                    {
                        rowValues[i] = "R";
                    }
                    else if (color.G - color.R > 90 && color.G - color.B > 90)
                    {
                        rowValues[i] = "G";
                    }
                    else
                    {
                        rowValues[i] = "A";
                    }
                }
                else
                {
                    rowValues[i] = (array[i] ?? string.Empty).ToString().Trim();
                }
            }
            return rowValues;
        }

        internal string RowToString(DataRow row)
        {
            return string.Join("@", this.RowToArray(row));
        }

        internal bool IsChanged(string[] oldValue, string[] newValue)
        {
            return this.IsChanged(
                string.Join("@", oldValue),
                string.Join("@", newValue));
        }

        internal bool IsChanged(string oldValue, string newValue)
        {
            return !(oldValue ?? string.Empty).Equals(newValue);
        }
    }
}
