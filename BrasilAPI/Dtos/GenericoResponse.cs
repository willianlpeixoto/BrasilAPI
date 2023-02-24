using System.Dynamic;
using System.Net;

namespace BrasilAPI.Dtos
{
    public class GenericoResponse<T> where T : class
    {

        public HttpStatusCode CodHttp { get; set; }
        public T DadosRetorno { get; set; }
        public ExpandoObject ErroRetorno {  get; set; } 

    }

}
