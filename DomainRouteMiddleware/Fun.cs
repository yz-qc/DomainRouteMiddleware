using System.Text.RegularExpressions;


namespace DomainRouteMiddleware
{
    internal class Fun
    {
        #region 判断是否IP——静态方法
        /// <summary>
        /// 判断是否IP
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            // 判断是否为IP 
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        #endregion
    }
}
