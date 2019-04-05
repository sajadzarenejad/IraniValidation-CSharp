using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace IraniValidator
{
    public static class ComputerAndInternetValidation
    {
        public static readonly string EmailRegEx = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        public static readonly string UrlRegEx = @"_^(?:(?:https?|ftp)://)(?:\S+(?::\S*)?@)?(?:(?!10(?:\.\d{1,3}){3})(?!127(?:\.\d{1,3}){3})(?!169\.254(?:\.\d{1,3}){2})(?!192\.168(?:\.\d{1,3}){2})(?!172\.(?:1[6-9]|2\d|3[0-1])(?:\.\d{1,3}){2})(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z\x{00a1}-\x{ffff}0-9]+-?)*[a-z\x{00a1}-\x{ffff}0-9]+)(?:\.(?:[a-z\x{00a1}-\x{ffff}0-9]+-?)*[a-z\x{00a1}-\x{ffff}0-9]+)*(?:\.(?:[a-z\x{00a1}-\x{ffff}]{2,})))(?::\d{2,5})?(?:/[^\s]*)?$_iuS";
        public static readonly string IpV4RegEx = @"^(?:(?:^|\.)(?:2(?:5[0-5]|[0-4]\d)|1?\d?\d)){4}$";
        public static readonly string IpV6RegEx = @"";



        public static bool IsValidEmailAddress(this string email)
        {
            var regex = new Regex(EmailRegEx);
            return regex.IsMatch(email);
        }

        public static bool IsValidUrl(this string url)
        {
            var regex = new Regex(UrlRegEx);
            return regex.IsMatch(url);
        }

        public static bool IsValidIpV4(this string ipv4)
        {
            IPAddress ip;
            if (IPAddress.TryParse(ipv4, out ip))
            {
                return ip.AddressFamily == AddressFamily.InterNetwork;
            }
            return false;
        }

        public static bool IsValidIpV6(this string ipv6)
        {
            IPAddress ip;
            if (IPAddress.TryParse(ipv6, out ip))
            {
                return ip.AddressFamily == AddressFamily.InterNetworkV6;
            }
            return false;
        }
    }
}
