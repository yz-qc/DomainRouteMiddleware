
namespace DomainRouteMiddleware.Model
{
    /// <summary>
    /// 路由配置
    /// </summary>
    public class RouteModel : ModelBase
    {
        /// <summary>
        /// 路由开关
        /// </summary>
        public bool Switch { get; set; }

        /// <summary>
        /// 跳过path路径，访问路径开头匹配列表中的字符串，则该路径不判断域名路由，正常访问（通常作为控制器路径的白名单），必须以"/"开头
        /// </summary>
        public List<string> JumpPaths { get; set; } = new List<string>();

        /// <summary>
        /// 默认静态资源地址
        /// </summary>
        public string DefaultPath { get; set; } = string.Empty;

        /// <summary>
        /// 域名路由
        /// </summary>
        public List<DomainRouteModel> DomainRoute { get; set; } = new List<DomainRouteModel>();


        #region 保存配置
        /// <summary>
        /// 保存配置
        /// </summary>
        public void Save()
        {
            File.WriteAllTextAsync(ConfigHelp.SystemConfig.RouteConfigPath.ToString(), ToString());
        }
        #endregion


    }
}
