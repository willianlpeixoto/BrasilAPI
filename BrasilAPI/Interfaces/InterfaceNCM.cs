using BrasilAPI.Dtos;

namespace BrasilAPI.Interfaces
{
    public interface InterfaceNCM
    {

        Task<GenericoResponse<List<NCMResponse>>> BuscarTodosNCMs();
        Task<GenericoResponse<NCMResponse>> BuscarNCM(string sCodigoNCM);

    }
}
