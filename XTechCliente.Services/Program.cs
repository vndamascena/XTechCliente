using XTechCliente.Application.Interfaces;
using XTechCliente.Application.Services;
using XTechCliente.Domain.Interfaces.Repositories;
using XTechCliente.Domain.Interfaces.Services;
using XTechCliente.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
 config => config.AddPolicy("DefaultPolicy", builder =>
 {
     builder.AllowAnyOrigin()
     //qualquer dominio poderá acessar a API
     .AllowAnyMethod()
     //permitir POST, PUT, DELETE, GET
     .AllowAnyHeader();
     //aceitar parametros de cabeçalho de requisição
 })
 );

builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IClienteDomainService, ClienteDomainService>();
builder.Services.AddTransient<IClienteRpository, ClienteRepository>();
builder.Services.AddTransient<IHistoricoAtividadeRepository, HistoricoAtividadeRepository>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();
app.UseCors("DefaultPolicy");
app.MapControllers();

app.Run();
