using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace DomainRouteMiddleware
{
    /// <summary>
    /// 路由中间件，包含静态方法
    /// </summary>
    public class ExportRoute
    {
        public RequestDelegate _next;

        /// <summary>
        /// 路由配置
        /// </summary>
        public static readonly Model.RouteModel Config = ConfigHelp.RouteConfig;

        /// <summary>
        /// 跳过规则，加入跳过规则，则表示访问的context.Request.Path存在跳过规则中的时候，直接跳过，不进行二次路由 导出
        /// </summary>
        static Dictionary<string, bool> passPath = new();

        /// <summary>
        /// 路由规则缓存
        /// </summary>
        static Dictionary<string, string> cacheRoute = new();

        
        public ExportRoute(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            if (!ConfigHelp.RouteConfig.Switch) return _next.Invoke(context); //关闭路由的情况下，直接跳过
            string path = context.Request.Path; //当前相对路径
            //string ext = Path.GetExtension(path).ToLower(); //获取当前文件地址的扩展名

            #region 已经路由过的，直接跳过路由(设置context.Request.Path后，会再次进入此控制器，此处既是针对路由过来的情况，直接跳过，避免再次路由进入死循环)
            //已经路由过的，直接跳过路由
            if (passPath.ContainsKey(context.Request.Path))
            {
                return _next.Invoke(context);
            }
            #endregion

            #region 跳过规则配置直接跳过（路由白名单，针对控制器的路径规则，直接跳过）
            //跳过规则配置直接跳过
            string pathlower = context.Request.Path.Value.ToLower();
            foreach (var str in ConfigHelp.RouteConfig.JumpPaths)
            {
                if (pathlower.StartsWith(str))
                {
                    return _next.Invoke(context);
                }
            }
            #endregion

            #region 域名缓存路由匹配（域名路由匹配一次之后，则不需要再次进入循环遍历正则去匹配，可以直接路由到之前匹配到的路径）
            string domain = context.Request.Host.Host; //获取域名
            if (cacheRoute.ContainsKey(domain))
            {
                context.Request.Path = cacheRoute[domain]; //设置路由
                Console.WriteLine($"路由缓存命中：{domain} 转 {context.Request.Path}");
                return _next.Invoke(context);
            }
            #endregion

            #region 本地访问是不需要进行路由的，这里就可以直接路由到默认静态资源的路径
            if (domain.ToLower() == "localhost" || Fun.IsIP(domain))
            {
                SetRoute(context, $"{Config.DefaultPath}{path}");
                return _next.Invoke(context);  //若为ip或者localhost本地访问，则直接使用默认路由
            }
            #endregion

            #region 域名路由规则
            Console.WriteLine($"完整域名：{domain}，url访问路径：{path}");
            foreach (var item in ConfigHelp.RouteConfig.DomainRoute)
            {
                string toPath = item.ToPath;
                Regex re = new(item.DomainMatch, RegexOptions.IgnoreCase);
                string matcbDomain = context.Request.Host.Host + "/"; //正则匹配给域名尾部加入固定结尾，方便正则编写

                if (re.IsMatch(matcbDomain))
                {
                    toPath = re.Replace(matcbDomain, toPath);
                    var temppath = $"{toPath}{path}"; //组件路由path
                    SetRoute(context, temppath, domain); //设置路由
                    Console.WriteLine($"路由命中后的路径：{context.Request.Path}，命中规则：{item}");
                    return _next.Invoke(context); //命中路由后不需要下面的解析，直接跳过
                }
            }
            #endregion

            SetRoute(context, $"{Config.DefaultPath}{path}");
            return _next.Invoke(context);
        }

        /// <summary>
        /// 设置路由
        /// </summary>
        private static void SetRoute(HttpContext context, string toPath, string domain = "")
        {
            if (string.IsNullOrWhiteSpace(toPath) || toPath == "/")  //路由到根目录的话，直接可以跳过
            {
                passPath[toPath] = true; //设加入跳过规则
                return;
            }
            if (!toPath.StartsWith("/")) toPath = $"/{toPath}";//前置必须加杠，否则会报错
            passPath[toPath] = true; //设加入跳过规则
            if (!string.IsNullOrWhiteSpace(domain))
            {
                cacheRoute[domain] = toPath;//加入路由规则缓存
            }
            context.Request.Path = toPath; //设置路由
        }

        /// <summary>
        /// 清空路由缓存
        /// </summary>
        public static void ClearCache()
        {
            passPath = new();
            cacheRoute = new();
        }

        /// <summary>
        /// 重载路由
        /// </summary>
        public static void Reload()
        {
            ConfigHelp.ReLoadConfig();
            ClearCache();
        }

    }
}