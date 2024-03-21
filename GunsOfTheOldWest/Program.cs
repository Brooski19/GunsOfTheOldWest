var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Winner",
    pattern: "Winner",
    defaults: new { controller = "Home", action = "Winner" });

app.MapControllerRoute(
    name: "Summary",
    pattern: "Summary",
    defaults: new { controller = "Home", action = "Summary" });

app.MapControllerRoute(
    name: "Reload",
    pattern: "Reload",
    defaults: new { controller = "Home", action = "Reload" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
