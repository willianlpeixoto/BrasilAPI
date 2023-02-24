using System.Text.Json.Serialization;

namespace BrasilAPI.Dtos
{
    public class EnderecoResponse
    {

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Logradouro { get; set; }
        
        [JsonIgnore]
        public string Servico { get; set; }

    }

}
