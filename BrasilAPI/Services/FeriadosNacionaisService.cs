using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;

namespace BrasilAPI.Services
{
    public class FeriadosNacionaisService : InterfaceFeriadosNacionais
    {

        private readonly IMapper _mapper;
        private readonly InterfaceBrasilAPI _brasilAPI;

        public FeriadosNacionaisService(IMapper mapper, InterfaceBrasilAPI brasilAPI)
        {

            _mapper = mapper;
            _brasilAPI = brasilAPI;

        }

        public async Task<GenericoResponse<List<FeriadosNacionaisResponse>>> BuscarFeriadosNacionais(int nAno)
        {

            var oFeriadosNacionais = await _brasilAPI.BuscarFeriadosNacionais(nAno);

            return _mapper.Map<GenericoResponse<List<FeriadosNacionaisResponse>>>(oFeriadosNacionais); 

        }

    }

}
