//reads appsettings.json,launch settings.json + creates webserver
var builder = WebApplication.CreateBuilder(args);

//A LACE TO ADD SERVICES
// Add services to the container.
builder.Services.AddControllersWithViews();

//logic to run controller and view in kestral web server
builder.Services.AddSession();
//builder.Services.AddAuthentication();
//builder.Services.AddRouting();

var app = builder.Build();//AFTER BUILD U CANNOT ADD SERVICES

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
