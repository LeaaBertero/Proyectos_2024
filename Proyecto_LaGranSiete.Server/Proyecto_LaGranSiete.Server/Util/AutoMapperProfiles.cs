using AutoMapper;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;
//profile <- "es una clase de AutoMapper"

namespace Proyecto_LaGranSiete.Server.Util
{
    public class AutoMapperProfiles : Profile
    {
        //constructor AutoMapper
        protected AutoMapperProfiles()
        {
            CreateMap<CrearReservaDTO, Reservas>();
        }
    }
}
