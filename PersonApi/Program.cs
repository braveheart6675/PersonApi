using Microsoft.EntityFrameworkCore;
using PersonApi.Data;
using PersonApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add EF Core with InMemory for simplicity
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("PersonDb"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.MapGrpcService<PersonServiceImplementation>();


app.Run();
