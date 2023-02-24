using AutoMapper;
using BrasilAPI.Dtos;
using BrasilAPI.Models;

namespace BrasilAPI.Mapper
{
    public class FeriadosNacionaisMapper : Profile
    {

        public FeriadosNacionaisMapper()
        {

            CreateMap(typeof(GenericoResponse<>), typeof(GenericoResponse<>));
            CreateMap<FeriadosNacionaisResponse, FeriadosNacionaisModel>();
            CreateMap<FeriadosNacionaisModel, FeriadosNacionaisResponse>();

        }

    }

}
