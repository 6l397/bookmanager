var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Urls.Clear();
app.Urls.Add("http://+:80");

app.Run();