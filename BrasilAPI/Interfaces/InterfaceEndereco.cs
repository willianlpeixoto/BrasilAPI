using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceEndereco
    {

        Task<GenericoResponse<EnderecoResponse>> BuscarEndrecoPorCEP(string sCEP);

    }

}
