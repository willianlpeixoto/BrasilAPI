using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;
using BrasilAPI.Models;
using System.Dynamic;
using System.Text.Json;

namespace BrasilAPI.Rest
{

    public class BrasilAPIRest : InterfaceBrasilAPI
    {

        public async Task<GenericoResponse<EnderecoModel>> BuscarEndrecoPorCEP(string sCEP)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/cep/v1/{"+ sCEP + "}");
            var response = new GenericoResponse<EnderecoModel>();

            using ( var cliente = new HttpClient() )
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<EnderecoModel>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {
                    
                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<BancoModel>> BuscarBanco(string sCodigoBanco)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1/" + sCodigoBanco );
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1/{" +  sCodigoBanco + "}"); // esse nao pode conter as chaves. a API original esta assim
            var response = new GenericoResponse<BancoModel>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<BancoModel>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<List<BancoModel>>> BuscarTodosBancos()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");
            var response = new GenericoResponse<List<BancoModel>>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<List<BancoModel>>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<CNPJModel>> BuscarCNPJ(string sCNPJ)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/cnpj/v1/{" + sCNPJ + "}");
            var response = new GenericoResponse<CNPJModel>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<CNPJModel>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<NCMModel>> BuscarNCM(string sCodigoNCM)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/ncm/v1/" + sCodigoNCM);
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1/{" +  sCodigoNCM + "}"); // esse nao pode conter as chaves. a API original esta assim
            var response = new GenericoResponse<NCMModel>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<NCMModel>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<List<NCMModel>>> BuscarTodosNCMs()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/ncm/v1");
            var response = new GenericoResponse<List<NCMModel>>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<List<NCMModel>>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

        public async Task<GenericoResponse<List<FeriadosNacionaisModel>>> BuscarFeriadosNacionais(int nAno)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/feriados/v1/" + nAno);
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1/{" +  nAno + "}"); // esse nao pode conter as chaves. a API original esta assim
            var response = new GenericoResponse<List<FeriadosNacionaisModel>>();

            using (var cliente = new HttpClient())
            {

                var resposta = await cliente.SendAsync(request);
                var ConteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objResposta = JsonSerializer.Deserialize<List<FeriadosNacionaisModel>>(ConteudoResposta);

                if (resposta.IsSuccessStatusCode)
                {

                    foreach (var obj in objResposta)
                    {

                        //Antes de retornar, dizer se o dia é dia de semana ou fim de semana

                        obj.FimdeSemana = false;

                        DateTime data = Convert.ToDateTime( obj.Date);

                        if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
                        {
                            obj.FimdeSemana = true;
                        }

                    }

                    // ---

                    response.CodHttp = resposta.StatusCode;
                    response.DadosRetorno = objResposta;

                }
                else
                {

                    response.CodHttp = resposta.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(ConteudoResposta);

                }

            }

            return response;

        }

    }

}
