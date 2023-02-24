using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceCNPJ
    {

        Task<GenericoResponse<CNPJResponse>> BuscarCNPJ(string sCNPJ);

    }

}
