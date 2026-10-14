var builder = WebApplication.CreateBuilder(args);

// Додаємо CORS для можливості підключення з браузера та форми
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors();

// Початковий список посилок
List<Posting> postings = new List<Posting>
{
    new Posting
    {
        Id = 1,
        From = "Київ",
        To = "Львів",
        Content = "Документи та книги",
        DeliveryType = DeliveryType.Courier,
        Weight = 1.5f,
        Width = 25,
        Height = 15,
        Depth = 20,
        Value = 350.0f,
        Price = 85.0f,
        CreatedAt = DateTime.UtcNow
    },
    new Posting
    {
        Id = 2,
        From = "Рівне",
        To = "Луцьк",
        Content = "Одяг та аксесуари",
        DeliveryType = DeliveryType.Standard,
        Weight = 2.0f,
        Width = 30,
        Height = 20,
        Depth = 10,
        Value = 500.0f,
        Price = 90.0f,
        CreatedAt = DateTime.UtcNow
    }
};

// Головна сторінка
app.MapGet("/", () => "Це API поштового сервісу PostService.");

// Отримати всі відправлення (GET /postings)
app.MapGet("/postings", () => postings);

// Отримати відправлення за id (GET /postings/{id})
app.MapGet("/postings/{id:int}", (int id) =>
{
    var item = postings.FirstOrDefault(p => p.Id == id);
    return item is not null ? Results.Ok(item) : Results.NotFound();
});

// Додати нове відправлення (POST /postings)
app.MapPost("/postings", (Posting parcel) =>
{
    parcel.Id = postings.Count > 0 ? postings.Max(p => p.Id) + 1 : 1;
    parcel.CreatedAt = DateTime.UtcNow;
    postings.Add(parcel);
    return Results.Created($"/postings/{parcel.Id}", parcel);
});

// Оновити відправлення (PUT /postings/{id})
app.MapPut("/postings/{id:int}", (int id, Posting updated) =>
{
    var item = postings.FirstOrDefault(p => p.Id == id);
    if (item is null) return Results.NotFound();

    item.From = updated.From;
    item.To = updated.To;
    item.Content = updated.Content;
    item.DeliveryType = updated.DeliveryType;
    item.Weight = updated.Weight;
    item.Width = updated.Width;
    item.Height = updated.Height;
    item.Depth = updated.Depth;
    item.Value = updated.Value;
    item.Price = updated.Price;

    return Results.Ok(item);
});

// Видалити відправлення (DELETE /postings/{id})
app.MapDelete("/postings/{id:int}", (int id) =>
{
    var item = postings.FirstOrDefault(p => p.Id == id);
    if (item is null) return Results.NotFound();

    postings.Remove(item);
    return Results.NoContent();
});

app.Run();

// Типи доставки
public enum DeliveryType
{
    Standard,
    Courier,
    Express
}

// Модель відправлення
public class Posting
{
    public int Id { get; set; }
    public string From { get; set; } = string.Empty;
    public string To { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DeliveryType DeliveryType { get; set; }
    public float Weight { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Depth { get; set; }
    public float Value { get; set; }
    public float Price { get; set; }
    public DateTime CreatedAt { get; set; }
}
