var builder = WebApplication.CreateBuilder(args);

// Add services to the container (if needed in the future).
var app = builder.Build();

// Enable serving static files
app.UseStaticFiles();

// Set default file to index.html
app.UseDefaultFiles();

// Configure fallback to index.html
app.MapFallbackToFile("index.html");

app.Run();
