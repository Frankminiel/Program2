using Microsoft.EntityFrameworkCore;
using Todos_Podemos.API.DB;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://127.0.0.1:5005");

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("\"Server=FRANCK\\SQLEXPRESS;Database=todos_podemos;Trusted_Connection=True;TrustServerCertificate=True;\"")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

app.MapGet("/", () => "API OK");
app.MapGet("/ping", () => "pong");

app.MapControllers();

app.Run();