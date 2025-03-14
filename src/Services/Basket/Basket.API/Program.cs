var builder = WebApplication.CreateBuilder(args);

// Add Services To App DI Container
var assembly = typeof(Program).Assembly;

var app = builder.Build();

// Configure The Http Request Pipeline

app.Run();
