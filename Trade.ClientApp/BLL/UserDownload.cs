using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.ClientApp.BLL
{
    internal class UserDownload
    {
        //public UserDownload()
        //{
        //    this.service = new DictionarySrv.DictionaryService();
        //    this.service.GetIniConfigCompleted += new DictionarySrv.GetIniConfigCompletedEventHandler(service_GetIniConfigCompleted);
        //}

        //public event Action<string> DownLoadCompleted;
        //public event Action<string> DownLoadExceptioned;

        //private DictionarySrv.DictionaryService service;

        //public void DownUser()
        //{
        //    this.service.GetIniConfigAsync(new object());
        //}

        //private void service_GetIniConfigCompleted(object sender, DictionarySrv.GetIniConfigCompletedEventArgs e)
        //{
        //    if (e.Cancelled)
        //    {
        //        return;
        //    }
        //    if (e.Error != null)
        //    {
        //        OnDownloadExceptioned(e);
        //    }
        //    else
        //    {
        //        this.OnDownloadCompleted(e.Result);
        //    }
        //}

        //private void OnDownloadCompleted(string result)
        //{
        //    if (this.DownLoadCompleted != null)
        //    {
        //        //解密
        //        this.DownLoadCompleted(result);
        //    }
        //}

        //private void OnDownloadExceptioned(DictionarySrv.GetIniConfigCompletedEventArgs e)
        //{
        //    if (this.DownLoadExceptioned != null)
        //    {
        //        this.DownLoadCompleted(e.Error.Message);
        //    }
        //}

    }
}
