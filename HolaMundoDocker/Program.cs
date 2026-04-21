var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Mundo desde C# con Docker, GitHub Actions y Render, 🔥 PIPELINE FUNCIONANDO AUTOMATICO 🔥");

app.Run();