
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/", async context =>
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});

app.Run("http://0.0.0.0:3000");
