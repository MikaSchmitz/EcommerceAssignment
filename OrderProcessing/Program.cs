using OrderProcessing.Configuration;
using OrderProcessing.Data.Setup;

var builder = WebApplication.CreateBuilder(args);

// get appsettings data
AppSettingsManager.Initialize(builder.Configuration);

// Add services to the container.
builder.Services.AddDataLayer();
builder.Services.AddControllers();
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
