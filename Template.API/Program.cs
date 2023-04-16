using MapperConfiguration = Template.API.Extensions.MapperConfiguration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureLoggerService();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

//Extension methods
builder.Services.AddAutoMapper(typeof(MapperConfiguration));
builder.Services.AddPersistance(builder.Configuration);

builder.Services.RegisterRepositories();

//builder.Services.RegisterServices();



builder.Services.AddSwaggerConfiguration();
//builder.Services.AddApiVersioning();
builder.Services.EnableCors();

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
