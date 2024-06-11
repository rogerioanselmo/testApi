using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace API.Service.Models
{
    public class Car
    {
        [JsonPropertyName("sku")]
        public object Sku { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("cost")]
        public decimal Cost { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        public string Manufaturer { get; set; }
    }
}
