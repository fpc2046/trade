using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace Trade.ClientApp.BLL
{
    internal class Session
    {
        internal Session(string userName, string pwd, string lastTime, string lastAddress, CookieContainer cookie)
        {
            this.UserName = userName;
            this.PassWord = pwd;
            this.LastAddress = lastAddress;
            this.LastTime = lastTime;
            this.Cookie = cookie;
        }

        internal CookieContainer Cookie { get; private set; }
        internal string Environment { get; set; }
        internal string UserName { get; private set; }
        internal string PassWord { get; set; }
        internal string LastTime { get; private set; }
        internal string LastAddress { get; private set; }
        
    }
}
