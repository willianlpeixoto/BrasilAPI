using BrasilAPI.Dtos;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceFeriadosNacionais
    {

        Task<GenericoResponse<List<FeriadosNacionaisResponse>>> BuscarFeriadosNacionais(int nAno);

    }
}
