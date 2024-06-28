using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDAL;
using DomeWarsDAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DomeWarsContext>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IPlayerService, PlayerService>();

builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IGameService, GameService>();

builder.Services.AddScoped<IGangRepository, GangRepository>();
builder.Services.AddScoped<IGangService, GangService>();

builder.Services.AddScoped<ITerritoryRepository,  TerritoryRepository>();
builder.Services.AddScoped<ITerritoryService, TerritoryService>();


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
