using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Movieapp.Models;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString=builder.Configuration.GetConnectionString("mycon");
builder.Services.AddDbContext<MovieContext>(options=>options.UseSqlServer(connectionString));
builder.Services.AddCors(
    
    options=>{
        options.AddDefaultPolicy(
        
        builder=>{
            builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        

    });
   
});

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
