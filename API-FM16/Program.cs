using CORE_FM16.Entidades;
using CORE_FM16.Repositorio.Dependencias;
using CORE_FM16.Repositorio.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<oCon>(builder.Configuration.GetSection("ConnectionStrings"));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


////ADD INYECCION DE DEPENDENCIAS

builder.Services.AddScoped<IPersonalFormularioRegistro, PersonalFormularioRegistro>();

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
