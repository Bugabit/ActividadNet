using ActividadNet.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



Bootcamp bootcamp = new Bootcamp(4);
bootcamp.AddUser(new User(1, "Paco"));
bootcamp.AddUser(new User(2, "Carlos"));
bootcamp.AddUser(new User(3, "Diego"));
bootcamp.AddUser(new User(4, "Javi"));


app.MapGet("/bootcamp/{id}/people", () => "list");
app.MapPost("/bootcamp/{id}/people", () => "create");
app.MapDelete("/bootcamp/{id}/people/{id}", () => "delete");
app.MapPut("/bootcamp/{id}/people/{id}", () => "update");

app.Run();
