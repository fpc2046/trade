using System;

namespace Trade.Model
{
    public class LoginInfo
    {
        public LoginInfo() 
        {
            //
        }

        public LoginInfo(string sessionID, DateTime dateTime, string name, string address)
        {
            this.SessionID = sessionID;
            this.LoginTime = dateTime;
            this.UserName = name;
            this.Address = address;
        }

        public DateTime LoginTime { get; set; }

        public string UserName { get; set; }

        public string SessionID { get; set; }

        public string Address { get; set; }
    }
}