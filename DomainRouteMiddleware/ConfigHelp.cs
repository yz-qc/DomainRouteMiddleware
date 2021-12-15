using Newtonsoft.Json;
using DomainRouteMiddleware.Model;

namespace DomainRouteMiddleware
{
    internal class ConfigHelp
    {
        internal static dynamic SystemConfig = LoadConfig<dynamic>("appsettings.json");//读系统配置

        #region 路由配置
        private static RouteModel? _routeconfig;
        /// <summary>
        /// 路由配置
        /// </summary>
        internal static RouteModel RouteConfig
        {
            get
            {
                if (_routeconfig == null)
                {
                    _routeconfig = LoadConfig<RouteModel>(SystemConfig.RouteConfigPath.ToString());
                }
                return _routeconfig;
            }
        }
        #endregion

        #region 载入或重载配置文件(正常情况下，该方法启动程序后，只会加载一次)
        /// <summary>
        /// 载入或重载配置文件(正常情况下，该方法启动程序后，只会加载一次) 处理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path">配置文件地址</param>
        /// <param name="strHandle">读取文件内容后，在转换之前进行的处理，返回转换后的文本，适合对配置文件进行加密后的处理</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected static T LoadConfig<T>(string path, Func<string, string>? strHandle = null)
        {
            if (!File.Exists(path))
                throw new Exception($"文件（{path}）不存在！");
            try
            {
                string configStr = File.ReadAllText(path);
                Console.WriteLine($"内存配置载入完毕！{configStr}");
                if (strHandle != null)
                {
                    configStr = strHandle(configStr);
                }
                return JsonConvert.DeserializeObject<T>(configStr) ?? Activator.CreateInstance<T>();
            }
            catch (Exception)
            {
                Console.WriteLine($"配置文件{path}被占用！等待500ms后重试...");
                Thread.Sleep(500);
                return LoadConfig<T>(path);
            }
        }
        #endregion

        #region 重载配置
        internal static void ReLoadConfig()
        {
            _routeconfig = null;
        }
        #endregion


    }
}
