using System.Text.Json.Serialization;

namespace PostServiceFormsApp.Models
{
    public class Posting
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("deliveryType")]
        public int DeliveryType { get; set; } // 0 - Стандартна, 1 - Кур'єрська / Експрес

        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        [JsonPropertyName("width")]
        public decimal Width { get; set; }

        [JsonPropertyName("height")]
        public decimal Height { get; set; }

        [JsonPropertyName("depth")]
        public decimal Depth { get; set; }

        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        // Допоміжні властивості для відображення в таблиці
        [JsonIgnore]
        public string DeliveryTypeName => DeliveryType switch
        {
            0 => "Стандартна (відділення)",
            1 => "Кур'єрська доставка",
            _ => $"Тип {DeliveryType}"
        };

        [JsonIgnore]
        public string DimensionsText => $"{Depth:0.##} x {Width:0.##} x {Height:0.##} см";
    }
}
