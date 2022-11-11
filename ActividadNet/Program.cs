using ActividadNet.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Bootcamp bootcamp = new Bootcamp(4);

User u1 = new User(1, "Paco");
User u2 = new User(2, "Carlos");
User u3 = new User(3, "Diego");
User u4 = new User(4, "Javi");

List<User> users = new List<User>();
users.Add(u1);
users.Add(u2);
users.Add(u3);
users.Add(u4);

bootcamp.users = users;

app.MapGet("/", () => "Hello");
app.MapGet("/bootcamp/{id}/people", () => "list");
app.MapPost("/bootcamp/{id}/people", () => "create");
//app.MapDelete("/bootcamp/{id}/people/{id}", () => "delete");
//app.MapPut("/bootcamp/{id}/people/{id}", () => "update");

app.Run();
