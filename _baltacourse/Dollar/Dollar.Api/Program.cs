using Dollar.Api.Data;
using Dollar.Core.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
    {x.CustomSchemaIds(n => n.FullName);});

builder.Services.AddTransient<Handler>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.MapPost(
        "/categories",
        (Request request, Handler handler) => handler.Handle(request))
    .WithName("Categories : Create")
    .WithSummary("Cria uma nova Categoria")
    .Produces<Response>();
    
   

app.MapGet(
    "/", 
    () => "Hello World!");
app.MapPut(
    "/", () 
        => "Hello World!");
app.MapDelete(
    "/", 
    () => "Hello World!");

app.Run();


public class Request
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}


public class Response
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
}


public class Handler(AppDbContext dbContext)
{
    
    public Response Handle(Request request)
    {

        var category = new Category()
        {
            Title = request.Title,
            Description = request.Description
        };
        
        dbContext.Categories.Add(category);
        dbContext.SaveChanges();
        
        return new Response
        {
            Id = category.Id,
            Title = category.Title,
        };
    }
}
