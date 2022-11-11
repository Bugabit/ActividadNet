using ActividadNet.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



Bootcamp bootcamp = new Bootcamp(4);
bootcamp.AddUser(new User(1, "Paco"));
bootcamp.AddUser(new User(2, "Carlos"));
bootcamp.AddUser(new User(3, "Diego"));
bootcamp.AddUser(new User(4, "Javi"));

User bootcamp = new Bootcamp(4);

app.MapGet("/bootcamp/{id}/", () => "Hello World!");
app.MapGet("/", () => "Hello World!");
app.MapGet("/", () => "Hello World!");
app.MapGet("/", () => "Hello World!");

app.Run();
