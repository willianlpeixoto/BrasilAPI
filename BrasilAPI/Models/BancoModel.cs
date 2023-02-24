using System.Text.Json.Serialization;

namespace BrasilAPI.Models
{
    public class BancoModel
    {

        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<BancoModel>>(myJsonResponse);
        [JsonPropertyName("ispb")]
        public string Ispb { get; set; }

        [JsonPropertyName("name")]
        public string NomeAbreviado { get; set; }

        [JsonPropertyName("code")]
        public int ?Codigo { get; set; } //? pode ser nulo

        [JsonPropertyName("fullName")]
        public string NomeCompleto { get; set; }

    }

}
