using Microsoft.EntityFrameworkCore;
using NetApp.Entities;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Базовая настройка Builder
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();


WebApplication app = builder.Build();


// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

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


// Хороший код Contexts
// https://github.com/nklqs/dotnetwebapi/blob/master/WebAPI%20RBAC

// Хороший код Program
// https://github.com/woookle/simple-aspNet/blob/main/Program.cs