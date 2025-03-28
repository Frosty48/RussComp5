using Data;
using Hackerspace.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using RussComp5.Client.Pages;
using RussComp5.Components;
using RussComp5.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

//Interfaces
builder.Services.AddTransient<IBadgesPageDataService, BadgesPageServiceMock>();
builder.Services.AddTransient<IToDoService, ToDoService>();



void RunMigrations(WebApplication app)
{
    using (var scope = app.Services.CreateScope())
    {
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        db.Database.Migrate();
    }
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(RussComp5.Client._Imports).Assembly);


RunMigrations(app);
app.Run();



