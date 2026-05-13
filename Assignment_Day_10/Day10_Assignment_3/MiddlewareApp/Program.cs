using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception)
    {
        await context.Response.WriteAsync("An error occurred");
    }
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Request Path: " + context.Request.Path);
    await next();
    Console.WriteLine("Response Status Code: " + context.Response.StatusCode);
});


app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    context.Response.Headers["Content-Security-Policy"] = "default-src 'self'; script-src 'self' 'unsafe-inline'; style-src 'self';";
    await next();
});

app.UseDefaultFiles();


app.UseStaticFiles();
// app.MapGet("/", async context =>
// {
//     context.Response.Redirect("/index.html");
// });

app.Run();

