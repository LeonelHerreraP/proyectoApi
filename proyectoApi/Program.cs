using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoApi;
using proyectoApi.Models;
using proyectoApi.ViewModels;
using System.Data.SqlClient;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PasantesDGMContext>(opciones=> opciones.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<InterfaceSoli, SolicitudService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/Personas", () =>
{
    using (var context = new PasantesDGMContext())
    {
        return context.Personas.ToList();
    } 
});

app.MapGet("/Solicitudes", () =>
{
    using (var context = new PasantesDGMContext())
    {
        return context.Solicituds.ToList();
    }
});

//app.MapPost("/CambiarEstado", async ([FromBody] cambiarEstadoVM vm, [FromServices] PasantesDGMContext context) =>

app.MapPost("/CambiarEstado", async (InterfaceSoli soli, [FromBody] cambiarEstadoVM vm, [FromServices] PasantesDGMContext context) =>
{
    var response =await soli.UpdateState(vm);
    if(response) return Results.Ok("Hecho!");
    return Results.Ok(response);

});



app.Run();
