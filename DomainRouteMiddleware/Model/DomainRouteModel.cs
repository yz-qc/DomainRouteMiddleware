

namespace DomainRouteMiddleware.Model
{
    /// <summary>
    /// 域名模型
    /// </summary>
    public class DomainRouteModel:ModelBase
    {
        /// <summary>
        /// 域名名称  如：www.slcms.com，则域名名称就为：www
        /// </summary>
        public string DomainMatch { get; set; } = "";
        /// <summary>
        /// 匹配路径
        /// </summary>
        public string ToPath { get; set; } = "";

    }
}
