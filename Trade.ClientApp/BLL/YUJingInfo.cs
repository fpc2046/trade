using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Xml;

namespace Trade.ClientApp.BLL
{
    internal class YUJingInfo
    {
        public YUJingInfo()
        {
            this.Table = new Context.yjDataTable();
        }

        internal Context.yjDataTable Table;

        internal Context.yjDataTable GetFormatTable()
        {
            Context.yjDataTable yjTable = new Context.yjDataTable();
            foreach (DataRow row in Table.Rows)
            {
                Context.yjRow cRow = (Context.yjRow)row;
                Context.yjRow yjRow = yjTable.NewyjRow();
                yjRow.ID = cRow.ID;
                yjRow.YJLX = cRow.YJLX;
            }
            return yjTable;
        }

        private static string GetPath(Session session)
        {
            string dirName = string.Format("{0}\\UserFile\\{1}\\{2}\\",
                AppDomain.CurrentDomain.BaseDirectory,
                session.Environment,
                session.UserName);
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            return string.Format("{0}yj{1}.xml", dirName, session.UserName);
        }

        internal static YUJingInfo Read(Session session)
        {
            YUJingInfo info = new YUJingInfo();
            string path = GetPath(session);
            if (!File.Exists(path))
            {
                return info;
            }

            XmlDocument xml = new XmlDocument();

            try
            {
                xml.Load(path);
                foreach (XmlNode node1 in xml.ChildNodes)
                {
                    if (node1.NodeType != XmlNodeType.Element || node1.Name != "Context")
                    {
                        continue;
                    }
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        if (!node2.Name.Equals("yj", StringComparison.CurrentCultureIgnoreCase))
                        {
                            continue;
                        }
                        Context.yjRow row = (Context.yjRow)info.Table.NewyjRow();
                        #region
                        foreach (XmlNode node3 in node2.ChildNodes)
                        {
                            string value = node3.InnerText;
                            switch (node3.Name.ToUpper())
                            {
                                case "ID":
                                    short tempID = 0;
                                    if (short.TryParse(value, out tempID))
                                    {
                                        row.ID = tempID;
                                    }
                                    break;
                                case "YJLX":
                                    row.YJLX = value;
                                    break;
                                case "YJX":
                                    row.YJX = value;
                                    break;
                                case "YJTJ":
                                    row.YJTJ = value;
                                    break;
                                case "YJFZ":
                                    row.YJFZ = value;
                                    break;
                                case "YJFS":
                                    row.YJFS = value;
                                    break;
                                case "SYDZ":
                                    row.SYDZ = value;
                                    break;
                                case "ZJCFSJ":
                                    row.ZJCFSJ = value;
                                    break;
                                case "YJYXSD":
                                    row.YJYXSD = value;
                                    break;
                                case "SFYX":
                                    row.SFYX = value;
                                    break;
                                case "XDSJD":
                                    row.XDSJD = value;
                                    break;
                                case "CFCS":
                                    row.CFCS = value;
                                    break;
                            }
                        }
                        #endregion
                        info.Table.AddyjRow(row);

                    }
                }
            }
            catch
            {
                //
            }

            return info;
        }

        internal void Save(Session session)
        {
            for (int index = 0; index < this.Table.Rows.Count; index++)
            {
                this.Table[index]["ID"] = (index + 1).ToString();
            }
            string path = GetPath(session);
            FileInfo file = new FileInfo(path);
            using (FileStream steam = file.Create())
            {
                StreamWriter sw = new StreamWriter(steam);
                sw.WriteLine("<?xml version=\"1.0\" standalone=\"yes\"?>");
                sw.WriteLine("<Context>");
                foreach (DataRow row in this.Table)
                {
                    sw.WriteLine("<yj>");

                    sw.WriteLine(string.Format("<ID>{0}</ID>", row["ID"]));
                    sw.WriteLine(string.Format("<YJLX>{0}</YJLX>", row["YJLX"]));
                    sw.WriteLine(string.Format("<YJX>{0}</YJX>", row["YJX"]));
                    sw.WriteLine(string.Format("<YJTJ>{0}</YJTJ>", row["YJTJ"]));
                    sw.WriteLine(string.Format("<YJFZ>{0}</YJFZ>", row["YJFZ"]));
                    sw.WriteLine(string.Format("<YJFS>{0}</YJFS>", row["YJFS"]));
                    sw.WriteLine(string.Format("<SYDZ>{0}</SYDZ>", row["SYDZ"]));
                    sw.WriteLine(string.Format("<ZJCFSJ />", row["ZJCFSJ"]));
                    sw.WriteLine(string.Format("<YJYXSD>{0}</YJYXSD>", row["YJYXSD"]));
                    sw.WriteLine(string.Format("<SFYX>{0}</SFYX>", row["SFYX"]));
                    sw.WriteLine(string.Format("<XDSJD>{0}</XDSJD>", row["XDSJD"]));
                    sw.WriteLine(string.Format("<CFCS>{0}</CFCS>", row["CFCS"]));
                    sw.WriteLine("</yj>");
                }
                sw.WriteLine("</Context>");
                sw.Flush();
            }
        }

        internal void DeleteRow(DataRow dataRow)
        {
            this.Table.Rows.Remove(dataRow);
    
            this.Save(App.CurrentApp.Session);
        }

        internal void UpdateRow(DataRow dataRow)
        {
            if (dataRow.Table == null || dataRow.RowState == DataRowState.Deleted || dataRow.RowState == DataRowState.Detached)
            {
                dataRow["ID"] = (this.Table.Rows.Count + 1).ToString();
                this.Table.Rows.Add(dataRow);
            }
            this.Save(App.CurrentApp.Session);
        }

        internal Context.yjRow CreateRow()
        {
            return this.Table.NewyjRow();
        }
    }
}
