using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mapper
{
    public class BancoMapper : Profile
    {
        public BancoMapper()
        {

            CreateMap(typeof(GenericoResponse<>), typeof(GenericoResponse<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();

        }

    }

}
