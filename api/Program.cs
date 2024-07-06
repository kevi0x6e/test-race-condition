using domain.Application;
using application.BankAccountService;
using Microsoft.OpenApi.Models;
using System.Net;
using application.LoggerService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Polly Retry API Testing", Version = "v1" });
});

builder.Services.AddScoped<IBankAccountService, BankAccountService>();
builder.Services.AddScoped<IConsoleLoggerService, ConsoleLoggerService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Polly Retry API Testing");
        c.RoutePrefix = string.Empty; 
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
