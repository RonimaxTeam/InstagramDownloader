using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Downloader
{
    [Flags]
    internal enum CookieRetrievalFlags
    {
        None,

        HttpOnly = NativeMethods.INTERNET_COOKIE_HTTPONLY,

        ThirdParty = NativeMethods.INTERNET_COOKIE_THIRD_PARTY,

        RestrictedZone = NativeMethods.INTERNET_COOKIE_RESTRICTED_ZONE
    }
}
