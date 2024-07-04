var webAppBuilder = WebApplication.CreateBuilder();

var app = webAppBuilder.Build();

app.MapGet("/", () => "Hello World");

app.Run();