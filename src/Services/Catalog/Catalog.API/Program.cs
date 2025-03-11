var builder = WebApplication.CreateBuilder(args);

// Add Services To App DI Container

var app = builder.Build();

// Configure The Http Request Pipeline

app.Run();
