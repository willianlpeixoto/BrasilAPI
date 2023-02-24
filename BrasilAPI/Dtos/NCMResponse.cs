using System.Text.Json.Serialization;

namespace BrasilAPI.Dtos
{
    public class NCMResponse
    {

        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public string TipoAto { get; set; }
        public string NumeroAto { get; set; }
        public string AnoAto { get; set; }

    }

}
