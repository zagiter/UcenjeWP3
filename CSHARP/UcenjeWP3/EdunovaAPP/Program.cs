using EdunovaAPP.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// svi se od svuda na sve na�ine mogu spojiti na na� API
// �itaj https://code-maze.com/aspnetcore-webapi-best-practices/
builder.Services.AddCors(opcije =>
{
    opcije.AddPolicy("CorsPolicy",
        builder =>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

});


// Dodavanje baze podataka
builder.Services.AddDbContext<EdunovaContext>(o => {
    o.UseSqlServer(builder.Configuration.GetConnectionString("EdunovaContext"));
} );



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

app.UseCors("CorsPolicy");

// za potrebe produkcije

app.UseStaticFiles();
app.UseDefaultFiles();
app.MapFallbackToFile("index.html");

// zavr�ena potreba produkcije

app.Run();
