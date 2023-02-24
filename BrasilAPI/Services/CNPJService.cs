using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;

namespace BrasilAPI.Services
{
    public class CNPJService : InterfaceCNPJ
    {

        private readonly IMapper _mapper;
        private readonly InterfaceBrasilAPI _brasilAPI;

        public CNPJService(IMapper mapper, InterfaceBrasilAPI brasilAPI)
        {

            _mapper = mapper;
            _brasilAPI = brasilAPI;

        }

        public async Task<GenericoResponse<CNPJResponse>> BuscarCNPJ(string sCNPJ)
        {

            var oCNPJ = await _brasilAPI.BuscarCNPJ(sCNPJ);

            return _mapper.Map<GenericoResponse<CNPJResponse>>(oCNPJ);

        }

    }

}
