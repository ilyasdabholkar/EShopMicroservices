var builder = WebApplication.CreateBuilder(args);

// Add Services To App DI Container
builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

var app = builder.Build();

// Configure The Http Request Pipeline
app.MapCarter();

app.Run();
