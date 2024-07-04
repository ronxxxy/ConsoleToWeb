var webAppBuilder = WebApplication.CreateBuilder();

var app = webAppBuilder.Build();

app.MapGet("/", () => "Hello World, We are happy.");

app.Run();
