using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;
using BrasilAPI.Models;

namespace BrasilAPI.Services
{
    public class NCMService : InterfaceNCM
    {

        private readonly IMapper _mapper;
        private readonly InterfaceBrasilAPI _brasilAPI;

        public NCMService(IMapper mapper, InterfaceBrasilAPI brasilAPI)
        {

            _mapper = mapper;
            _brasilAPI = brasilAPI;

        }

        // ---

        public async Task<GenericoResponse<NCMResponse>> BuscarNCM(string sCodigoNCM)
        {

            var NCM = await _brasilAPI.BuscarNCM(sCodigoNCM);

            return _mapper.Map<GenericoResponse<NCMResponse>>(NCM);

        }

        public async Task<GenericoResponse<List<NCMResponse>>> BuscarTodosNCMs()
        {

            var NCM = await _brasilAPI.BuscarTodosNCMs();

            return _mapper.Map<GenericoResponse<List<NCMResponse>>>(NCM);

        }

    }

}
