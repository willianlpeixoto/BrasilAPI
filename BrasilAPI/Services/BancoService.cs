using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Interfaces;
using BrasilAPI.Models;

namespace BrasilAPI.Services
{
    public class BancoService : InterfaceBanco
    {

        private readonly IMapper _mapper;
        private readonly InterfaceBrasilAPI _brasilAPI;

        public BancoService(IMapper mapper, InterfaceBrasilAPI brasilAPI)
        {

            _mapper = mapper;
            _brasilAPI = brasilAPI;

        }

        // ---

        public async Task<GenericoResponse<BancoResponse>> BuscarBanco(string sCodigoBanco)
        {

            var banco = await _brasilAPI.BuscarBanco(sCodigoBanco);

            return _mapper.Map<GenericoResponse<BancoResponse>>(banco);

        }

        public async Task<GenericoResponse<List<BancoResponse>>> BuscarTodosBancos()
        {

            var banco = await _brasilAPI.BuscarTodosBancos();

            return _mapper.Map<GenericoResponse<List<BancoResponse>>>(banco);

        }

    }

}
