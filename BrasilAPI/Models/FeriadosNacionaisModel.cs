using System.Text.Json.Serialization;

namespace BrasilAPI.Models
{
    public class FeriadosNacionaisModel
    {

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("type")]
        public string Tipo { get; set; }

        // ---

        public bool FimdeSemana { get; set; } // origem de processamento interno

    }

}
