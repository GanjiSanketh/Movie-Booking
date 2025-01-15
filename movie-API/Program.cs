var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // Add support for API controllers
builder.Services.AddOpenApi();  // Add OpenAPI (Swagger)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();  // Swagger for API documentation
}

app.UseHttpsRedirection();

// Map Controllers to handle API requests
app.MapControllers();  // This will enable your controllers' routes

app.Run();
