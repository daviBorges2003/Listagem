using ListagemAPi.Domain.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login" , (LoginDTO loginDTO) => {
    if(loginDTO.email == "adm@teste.com" && loginDTO.senha == "teste")
    {
        return Results.Ok("Login Sucess");
    }else
    {
        return Results.Unauthorized();
    }
});

app.Run();
