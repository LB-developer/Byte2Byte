using Byte2Byte.Data;
using Byte2Byte.Services;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddControllers();
builder.Services.AddScoped<LoopsService>();

var dbConnectionString = builder.Configuration["Byte2Byte:DatabaseConnectionString"];
MongoClient client = new MongoClient(connectionString: dbConnectionString);

var dbContextOptions =
    new DbContextOptionsBuilder<ByteDbContext>().UseMongoDB(client, "ByteDB");

builder.Services.AddSingleton(new ByteDbContext(dbContextOptions.Options));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.MapControllers();
app.Run();
