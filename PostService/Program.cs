var builder = WebApplication.CreateBuilder(args);

// Підключення контролерів
builder.Services.AddControllers();

// Налаштування CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

// Головна тестова сторінка
app.MapGet("/", () => "Це API поштового сервісу PostService.");

// Реєстрація маршрутів контролерів
app.MapControllers();

app.Run();
