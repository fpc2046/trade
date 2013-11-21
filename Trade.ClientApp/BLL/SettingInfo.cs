using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Trade.ClientApp.BLL
{
    internal class SettingInfo
    {
        private SettingInfo()
        {
            this.FailShowDialog = true;
            this.SuccessShowDialog = true;
            this.ShowDialog = true;
            this.FloatAlertWindowStayTime = 1;
            this.LockTime = 1;
        }

        public bool SuccessShowDialog { get; set; }
        public bool ShowDialog { get; set; }
        public bool FailShowDialog { get; set; }
        public int FloatAlertWindowStayTime { get; set; }
        public bool LockEnable { get; set; }
        public int LockTime { get; set; }
        public int LastTradeIdControl { get; set; }


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
            return string.Format("{0}{1}Trade.ini", dirName, session.UserName);
        }

        public void Save(Session session)
        {
            string path = SettingInfo.GetPath(session);

            string temp = @"[Set]
SuccessShowDialog={0}
ShowDialog={1}
FailShowDialog={2}
FloatAlertWindowStayTime={3}
[LockSet]
LockEnable={4}
LockTime={5}
[SystemMessage]
LastTradeIdControl={6}";
            SettingInfo info = this;
            temp = string.Format(temp, info.SuccessShowDialog,
                info.ShowDialog,
                info.FailShowDialog,
                info.FloatAlertWindowStayTime,
                info.LockEnable,
                info.LockTime,
                info.LastTradeIdControl);

            File.WriteAllText(path, temp);
        }

        public static SettingInfo Read(Session session)
        {
            SettingInfo info = new SettingInfo();
            string path = SettingInfo.GetPath(session);

            try
            {
                if (File.Exists(path))
                {
                    string setting = null;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        setting = reader.ReadToEnd();
                    }
                    string[] setItems = (setting ?? string.Empty).Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string item in setItems)
                    {
                        string[] items = item.Split('=');
                        if (items.Length != 2)
                        {
                            continue;
                        }

                        string key = (items[0] ?? string.Empty).Trim().ToUpper();
                        string value = (items[1] ?? string.Empty).Trim();

                        switch (key)
                        {
                            case "SUCCESSSHOWDIALOG":
                                info.SuccessShowDialog = bool.Parse(value);
                                break;
                            case "SHOWDIALOG":
                                info.ShowDialog = bool.Parse(value);
                                break;
                            case "FAILSHOWDIALOG":
                                info.FailShowDialog = bool.Parse(value);
                                break;
                            case "FLOATALERTWINDOWSTAYTIME":
                                info.FloatAlertWindowStayTime = int.Parse(value);
                                break;
                            case "LOCKENABLE":
                                info.LockEnable = bool.Parse(value);
                                break;
                            case "LOCKTIME":
                                info.LockTime = int.Parse(value);
                                break;
                            case "LASTTRADEIDCONTROL":
                                info.LastTradeIdControl = int.Parse(value);
                                break;
                        }
                    }
                }
            }
            catch
            {
                //
            }
            return info;
        }
    }
}
