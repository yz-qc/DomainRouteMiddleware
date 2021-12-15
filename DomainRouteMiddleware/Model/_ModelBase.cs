using Newtonsoft.Json;

namespace DomainRouteMiddleware.Model
{
    public class ModelBase
    {
        /// <summary>
        /// 序列化为json字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  JsonConvert.SerializeObject(this, new JsonSerializerSettings()
            {
                ContractResolver = new FirstLowerContractResolver()
            }); ;
        }
    }
}
