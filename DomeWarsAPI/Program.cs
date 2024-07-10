using DomeWarsAPI.Tools;
using DomeWarsBLL.Interfaces.Repositories;
using DomeWarsBLL.Interfaces.Services;
using DomeWarsBLL.Services;
using DomeWarsDAL;
using DomeWarsDAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

builder.Services.AddScoped<IBusinessRepository, BusinessRepository>();
builder.Services.AddScoped<IBusinessService, BusinessService>();

builder.Services.AddScoped<TokenGenerator>();

//Config de la sécurité via Token JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
        options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration.GetSection("TokenInfo").GetSection("secretKey").Value)),
                ValidateLifetime = true,
                ValidAudience = "https://monclient.com",
                ValidIssuer = "https://monapi.com",
                ValidateAudience = false
            };
        }
    );
builder.Services.AddAuthorization(options =>
{
    //options.AddPolicy("adminPolicy", policy => policy.RequireRole("Admin"));
    //options.AddPolicy("modoPolicy", policy => policy.RequireRole("admin", "moderator"));
    options.AddPolicy("isConnectedPolicy", policy => policy.RequireAuthenticatedUser());
});

//builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
