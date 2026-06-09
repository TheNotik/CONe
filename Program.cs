using Microsoft.EntityFrameworkCore;
using Producer.Data;
using Producer.Service;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<PersonService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

app.MapGet("/person/{pin}", (string pin, PersonService service) =>
{
    var person = service.GetByPin(pin);
    if (person == null)
        return Results.NotFound(new { message = "Человек не найден" });
    return Results.Ok(person);
});

app.MapGet("/persons", (PersonService service) =>
{
    return Results.Ok(service.GetAll());
});
// Добавить человека
app.MapPost("/person", (Person person, PersonService service) =>
{
    service.Add(person);
    return Results.Ok(person);
});

// Удалить человека
app.MapDelete("/person/{pin}", (string pin, PersonService service) =>
{
    var result = service.Delete(pin);
    if (!result) return Results.NotFound();
    return Results.Ok();
});




app.Run();