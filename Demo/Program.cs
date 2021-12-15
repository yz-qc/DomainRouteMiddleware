using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();//����м������
var app = builder.Build();


app.MapControllerRoute(
    name: "default"
    , pattern: "api/{controller}/{action}"  //������
    , defaults: new { Action = "Index" }
);


//app.MapGet("/", () => "Hello World!");

app.UseMiddleware<DomainRouteMiddleware.ExportRoute>();//�������·���м��

//���þ�̬��Դ����Ȩ�ޣ�Ŀ¼��λ��Ŀ¼������·���м����ʹ�ã�
app.UseFileServer(new FileServerOptions()
{
    FileProvider = new PhysicalFileProvider($"{System.Environment.CurrentDirectory}\\")//ָ��Ŀ¼ ����ָ��C��,Ҳ����������Ŀ¼
});

app.Run();
