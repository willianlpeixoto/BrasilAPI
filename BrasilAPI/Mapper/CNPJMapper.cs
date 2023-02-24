using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mapper
{
    public class CNPJMapper : Profile
    {

        public CNPJMapper()
        {

            CreateMap(typeof(GenericoResponse<>), typeof(GenericoResponse<>));
            CreateMap<CNPJResponse, CNPJModel>();
            CreateMap<CNPJModel, CNPJResponse>();

        }

    }

}
