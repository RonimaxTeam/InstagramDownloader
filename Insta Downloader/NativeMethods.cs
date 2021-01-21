using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Insta_Downloader
{
    class NativeMethods
    {

        #region Externals

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetGetCookieEx(string lpszUrl, string lpszCookieName, StringBuilder lpszCookieData, ref int lpdwSize, int dwFlags, IntPtr lpReserved);

        #endregion

        #region Constants

        public const int ERROR_INSUFFICIENT_BUFFER = 122;

        public const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

        public const int INTERNET_COOKIE_RESTRICTED_ZONE = 0x00020000;

        public const int INTERNET_COOKIE_THIRD_PARTY = 0x10;

        #endregion
    }
}

