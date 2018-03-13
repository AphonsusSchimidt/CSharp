using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;

namespace FbTools
{
    public class ThuVien
    {
        /// <summary>
        /// 
        /// </summary>
        public static void XoaCookie()
        {
            nsICookieManager CookieMan;
            CookieMan = Xpcom.GetService<nsICookieManager>("@mozilla.org/cookiemanager;1");
            CookieMan = Xpcom.QueryInterface<nsICookieManager>(CookieMan);
            CookieMan.RemoveAll();
        }
    }
}
