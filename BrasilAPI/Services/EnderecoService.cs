using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;

namespace BrasilAPI.Services
{
    public class EnderecoService : InterfaceEndereco
    {

        private readonly IMapper _mapper;
        private readonly InterfaceBrasilAPI _brasilAPI;
         
        public EnderecoService(IMapper mapper, InterfaceBrasilAPI brasilAPI)
        {

            _mapper = mapper;
            _brasilAPI = brasilAPI;

        }

        public async Task<GenericoResponse<EnderecoResponse>> BuscarEndrecoPorCEP(string sCEP)
        {

            var endereco = await _brasilAPI.BuscarEndrecoPorCEP(sCEP);

            return _mapper.Map<GenericoResponse<EnderecoResponse>>(endereco);
        
        }

    }

}
