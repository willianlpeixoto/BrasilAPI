using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mapper
{
    public class NCMMapper : Profile
    {
        public NCMMapper()
        {

            CreateMap(typeof(GenericoResponse<>), typeof(GenericoResponse<>));
            CreateMap<NCMResponse, NCMModel>();
            CreateMap<NCMModel, NCMResponse>();

        }

    }
}
