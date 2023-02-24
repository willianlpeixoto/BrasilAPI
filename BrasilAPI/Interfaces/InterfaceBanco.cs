using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceBanco
    {

        Task<GenericoResponse<List<BancoResponse>>> BuscarTodosBancos();
        Task<GenericoResponse<BancoResponse>> BuscarBanco(string sCodigoBanco);

    }

}
