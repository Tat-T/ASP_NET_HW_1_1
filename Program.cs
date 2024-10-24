var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();/*для конфигурирования и запуска приложения*/
var app = builder.Build();
app.UseStaticFiles();/*для обслуживания статических файлов*/

app.MapRazorPages();/*Настройка маршрутизации*/

app.Run();