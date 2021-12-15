using Newtonsoft.Json.Serialization;

namespace DomainRouteMiddleware
{
    /// <summary>
    /// 反序列化时，将字段首字母转为小写
    /// </summary>
    internal class FirstLowerContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return $"{propertyName[0].ToString().ToLower()}{propertyName[1..]}";
        }
    }
}
