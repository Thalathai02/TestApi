using backend.Database;
using backend.Installers;
using backend.Module.ProductModule.Repository;
using Microsoft.EntityFrameworkCore;
using backend.Module.S3Module.Repository;
var builder = WebApplication.CreateBuilder(args);
builder.Services.InstallServiceInAssembly(builder.Configuration);


builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IS3Repository, S3Repository>();


// make sure call this because used in ProductController
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();
// Learn more about configurin g Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowAllOrigins");
app.UseStaticFiles();

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
