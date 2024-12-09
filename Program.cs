using ListagemAPi.Domain.DTOs;
using ListagemAPi.Domain.Services;
using ListagemAPi.Infraestrutura.Db;
using ListagemAPi.Infraestrutura.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<iAdmServices , AdminServices>();

builder.Services.AddDbContext<DbContexto>(options =>{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("CONNECT")
    );
}
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login" , ([FromBody]LoginDTO loginDTO,iAdmServices iAdmServices ) => {
    if(iAdmServices.Login(loginDTO) != null)
    {
        return Results.Ok("Login Sucess");
    }else
    {
        return Results.Unauthorized();
    }
});

app.Run();
