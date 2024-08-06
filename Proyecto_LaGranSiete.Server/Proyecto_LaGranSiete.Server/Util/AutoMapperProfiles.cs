using AutoMapper;
using Proyecto_LaGranSiete.BD.Data.Entity;
using Proyecto_LaGranSiete.Shared.DTO;
//profile <- "es una clase de AutoMapper"

namespace Proyecto_LaGranSiete.Server.Util
{
    //class AutoMapperProfiles (HEREDA DE) -- Profile, con su respectivo constructor
    public class AutoMapperProfiles : Profile
    {
        //constructor AutoMapper
        protected AutoMapperProfiles()
        {
            CreateMap<CrearCanchasDTO, Canchas>();
            CreateMap<Canchas, CrearCanchasDTO>();


            CreateMap<CrearEquiposDTO, Equipos>();
            CreateMap<Equipos, CrearEquiposDTO>();


            CreateMap<CrearPagosDTO, Pagos>();
            CreateMap<Pagos, CrearPagosDTO>();


            CreateMap<CrearPartidosDTO, Partidos>();
            CreateMap<Partidos, CrearPartidosDTO>();


            CreateMap<CrearReservaDTO, Reservas>();
            CreateMap<Reservas, CrearReservaDTO>();


            CreateMap<CrearUsuariosDTO, Usuarios>();
            CreateMap<Usuarios, CrearUsuariosDTO>();
        }
    }
}
