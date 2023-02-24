using System.Text.Json.Serialization;

namespace BrasilAPI.Models
{
    public class EnderecoModel
    {

        // EnderecoModel myDeserializedClass = JsonConvert.DeserializeObject<EnderecoModel>(myJsonResponse);
        [JsonPropertyName("cep")]
        public string CEP { get; set; }

        [JsonPropertyName("state")]
        public string Estado { get; set; }

        [JsonPropertyName("city")]
        public string Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string Regiao { get; set; }

        [JsonPropertyName("street")]
        public string Logradouro { get; set; }

        [JsonPropertyName("service")]
        public string Servico { get; set; }

    }

}
