# DomainRouteMiddleware

域名路由中间件可以控制不同的域名，来指向不同的静态资源目录，不需要在域名后面指定具体哪个目录。
启用缓存机制，同一个域名的路由解析只有一次，之后都走缓存，所以不存在性能问题，解析速度非常快。
在保证缓存的前提下，同时提供清除缓存与热重载的功能，保证路由规则改动之后不需要重启服务即可重载路由配置。

使用说明

一、hosts绑定以下域名

```
127.0.0.1 domain.com
127.0.0.1 www.domain.com
127.0.0.1 admin.domain.com
127.0.0.1 wap.domain.com
127.0.0.1 tpl-a.domain.com
127.0.0.1 tpl-b.domain.com
127.0.0.1 tpl-c.domain.com
```



二、启动demo


三、分别访问hosts绑定的域名，可以看到，不同域名指向不同的静态资源目录
    访问时，需要加端口
    如启动demo的访问地址为：https://localhost:7005，则域名访问的时候，地址为：
    
```
    https://www.domain.com:7005
    https://admin.domain.com:7005
    https://wap.domain.com:7005
    https://tpl-a.domain.com:7005
    https://tpl-b.domain.com:7005
    https://tpl-c.domain.com:7005
```
     **ps:加端口只是调试环境使用，若在线上使用80或者443端口，则无需加端口号** 


四、访问“/api/home/ReloadRoute”控制器可以热重载修改后的路由规则（该方法同时会清除路由缓存）


五、访问“/api/home/ClearRouteCache”控制器可以清理路由缓存


六、启动中间件：app.UseMiddleware<DomainRouteMiddleware.ExportRoute>(); 
    需要在 app.UseFileServer(new FileServerOptions(){FileProvider = new PhysicalFileProvider($"{System.Environment.CurrentDirectory}\\")}); 
   之前调用，详情见demo

