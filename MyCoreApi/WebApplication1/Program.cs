using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

string[] mystudents = {"Naveen","Sailesh","Apporve","Satish","Madhu","Sandya","Jayanth","Prince","Rathan"};

//how to create get method 
//app.MapGet(); app.MapPost(); app.MapDelete(); app.MapPut(); 

app.MapGet("/showall", () => mystudents.ToList());
//develop a code to display name containing 's'
app.MapGet("/showstartingwiths", (string s) => mystudents.Where(c => c.Contains(s)).ToList());

var dc = new b248dbContext();

var stu = app.MapGroup("/showstudent"); //grouping common patterns
stu.MapGet("/", () => dc.Studenttbls.ToList());

stu.MapGet("/{id}", (int id) => dc.Studenttbls.Where(c => c.Std == id));

stu.MapGet("show/{id}", (int id) =>
{
    var res = (from t in dc.Studenttbls
               where t.Std == id
               select t).FirstOrDefault();
    if(res != null)
    {
       return Results.Ok(res);
    }
    else
    {
       return Results.NotFound();
    } 
});
app.MapPost("/validate", (string name) => $"Hello, {name}!")
   .AddEndpointFilter(async (context, next) =>
   {
       var name = context.GetArgument<string>(0);
       if (string.IsNullOrEmpty(name))
           return Results.BadRequest("Name is required.");

       return await next(context);
   });

app.MapPost("addstudent", (Studenttbl s) =>
{
    dc.Studenttbls.Add(s);
    return dc.SaveChanges();
});

app.MapDelete("deletestudent", (int id) =>
{
    var res = dc.Studenttbls.Find(id);
    dc.Studenttbls.Remove(res);
    return dc.SaveChanges();

});

app.MapGet("report", () =>
{
    return "report method called";
}).AddEndpointFilter<MyLoggerMiddleware>();

//how to create post method

app.UseHttpsRedirection();
app.Run();
public class MyLoggerMiddleware : IEndpointFilter
{
    // run some logic before calling the method
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        Console.WriteLine($"Request: {context.HttpContext.Request.Method} {context.HttpContext.Request.Path}");
        Console.WriteLine("===========");
        // Call the next endpoint or filter
        var result = await next(context);
        Console.WriteLine("===========");
        // Post-processing: Log the response result
        Console.WriteLine($"Response: {result}");

        return result;
    }
}

