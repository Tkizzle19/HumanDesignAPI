using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using HumanDesign;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Human Design API is live!");

app.MapPost("/calculate", async (HttpContext context) =>
{
    var input = await context.Request.ReadFromJsonAsync<HumanDesignRequest>();
    if (input == null)
        return Results.BadRequest("Invalid input");

    var chart = Chart.Generate(input.DateTime, input.Latitude, input.Longitude);
    return Results.Ok(chart);
});

app.Run();

record HumanDesignRequest(DateTime DateTime, double Latitude, double Longitude);
