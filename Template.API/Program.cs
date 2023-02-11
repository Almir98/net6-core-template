using Template.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//Extension methods
builder.Services.AddSwaggerConfiguration();
builder.Services.AddApiVersioning();
builder.Services.EnableCors();

builder.Services.RegisterServices();
builder.Services.AddAutoMapper(typeof(MapperConfiguration));


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

//Extension methods
app.UseCors("CORS");

app.Run();
