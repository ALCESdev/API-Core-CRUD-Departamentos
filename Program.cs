using API_CRUD_Departamentos.Data;
using API_CRUD_Departamentos.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Inyeccion de dependencias
String? cadenaconexion = builder.Configuration.GetConnectionString("cadenahospitalazure");

builder.Services.AddTransient<RepositoryDepartamentos>();
builder.Services.AddDbContext<DepartamentosContext>(options => options.UseSqlServer(cadenaconexion));

builder.Services.AddControllers();

// Add services to the container.
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
