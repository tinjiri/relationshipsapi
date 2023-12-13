using Microsoft.EntityFrameworkCore;
using relationshipsapi.Data;
using relationshipsapi.Abstract;
using relationshipsapi.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(configuration.GetConnectionString("dataccess")));

builder.Services.AddScoped<IRepo, Repo>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMicroservices",
        b =>
        {
               b.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
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
