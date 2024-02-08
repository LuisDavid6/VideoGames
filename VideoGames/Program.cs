using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using VideoGames;
using VideoGames.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("VideoGamesDB");

// Add services

builder.Services.AddDbContext<VideoGamesDBContext>(option => option.UseSqlServer(connectionString));

//Add AutoMapper service
builder.Services.AddAutoMapper(typeof(MappingConfig));


//Serializer to prevent circular reference
/*builder.Services.AddControllers().AddJsonOptions(x =>
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve); */

//Ignore circular references
builder.Services.AddControllers()
    .AddJsonOptions(opciones =>
    opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//builder.Services.AddJwtTokenServices(builder.Configuration);

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
