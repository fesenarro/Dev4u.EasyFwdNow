using AutoMapper;
using Dev4u.EasyFwdNow.Servicios;
namespace Dev4u.EasyFwdNow;

public class EasyFwdNowApplicationAutoMapperProfile : Profile
{
    public EasyFwdNowApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Servicio, ServicioDto>();
        CreateMap<CreateUpdateServicioDto, Servicio>();
    }
}
