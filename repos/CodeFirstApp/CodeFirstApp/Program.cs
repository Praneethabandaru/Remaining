using CodeFirstApp;
using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

//SERVICES
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKeyedTransient<IMyinter,MyMathService>("add");
//builder.Services.AddScoped<IMyinter, MyMathService>(); 
//builder.Services.AddSingleton<IMyinter, MyMathService>();

// Add services to the container.
builder.Services.AddControllersWithViews(); //process controller and view
builder.Services.AddAuthentication(); // adding authentication 
builder.Services.AddSession(); //adding session

//logic to call connection string
builder.Services.AddDbContext<SongContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("mycon")));

//builder.Configuration.GetConnectionString("mycon") : read mycon section of appsettings.json file

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //display custom page instead of built-in page
    app.UseExceptionHandler("/MySongs/Error");//this is for programming error
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//MIDDLE WARE

//to handle http error 404 
app.UseStatusCodePages();  //it will display only status code
//app.UseStatusCodePagesWithRedirects("/MySongs/Mypage"); //shows custom for 404 error here in the url will get the orginal it will change the url
app.UseStatusCodePagesWithReExecute("/MySongs/Mypage"); //show a custom page for 404 error here url is not changed

app.UseHttpsRedirection();
app.UseStaticFiles();//this is mandatory to serve static files like html,css, js, images etc.

app.UseRouting();

app.UseAuthentication();//check auth first then send the page to the user

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Use(); user can create custom middle ware

//app.UseAuthentication(); this is not valid bcz after sending the page if we check authentication it will not work
app.Run();

//after this no other instances i.e., middle ware will not work after this