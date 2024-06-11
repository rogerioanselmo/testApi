using API.Service.Models;
using System.Text.Json.Serialization;

namespace API.Service.Data
{
    public class DataModel
    {
        [JsonPropertyName("inventory")]
        public IList<Manufacture> Inventory { get; set; }
    }

    public class CollectionData
    {
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("items")]
        public IList<Car> Items { get; set; }
    }
}
