var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();
app.UseDefaultFiles();
app.MapFallbackToFile("index.html");
app.Run();
