using System.Text.Json.Serialization;

namespace API.Service.Models
{
    public class Manufacture
    {

        [JsonPropertyName("manufacturer")]
        public string Name { get; set; }

        [JsonPropertyName("items")]
        public IList<Car> Cars { get; set; }
    }
}
