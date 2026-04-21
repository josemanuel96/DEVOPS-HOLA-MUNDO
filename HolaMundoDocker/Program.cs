var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Mundo desde C# con Docker, GitHub Actions y Render");

app.Run();