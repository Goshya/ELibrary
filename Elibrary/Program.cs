var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}"
    );

app.Run();
