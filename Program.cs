using Microsoft.EntityFrameworkCore;
using NetApp.Entities;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Базовая настройка Builder
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


WebApplication app = builder.Build();


app.UseHttpsRedirection();


// Minimal API - Бизнес-логика прямо в коде.
app.MapGet("/api", () =>
{
    var entity =  Enumerable.Range(1, 5).Select(index =>
        new MyEntity
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            "MyFirstString"
        ))
        .ToArray();
    return entity;
})
.WithName("GetData");


app.Urls.Add("http://localhost:8080");
app.Run();


// Хороший код
// https://github.com/nklqs/dotnetwebapi/blob/master/WebAPI%20RBAC

// Хороший код
// https://github.com/woookle/simple-aspNet/blob/main
