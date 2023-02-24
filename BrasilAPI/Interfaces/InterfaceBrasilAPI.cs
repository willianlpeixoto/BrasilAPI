using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceBrasilAPI
    {

        Task<GenericoResponse<EnderecoModel>> BuscarEndrecoPorCEP(string sCEP);
        Task<GenericoResponse<List<BancoModel>>> BuscarTodosBancos();
        Task<GenericoResponse<BancoModel>> BuscarBanco(string sCodigoBanco);
        Task<GenericoResponse<CNPJModel>> BuscarCNPJ(string sCNPJ);
        Task<GenericoResponse<List<NCMModel>>> BuscarTodosNCMs();
        Task<GenericoResponse<NCMModel>> BuscarNCM(string sCodigoNCM);
        Task<GenericoResponse<List<FeriadosNacionaisModel>>> BuscarFeriadosNacionais(int nAno);

    }

}
