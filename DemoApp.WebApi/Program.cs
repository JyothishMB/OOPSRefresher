using Messaging.Lib;
using Messaging.Lib.Interfaces;
using MessagingTools;
using MessagingTools.ConcreteFactory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMessenger, SMS>();
builder.Services.AddScoped<IMessenger, Email>();
builder.Services.AddScoped<IMessenger, WatsApp>();
builder.Services.AddScoped<Factory, SMSFactory>();
builder.Services.AddScoped<Factory, EmailFactory>();
builder.Services.AddScoped<Factory, WatsAppFactory>();

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
