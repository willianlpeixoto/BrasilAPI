using System.Text.Json.Serialization;

namespace BrasilAPI.Dtos
{
    public class FeriadosNacionaisResponse
    {

        public string Date { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        // ---

        public bool FimdeSemana { get; set; }

    }

}
