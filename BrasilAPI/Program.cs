using BrasilAPI.Interfaces;
using BrasilAPI.Mapper;
using BrasilAPI.Rest;
using BrasilAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ---

builder.Services.AddSingleton<InterfaceEndereco, EnderecoService>();
builder.Services.AddSingleton<InterfaceBanco, BancoService>();
builder.Services.AddSingleton<InterfaceCNPJ, CNPJService>();
builder.Services.AddSingleton<InterfaceNCM, NCMService>();
builder.Services.AddSingleton<InterfaceFeriadosNacionais, FeriadosNacionaisService>();

builder.Services.AddSingleton<InterfaceBrasilAPI, BrasilAPIRest>();

// ---

builder.Services.AddAutoMapper(typeof(EnderecoMapper));
builder.Services.AddAutoMapper(typeof(BancoMapper));
builder.Services.AddAutoMapper(typeof(CNPJMapper));
builder.Services.AddAutoMapper(typeof(CnaesSecundarioMapper));

builder.Services.AddAutoMapper(typeof(NCMMapper));
builder.Services.AddAutoMapper(typeof(FeriadosNacionaisMapper));


// ---

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
