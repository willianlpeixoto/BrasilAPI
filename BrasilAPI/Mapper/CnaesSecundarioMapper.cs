using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mapper
{
    public class CnaesSecundarioMapper : Profile
    {

        public CnaesSecundarioMapper()
        {

            CreateMap(typeof(GenericoResponse<>), typeof(GenericoResponse<>));
            CreateMap<CnaesSecundarioResponse, CnaesSecundarioModel>();
            CreateMap<CnaesSecundarioModel, CnaesSecundarioResponse>();

        }

    }

}
