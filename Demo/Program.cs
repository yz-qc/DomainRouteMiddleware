using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();//添加中间件服务
var app = builder.Build();


app.MapControllerRoute(
    name: "default"
    , pattern: "api/{controller}/{action}"  //控制器
    , defaults: new { Action = "Index" }
);


//app.MapGet("/", () => "Hello World!");

app.UseMiddleware<DomainRouteMiddleware.ExportRoute>();//添加域名路由中间件

//设置静态资源访问权限，目录定位根目录（便于路由中间件的使用）
app.UseFileServer(new FileServerOptions()
{
    FileProvider = new PhysicalFileProvider($"{System.Environment.CurrentDirectory}\\")//指定目录 这里指定C盘,也可以是其它目录
});

app.Run();
