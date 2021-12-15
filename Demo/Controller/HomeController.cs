using Microsoft.AspNetCore.Mvc;
using DomainRouteMiddleware;

namespace Demo.Controller
{
    public class HomeController : ControllerBase
    {
        public string Index(string a)
        {
            return $"Hello Home {a}";
        }

        /// <summary>
        /// 重载路由
        /// </summary>
        /// <returns></returns>
        public string ReloadRoute()
        {
            ExportRoute.Reload();
            return $"路由配置：{ExportRoute.Config}";
        }

        /// <summary>
        /// 清空路由缓存
        /// </summary>
        public string ClearRouteCache()
        {
            ExportRoute.ClearCache();
            return "已清理";
        }
    }
}
